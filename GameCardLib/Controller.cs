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
        /*
        public event Action NewGameEvent;
        public event Action ShuffleEvent;
        public event Func<Dictionary<string, string>> HitEvent;
        public event Func<int, bool> StandEvent;
        public event Func<bool> NoPlayerLeftEvent;
        public event Func<bool> NextPlayerEvent;
        public event Func<bool> NewRoundEvent;
        */
        
        PlayerManager<Player> playersList;
        Deck deck;
        Player dealer;
        public delegate void DealerDelegate();
        public event DealerDelegate dealerrEvent;
        public delegate void SelectedPlayerDelegate();
        public event SelectedPlayerDelegate selectedPlayerEvent;
        public int currentPlayerIndex;

        //När man trycker next så kollar programet om alla spelare har fler kort än dealern om det är fallet är det dealerns tur att göra ett drag och current player sätts till den första

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
            if(currentPlayerIndex + 1 < playersList.Count)
            {
                currentPlayerIndex++;

                if (selectedPlayerEvent != null)
                {
                    selectedPlayerEvent();
                }
            }
        }

        public void DrawCard(){
            //Behöver få value och suit från enum
            //Kortet ska läggas till i spelarens hand
            //Kortet behöver tas bort från deck

           
        }

        public void Stand(Player player, Hand hand){
            //om spelaren > 21 ska han DÖ
            //Jämföra poäng med dealern
            //Korten tillbaka till deck??
        }

        public void ShuffleDeck(Deck deck){
            
        }
    }
}
