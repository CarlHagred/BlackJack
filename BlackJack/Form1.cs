using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GameCardLib;
using System.Diagnostics;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
            controller.selectedPlayerEvent += updatePlayerCards;

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (txtAOC.Text.Length != 0 && txtAOP.Text.Length != 0)
            {
                controller.NewGame(Int32.Parse(txtAOP.Text), Int32.Parse(txtAOC.Text));
            }
        }

        private void txtDealerCards_Click(object sender, EventArgs e)
        {

        }
        
        public void updatePlayerCards()
        {
            txtSelectedPlayerCards.Text = controller.GetCurrentPlayerCards();
            txtCurrentPlayer.Text = controller.GetCurrentPlayerName();
            txtCurrentPlayerScore.Text = controller.GetCurrentPlayerScore().ToString();

            //hämta korten hos den valda spelaren och visa i gui
            //txtSelectedPlayerCards.text = controller.currentPlayer
        }
    }
}  
