using System;

namespace GameCardLib.Models
{
    public class Player
    {
        public Hand Hand
        {
            get
            {
                return Hand;
            }
            set
            {
                Hand = value;
            }
        }

        public bool IsFinished
        {
            get
            {
                return IsFinished;
            }
            set
            {
                IsFinished = value;
            }
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string PlayerID
        {
            get
            {
                return PlayerID;
            }
            set
            {
                PlayerID = value;
            }
        }

        public bool Winner
        {
            get
            {
                return Winner;
            }
            set
            {
                Winner = value;
            }
        }
        public Player(string id, string name, Hand hand)
        {
        }
        public string ToString()
        {
            return null;
        }
    }
}
