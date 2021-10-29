
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDealerScore = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayerScore = new System.Windows.Forms.Label();
            this.txtSelectedPlayerCards = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtAOC = new System.Windows.Forms.TextBox();
            this.txtAOP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDealerCards
            // 
            this.txtDealerCards.AutoSize = true;
            this.txtDealerCards.Location = new System.Drawing.Point(571, 154);
            this.txtDealerCards.Name = "txtDealerCards";
            this.txtDealerCards.Size = new System.Drawing.Size(70, 15);
            this.txtDealerCards.TabIndex = 2;
            this.txtDealerCards.Text = "DealerCards";
            this.txtDealerCards.Click += new System.EventHandler(this.txtDealerCards_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dealer";
            // 
            // txtDealerScore
            // 
            this.txtDealerScore.AutoSize = true;
            this.txtDealerScore.Location = new System.Drawing.Point(85, 232);
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
            this.txtSelectedPlayerCards.Location = new System.Drawing.Point(539, 397);
            this.txtSelectedPlayerCards.Name = "txtSelectedPlayerCards";
            this.txtSelectedPlayerCards.Size = new System.Drawing.Size(122, 15);
            this.txtSelectedPlayerCards.TabIndex = 7;
            this.txtSelectedPlayerCards.Text = "Selected players cards";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stand";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Hit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 48);
            this.button3.TabIndex = 10;
            this.button3.Text = "Shuffle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 48);
            this.button4.TabIndex = 11;
            this.button4.Text = "Next player";
            this.button4.UseVisualStyleBackColor = true;
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
            // txtAOC
            // 
            this.txtAOC.Location = new System.Drawing.Point(976, 12);
            this.txtAOC.Name = "txtAOC";
            this.txtAOC.PlaceholderText = "Amount of cards";
            this.txtAOC.Size = new System.Drawing.Size(110, 23);
            this.txtAOC.TabIndex = 13;
            // 
            // txtAOP
            // 
            this.txtAOP.Location = new System.Drawing.Point(850, 12);
            this.txtAOP.Name = "txtAOP";
            this.txtAOP.PlaceholderText = "Amount of players";
            this.txtAOP.Size = new System.Drawing.Size(110, 23);
            this.txtAOP.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(130, 624);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(956, 51);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 687);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtAOP);
            this.Controls.Add(this.txtAOC);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.txtSelectedPlayerCards);
            this.Controls.Add(this.txtCurrentPlayerScore);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.txtDealerScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDealerCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtDealerCards;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDealerScore;
        private System.Windows.Forms.Label txtCurrentPlayer;
        private System.Windows.Forms.Label txtCurrentPlayerScore;
        private System.Windows.Forms.Label txtSelectedPlayerCards;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtAOC;
        private System.Windows.Forms.TextBox txtAOP;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

