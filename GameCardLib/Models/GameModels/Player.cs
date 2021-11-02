using System;

namespace GameCardLib.Models
{
    public class Player
    {

        private string name;
        private bool isFinished;
        private string playerID;
        private bool winner;
        private Hand hand;

        public Hand Hand
        {
            get
            {
                return hand;
            }
            set
            {
                hand = value;
            }
        }

        public bool IsFinished
        {
            get
            {
                return this.isFinished;
            }
            set
            {
                this.isFinished = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string PlayerID
        {
            get
            {
                return playerID;
            }
            set
            {
                playerID = value;
            }
        }

        public bool Winner
        {
            get
            {
                return winner;
            }
            set
            {
                winner = value;
            }
        }

        public Player()
        {
            hand = new Hand();
        }
    }
}
