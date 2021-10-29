using System;
using System.Collections.Generic;
using System.Diagnostics;
using GameCardLib.Models.Lists;

namespace GameCardLib.Models
{
    public class Deck
    {
        DeckManager<Card> deckList = new DeckManager<Card>();
        private static Random rng = new Random();
        Dictionary<string, int> cardValues = new Dictionary<string, int>()
        {
            {"Two", 2},
            {"Three", 3},
            {"Four", 4},
            {"Five", 5},
            {"Six", 6},
            {"Seven" , 7},
            {"Eight", 8},
            {"Nine", 9},
            {"Ten", 10},
            {"Jack", 10},
            {"Queen", 10},
            {"King", 10},
            {"Ace", 11},
         };

        public bool GameIsDone
        {
            get
            {
                return true;
            }
            set
            {
                GameIsDone = value;
            }
        }

        public Deck(int amountOfCards)
        {
            if(amountOfCards != 0)
            {
                InitializeDeck(amountOfCards);
                OnShuffle();
            }     
        }

        public void DiscardCards()
        {
            deckList = new DeckManager<Card>();
        }

        public Card GetAt(int position)
        {
            Card card = deckList.ReturnAt(position);
            removeCard(position);
            return card;
        }

        public List<Card> getTwoCards()
        {
            List<Card> list = new List<Card>();
            list.Add(GetAt(deckList.Count + 1));
            list.Add(GetAt(deckList.Count + 1));
            return list;
        }

        private void InitializeDeck(int amountOfCards)
        {
            for (int deck = 0; deck < amountOfCards; deck++)
            {
                for (int suit = 0; suit < 4; suit++)
                {
                    for (int value = 0; value < 13; value++)
                    {
                        Card card = new Card();
                        card.Value = (Value)value;
                        card.Suit = (Suit)suit;
                        deckList.Add(card);
                    }
                }
            }
        }

        public int NumberOfCards()
        {
            return deckList.Count;
        }

        public void OnShuffle()
        {
            Debug.WriteLine(deckList.ReturnAt(0).Value);
            int cardsLeft = NumberOfCards();
            while (cardsLeft > 1)
            {
                cardsLeft--;
                int position = rng.Next(cardsLeft + 1);
                Card value = deckList.ReturnAt(position);
                deckList.Replace(position,deckList.ReturnAt(cardsLeft));
                deckList.Replace(cardsLeft, value);
            }
        }

        public void removeCard(int pos)
        {
            deckList.Remove(pos);
        }

        public int SumOfCards()
        {
            int sum = 0;
            for (int position = 0; position < NumberOfCards(); position++)
            {
                sum += cardValues[deckList.ReturnAt(position).Value.ToString()];
            }
            return sum;
        }
    }
}
