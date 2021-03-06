using GameCardLib.Models;
using GameCardLib.Models.Lists;
using System.Linq;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using UtilitiesLib.DB;

namespace GameCardLib
{
    public class Controller
    {
        GameDbContext gameDbContext = new GameDbContext();
        Round round;
        PlayerRound playerRound;
        PlayerManager<Player> playersList;
        Deck deck;
        Player dealer;
        public delegate void DealerDelegate();
        public event DealerDelegate dealerrEvent;
        public delegate void SelectedPlayerDelegate();
        public event SelectedPlayerDelegate selectedPlayerEvent;
        public delegate void VictoryDelegate();
        public event VictoryDelegate victoryEvent;
        public delegate void DbInfoDelegate();
        public event DbInfoDelegate dbInfoEvent;
        public int currentPlayerIndex;
        public int finishedPlayrs = 0;
        public int highestScore = 0;
        public int gameId = 1;
        public int aop = 0;
        List<Round> roundList;
        List<PlayerRound> playerRoundList;

        public void NewGame(int amountOfPlayers, int amountOfCards)
        {
            aop = amountOfPlayers;
            playersList = new PlayerManager<Player>();
            deck = new Deck(amountOfCards);
            List<Card> list;
            highestScore = 0;

            playersList = new PlayerManager<Player>();
            for (int i=0; i < amountOfPlayers; i++)
            {
                list = deck.getTwoCards();
                Player player = new Player();
                player.Name = "Player: " + (i + 1).ToString();
                player.Hand.AddCard(list[0]);
                player.Hand.AddCard(list[1]);
                playersList.Add(player);
            }

            currentPlayerIndex = 0;
            
            if(selectedPlayerEvent != null)
            {
                selectedPlayerEvent();
            }

            list = deck.getTwoCards();
            dealer = new Player();
            dealer.Name = "Dealer";
            dealer.Hand.AddCard(list[0]);
            dealer.Hand.AddCard(list[1]);
            dealerrEvent();
        }

        public void RetriveDb()
        {
            using (var context = new GameDbContext())
            {
                roundList = context.Rounds.ToList();
                playerRoundList = context.PlayerRounds.ToList();

                foreach (var round in roundList)
                {
                    if (round.gameID >= this.gameId) this.gameId = (round.gameID + 1);
                }
            }
            dbInfoEvent();
        }

        public void ChangeRound(int Id, int AOP, int HighestScore)
        {
            var round = gameDbContext.Rounds.First(r => r.Id == Id);
            round.amountOfPlayers = AOP;
            round.highestScore = HighestScore;
            gameDbContext.Update(round);
            gameDbContext.SaveChanges();
            dbInfoEvent();
        }

        public void ChangePlayerRound(int Id, string PlayerName, int Score)
        {
            var playerRound = gameDbContext.PlayerRounds.First(pr => pr.Id == Id);
            playerRound.playerName = PlayerName;
            playerRound.score = Score;
            gameDbContext.Update(playerRound);
            gameDbContext.SaveChanges();
            dbInfoEvent();
        }

        public List<Round> RoundList { get { return roundList; } }

        public List<PlayerRound> PlayerRoundList { get { return playerRoundList; } }

        public string GetCurrentPlayerCards()
        {
            Player player = playersList.ReturnAt(currentPlayerIndex);
            Hand hand = player.Hand;
            return hand.showCards();
        }

        public string GetCurrentPlayerName()
        {
            Player player = playersList.ReturnAt(currentPlayerIndex);
            return player.Name;
        }

        public int GetCurrentPlayerScore()
        {
            Player player = playersList.ReturnAt(currentPlayerIndex);
            return player.Hand.Score();
        }

        public bool GetPlayerDoneStatus()
        {
            return playersList.ReturnAt(currentPlayerIndex).IsFinished;
        }

        public string GetDealerCards()
        {
            Hand hand = dealer.Hand;
            return hand.showCards();
        }
        public string GetDealerName()
        {
            return dealer.Name;
        }

        public int GetDealerScore()
        {
            return dealer.Hand.Score();
        }

        public void NextPlayer()
        {
            if(finishedPlayrs != playersList.Count)
            {
                if (currentPlayerIndex + 1 < playersList.Count)
                {

                    currentPlayerIndex++;

                    if (selectedPlayerEvent != null)
                    {
                        selectedPlayerEvent();
                    }
                }
                else
                {

                    currentPlayerIndex = 0;
                    selectedPlayerEvent();
                }
            }else if (dealer.Hand.Score() < 16)
            {
                dealer.Hand.AddCard(deck.GetAt(0));
                dealerrEvent();
                if(dealer.Hand.Score() > 16)
                {
                    victoryEvent();
                }
            } else
            {
                victoryEvent();
            }
        }

        public List<string> GetWinners()
        {
            if (dealer.Hand.Score() > 21) dealer.Lost = true;
            List<string> winners = new List<string>();
            for(int playerIndex = 0; playerIndex < playersList.Count; playerIndex++)
            {
                int curentScore = playersList.ReturnAt(playerIndex).Hand.Score();
                SavePlayerRound(playersList.ReturnAt(playerIndex));
                if ((curentScore > dealer.Hand.Score() || dealer.Lost) && !playersList.ReturnAt(playerIndex).Lost)
                {
                    if (curentScore >= highestScore) highestScore = curentScore;
                    winners.Add(playersList.ReturnAt(playerIndex).Name);
                }
            }

            if(winners.Count == 0 && dealer.Hand.Score() <= 21)
            {
                winners.Add("Dealer");
            }
            Debug.WriteLine("Highscore: " + highestScore);

            SaveRound();
            RetriveDb();
            return winners;
        }

        public void SavePlayerRound(Player player)
        {
            playerRound = new PlayerRound();
            playerRound.gameID = this.gameId;
            playerRound.score = player.Hand.Score();
            playerRound.playerName = player.Name;
            gameDbContext.Add(playerRound);
            gameDbContext.SaveChanges();
        }

        public void SaveRound()
        {
            round = new Round();
            round.gameID = this.gameId;
            round.amountOfPlayers = this.aop;
            round.highestScore = this.highestScore;
            gameDbContext.Add(round);
            gameDbContext.SaveChanges();
        }

        public void DrawCard()
        {
            playersList.ReturnAt(currentPlayerIndex).Hand.AddCard(deck.GetAt(0));
            if(playersList.ReturnAt(currentPlayerIndex).Hand.Score() > 21)
            {
                playersList.ReturnAt(currentPlayerIndex).Lost = true;
                playersList.ReturnAt(currentPlayerIndex).IsFinished = true;
                finishedPlayrs++;
            }
            selectedPlayerEvent();
        }

        public void Stand(){
            playersList.ReturnAt(currentPlayerIndex).IsFinished = true;
            finishedPlayrs += 1;
        }

        public void ShuffleDeck(){
            deck.OnShuffle();
        }
    }
}
