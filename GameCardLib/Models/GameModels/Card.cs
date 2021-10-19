using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib.Models
{
    public class Card
    {
        public Suit suit
        {
            get
            {
                return null;
            }
            set
            {
                suit = value;
            }
        }

        public Value value
        {
            get
            {
                return null;
            }
            set
            {
                value = value;
            }
        }
        public Card(Suit suit, Value value)
        {
        }

        public string ToString()
        {

        }
    }
}
