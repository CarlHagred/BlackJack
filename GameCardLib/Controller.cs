using GameCardLib.Models;
using GameCardLib.Models.Lists;
using System.Linq;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace GameCardLib
{
    public class Controller
    {
        PlayerManager<Player> playersList;
        Deck deck;
        Player dealer;
        public delegate void DealerDelegate();
        public event DealerDelegate dealerrEvent;
        public delegate void SelectedPlayerDelegate();
        public event SelectedPlayerDelegate selectedPlayerEvent;
        public delegate void VictoryDelegate();
        public event VictoryDelegate victoryEvent;
        public int currentPlayerIndex;
        public int finishedPlayrs = 0;

        public void NewGame(int amountOfPlayers, int amountOfCards)
        {
            playersList = new PlayerManager<Player>();
            deck = new Deck(amountOfCards);
            List<Card> list;

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
            List<string> winners = new List<string>();
            for(int playerIndex = 0; playerIndex < playersList.Count; playerIndex++)
            {
                if(playersList.ReturnAt(playerIndex).Hand.Score() > dealer.Hand.Score() && !playersList.ReturnAt(playerIndex).Lost)
                {
                    winners.Add(playersList.ReturnAt(playerIndex).Name);
                }
            }
            return winners;
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
