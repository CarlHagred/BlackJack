using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    private Deck deck;
    public class Hand
    {
        public Card LastCard
        {
            get
            {
                return null;
            }
        }

        public int NumberOfCards
        {
            get
            {
                return 0;
            }
        }

        public int Score
        {
            get
            {
                return 0;
            }
        }
        public Hand(Deck deck)
        {
        }

        public void AddCard(Card card)
        {

        }

        public void Clear()
        {

        }

        public string ToString()
        {

        }


    }
}
