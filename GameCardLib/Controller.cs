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
                player.Name = "Player: " + i.ToString();
                player.Hand.AddCard(list[0]);
                player.Hand.AddCard(list[1]);
                playersList.Add(player);
            }

            currentPlayerIndex = 0;
            
            if(selectedPlayerEvent != null)
            {
                selectedPlayerEvent();
            }

            //sätt dealer som dealer

            //Kalla på dealar eventet
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


        /*
        public Card DrawCardToHand(CardHand hand)
        {
            int sumOfCards = 0;
            Card drawn = listOfCards[listOfCards.Count - 1];
            hand.AddCardValues(drawn, sumOfCards);
            listOfCards.Remove(drawn);
            hand.Cards.Add(drawn);
            //Debug.WriteLine(drawn.Value);
            return drawn;
        }
        */

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
