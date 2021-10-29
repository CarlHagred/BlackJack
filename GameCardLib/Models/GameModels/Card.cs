using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib.Models
{
    public class Card
    {
        private Value value;
        private Suit suit; 
        public Suit Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }
        }

        public Value Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public Card()
        {
        }
    }
}
