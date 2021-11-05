using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib.Models
{
    public class Hand
    {
        private Deck deck;
        string playerCards;

        public string showCards() 
        {
            string cardString = "";
            for (int current = 0; current < deck.NumberOfCards(); current++)
            {
                if(current == 0)
                {
                    cardString += (deck.DisplayAt(current).Value + " of "  + deck.DisplayAt(current).Suit);
                    
                } else
                {
                    cardString += (", " + deck.DisplayAt(current).Value + " of " + deck.DisplayAt(current).Suit);
                }
            }

            return cardString;
        }

        public int NumberOfCards
        {
            get
            {
                return deck.NumberOfCards();
            }
        }

        public int Score()
        {
            return deck.SumOfCards();
        }

        public Hand()
        {
            this.deck = new Deck(0);
        }

        public void AddCard(Card card)
        {
            this.deck.addCard(card);
        }

        public void Clear()
        {
            this.deck.DiscardCards();
        }
    }
}
