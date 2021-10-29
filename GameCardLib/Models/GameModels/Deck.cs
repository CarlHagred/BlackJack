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
            InitializeDeck(amountOfCards);
            OnShuffle();
            Debug.WriteLine(NumberOfCards());

            Debug.WriteLine(SumOfCards());        
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
                    for (int value = 0; value < 14; value++)
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
            //Andreas hjälp med matten det blir fel anttal kort och fel summa.
            int sum = 0;
            for (int position = 0; position < NumberOfCards(); position++)
            {
                sum += (int)deckList.ReturnAt(position).Value + 1;
            }
            return sum;
        }
    }
}
