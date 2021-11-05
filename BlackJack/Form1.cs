using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GameCardLib;
using System.Linq;
using UtilitiesLib.DB;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        GameDbContext gameDbContext = new GameDbContext();
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
            cbAOP.Items.AddRange(Enumerable.Range(1, 100).Select(i => (object)i).ToArray());
            controller.selectedPlayerEvent += updatePlayerCards;
            controller.dealerrEvent += updateDealer;
            controller.victoryEvent += PresentWinners;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (cbAOP.SelectedItem != null && cbAOD.SelectedItem != null)
            {
                controller.NewGame(Int32.Parse(cbAOP.SelectedItem.ToString()), Int32.Parse(cbAOD.SelectedItem.ToString()));
            }
        }
        public void PresentWinners()
        {
            List<string> list = controller.GetWinners();
            string winners = string.Join(", ", list);
            MessageBox.Show("The winners are: " + winners);
            DisableButtons();
            btnNextPlayer.Enabled = false;
        }

        public void updatePlayerCards()
        {
            txtSelectedPlayerCards.Text = controller.GetCurrentPlayerCards();
            txtCurrentPlayer.Text = controller.GetCurrentPlayerName();
            txtCurrentPlayerScore.Text = controller.GetCurrentPlayerScore().ToString();
            btnHit.Enabled = !controller.GetPlayerDoneStatus();
            btnStand.Enabled = !controller.GetPlayerDoneStatus();
            btnShuffle.Enabled = !controller.GetPlayerDoneStatus();
        }

        public void updateDealer()
        {
            txtDealerCards.Text = controller.GetDealerCards();
            txtDealerName.Text = controller.GetDealerName();
            txtDealerScore.Text = controller.GetDealerScore().ToString();
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            controller.NextPlayer();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

            controller.ShuffleDeck();
            DisableButtons();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            controller.DrawCard();
            DisableButtons();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            controller.Stand();
            DisableButtons();
        }

        public void DisableButtons()
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            btnShuffle.Enabled = false;
        }

        private void cbAOP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbAOP.SelectedItem != null)
            {
                cbAOD.Items.AddRange(Enumerable.Range((Int32.Parse(cbAOP.SelectedItem.ToString()) + 5), 100).Select(i => (object)i).ToArray());
            }
        }
    }
}  
