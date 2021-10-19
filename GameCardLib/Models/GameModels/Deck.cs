using System;
using System.Collections.Generic;
using GameCardLib.Models.Lists;

namespace GameCardLib.Models
{
    public class Deck
    {
        private CardManager<Card> card = new CardManager<Card>();
        private Random RandomArranger;

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


        public Deck()
        {
        }

        public void AddCard(Card card)
        {

        }

        public void DiscardCards()
        {

        }

        public Card GetAt(int position)
        {
            return null;
        }

        public List<Card> getTwoCards()
        {
            return null;
        }

        private void InitializeDeck(List<Card> cardList)
        {

        }

        public int NumberOfCards()
        {
            return 0;
        }

        public void OnShuffle(object source, EventArgs eve)
        {

        }
        public void removeCard(int pos)
        {

        }

        public int SumOfCards()
        {
            return 0;
        }

        public string ToString()
        {
            return null;
        }

    }
}
