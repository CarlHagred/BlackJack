using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace BlackJack
{
    public partial class Form1 : Form
    {
        public event Action NewGameEvent;
        public event Action ShuffleEvent;
        public event Func<Dictionary<string, string>> HitEvent;
        public event Func<int, bool> StandEvent;
        public event Func<bool> NoPlayerLeftEvent;
        public event Func<bool> NextPlayerEvent;
        public event Func<bool> NewRoundEvent;

        Controller  

        public Form1()
        {
            InitializeComponent();
        }

        public void nextplayerclick()
        {
            
            if (NoPlayerLeftEvent())
            {
                NewRoundEvent();
                return;
            }

            NextPlayerEvent();
        }
    }
}  
