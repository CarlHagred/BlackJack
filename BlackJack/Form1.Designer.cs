
namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDealerCards = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.Label();
            this.txtDealerScore = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayerScore = new System.Windows.Forms.Label();
            this.txtSelectedPlayerCards = new System.Windows.Forms.Label();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnNextPlayer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAOP = new System.Windows.Forms.ComboBox();
            this.cbAOD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GameId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDealerCards
            // 
            this.txtDealerCards.AutoSize = true;
            this.txtDealerCards.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDealerCards.Location = new System.Drawing.Point(85, 283);
            this.txtDealerCards.Name = "txtDealerCards";
            this.txtDealerCards.Size = new System.Drawing.Size(117, 28);
            this.txtDealerCards.TabIndex = 2;
            this.txtDealerCards.Text = "DealerCards";
            // 
            // txtDealerName
            // 
            this.txtDealerName.AutoSize = true;
            this.txtDealerName.Location = new System.Drawing.Point(28, 377);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(40, 15);
            this.txtDealerName.TabIndex = 3;
            this.txtDealerName.Text = "Dealer";
            // 
            // txtDealerScore
            // 
            this.txtDealerScore.AutoSize = true;
            this.txtDealerScore.Location = new System.Drawing.Point(85, 377);
            this.txtDealerScore.Name = "txtDealerScore";
            this.txtDealerScore.Size = new System.Drawing.Size(48, 15);
            this.txtDealerScore.TabIndex = 4;
            this.txtDealerScore.Text = "Score: 0";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.AutoSize = true;
            this.txtCurrentPlayer.Location = new System.Drawing.Point(28, 542);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(51, 15);
            this.txtCurrentPlayer.TabIndex = 5;
            this.txtCurrentPlayer.Text = "Player: 0";
            // 
            // txtCurrentPlayerScore
            // 
            this.txtCurrentPlayerScore.AutoSize = true;
            this.txtCurrentPlayerScore.Location = new System.Drawing.Point(85, 542);
            this.txtCurrentPlayerScore.Name = "txtCurrentPlayerScore";
            this.txtCurrentPlayerScore.Size = new System.Drawing.Size(48, 15);
            this.txtCurrentPlayerScore.TabIndex = 6;
            this.txtCurrentPlayerScore.Text = "Score: 0";
            // 
            // txtSelectedPlayerCards
            // 
            this.txtSelectedPlayerCards.AutoSize = true;
            this.txtSelectedPlayerCards.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSelectedPlayerCards.Location = new System.Drawing.Point(85, 469);
            this.txtSelectedPlayerCards.Name = "txtSelectedPlayerCards";
            this.txtSelectedPlayerCards.Size = new System.Drawing.Size(204, 28);
            this.txtSelectedPlayerCards.TabIndex = 7;
            this.txtSelectedPlayerCards.Text = "Selected players cards";
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(720, 3);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(233, 48);
            this.btnStand.TabIndex = 8;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(481, 3);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(233, 48);
            this.btnHit.TabIndex = 9;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(242, 3);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(233, 48);
            this.btnShuffle.TabIndex = 10;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnNextPlayer
            // 
            this.btnNextPlayer.Location = new System.Drawing.Point(3, 3);
            this.btnNextPlayer.Name = "btnNextPlayer";
            this.btnNextPlayer.Size = new System.Drawing.Size(233, 48);
            this.btnNextPlayer.TabIndex = 11;
            this.btnNextPlayer.Text = "Next player";
            this.btnNextPlayer.UseVisualStyleBackColor = true;
            this.btnNextPlayer.Click += new System.EventHandler(this.btnNextPlayer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(1105, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 23);
            this.btnNewGame.TabIndex = 12;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNextPlayer);
            this.flowLayoutPanel1.Controls.Add(this.btnShuffle);
            this.flowLayoutPanel1.Controls.Add(this.btnHit);
            this.flowLayoutPanel1.Controls.Add(this.btnStand);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(130, 624);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 51);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // cbAOP
            // 
            this.cbAOP.FormattingEnabled = true;
            this.cbAOP.Location = new System.Drawing.Point(802, 12);
            this.cbAOP.Name = "cbAOP";
            this.cbAOP.Size = new System.Drawing.Size(132, 23);
            this.cbAOP.TabIndex = 16;
            this.cbAOP.Text = "Amount of players";
            this.cbAOP.SelectionChangeCommitted += new System.EventHandler(this.cbAOP_SelectionChangeCommitted);
            // 
            // cbAOD
            // 
            this.cbAOD.DisplayMember = "1";
            this.cbAOD.FormattingEnabled = true;
            this.cbAOD.Location = new System.Drawing.Point(954, 12);
            this.cbAOD.Name = "cbAOD";
            this.cbAOD.Size = new System.Drawing.Size(132, 23);
            this.cbAOD.TabIndex = 17;
            this.cbAOD.Text = "Amount of decks";
            this.cbAOD.ValueMember = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameId,
            this.AOP,
            this.HighestScore});
            this.dataGridView1.Location = new System.Drawing.Point(28, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(338, 173);
            this.dataGridView1.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.Score,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(400, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(342, 173);
            this.dataGridView2.TabIndex = 19;
            // 
            // GameId
            // 
            this.GameId.HeaderText = "GameId";
            this.GameId.Name = "GameId";
            // 
            // AOP
            // 
            this.AOP.HeaderText = "AOP";
            this.AOP.Name = "AOP";
            // 
            // HighestScore
            // 
            this.HighestScore.HeaderText = "HighestScore";
            this.HighestScore.Name = "HighestScore";
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "PlayerName";
            this.PlayerName.Name = "PlayerName";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "GameId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 687);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbAOD);
            this.Controls.Add(this.cbAOP);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtSelectedPlayerCards);
            this.Controls.Add(this.txtCurrentPlayerScore);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.txtDealerScore);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.txtDealerCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDealerCards;
        private System.Windows.Forms.Label txtDealerName;
        private System.Windows.Forms.Label txtDealerScore;
        private System.Windows.Forms.Label txtCurrentPlayer;
        private System.Windows.Forms.Label txtCurrentPlayerScore;
        private System.Windows.Forms.Label txtSelectedPlayerCards;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnNextPlayer;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbAOP;
        private System.Windows.Forms.ComboBox cbAOD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighestScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

