namespace UnoOOP3_Group3
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelGameArea = new System.Windows.Forms.Panel();
            this.discardPile = new System.Windows.Forms.ListBox();
            this.computerHand = new System.Windows.Forms.ListBox();
            this.playerHand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxDiscardPile = new System.Windows.Forms.PictureBox();
            this.picBoxDrawPile = new System.Windows.Forms.PictureBox();
            this.flowLayoutPlayersHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutComputerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.btnUNO = new System.Windows.Forms.Button();
            this.playCardButton = new System.Windows.Forms.Button();
            this.richTextScoreboard = new System.Windows.Forms.RichTextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.currentTurnLabel = new System.Windows.Forms.Label();
            this.currentTurn = new System.Windows.Forms.Label();
            this.playMessageLabel = new System.Windows.Forms.Label();
            this.playMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.endGameButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiscardPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrawPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.technicalSupportToolStripMenuItem,
            this.aboutUNOToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.technicalSupportToolStripMenuItem.Text = "Technical Support";
            this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
            // 
            // aboutUNOToolStripMenuItem
            // 
            this.aboutUNOToolStripMenuItem.Name = "aboutUNOToolStripMenuItem";
            this.aboutUNOToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutUNOToolStripMenuItem.Text = "About UNO!";
            this.aboutUNOToolStripMenuItem.Click += new System.EventHandler(this.aboutUNOToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1249, 760);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelGameArea
            // 
            this.panelGameArea.Controls.Add(this.discardPile);
            this.panelGameArea.Controls.Add(this.computerHand);
            this.panelGameArea.Controls.Add(this.playerHand);
            this.panelGameArea.Controls.Add(this.label3);
            this.panelGameArea.Controls.Add(this.label2);
            this.panelGameArea.Controls.Add(this.label1);
            this.panelGameArea.Controls.Add(this.picBoxDiscardPile);
            this.panelGameArea.Controls.Add(this.picBoxDrawPile);
            this.panelGameArea.Location = new System.Drawing.Point(8, 135);
            this.panelGameArea.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(425, 389);
            this.panelGameArea.TabIndex = 3;
            // 
            // discardPile
            // 
            this.discardPile.FormattingEnabled = true;
            this.discardPile.Location = new System.Drawing.Point(124, 37);
            this.discardPile.Margin = new System.Windows.Forms.Padding(2);
            this.discardPile.Name = "discardPile";
            this.discardPile.Size = new System.Drawing.Size(103, 329);
            this.discardPile.TabIndex = 13;
            // 
            // computerHand
            // 
            this.computerHand.FormattingEnabled = true;
            this.computerHand.Location = new System.Drawing.Point(321, 37);
            this.computerHand.Margin = new System.Windows.Forms.Padding(2);
            this.computerHand.Name = "computerHand";
            this.computerHand.Size = new System.Drawing.Size(76, 329);
            this.computerHand.TabIndex = 12;
            // 
            // playerHand
            // 
            this.playerHand.FormattingEnabled = true;
            this.playerHand.Location = new System.Drawing.Point(237, 37);
            this.playerHand.Margin = new System.Windows.Forms.Padding(2);
            this.playerHand.Name = "playerHand";
            this.playerHand.Size = new System.Drawing.Size(76, 329);
            this.playerHand.TabIndex = 11;
            this.playerHand.SelectedIndexChanged += new System.EventHandler(this.playerHand_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discard Pile";
            // 
            // picBoxDiscardPile
            // 
            this.picBoxDiscardPile.Location = new System.Drawing.Point(63, 9);
            this.picBoxDiscardPile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxDiscardPile.Name = "picBoxDiscardPile";
            this.picBoxDiscardPile.Size = new System.Drawing.Size(57, 82);
            this.picBoxDiscardPile.TabIndex = 1;
            this.picBoxDiscardPile.TabStop = false;
            // 
            // picBoxDrawPile
            // 
            this.picBoxDrawPile.Location = new System.Drawing.Point(10, 9);
            this.picBoxDrawPile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picBoxDrawPile.Name = "picBoxDrawPile";
            this.picBoxDrawPile.Size = new System.Drawing.Size(49, 82);
            this.picBoxDrawPile.TabIndex = 0;
            this.picBoxDrawPile.TabStop = false;
            // 
            // flowLayoutPlayersHand
            // 
            this.flowLayoutPlayersHand.Location = new System.Drawing.Point(8, 610);
            this.flowLayoutPlayersHand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutPlayersHand.Name = "flowLayoutPlayersHand";
            this.flowLayoutPlayersHand.Size = new System.Drawing.Size(824, 34);
            this.flowLayoutPlayersHand.TabIndex = 4;
            // 
            // flowLayoutComputerHand
            // 
            this.flowLayoutComputerHand.Location = new System.Drawing.Point(8, 26);
            this.flowLayoutComputerHand.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flowLayoutComputerHand.Name = "flowLayoutComputerHand";
            this.flowLayoutComputerHand.Size = new System.Drawing.Size(824, 90);
            this.flowLayoutComputerHand.TabIndex = 5;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Location = new System.Drawing.Point(451, 206);
            this.btnDrawCard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(89, 19);
            this.btnDrawCard.TabIndex = 2;
            this.btnDrawCard.Text = "&Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.DrawCard);
            // 
            // btnUNO
            // 
            this.btnUNO.Location = new System.Drawing.Point(451, 230);
            this.btnUNO.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUNO.Name = "btnUNO";
            this.btnUNO.Size = new System.Drawing.Size(89, 19);
            this.btnUNO.TabIndex = 3;
            this.btnUNO.Text = "&UNO!";
            this.btnUNO.UseVisualStyleBackColor = true;
            // 
            // playCardButton
            // 
            this.playCardButton.Location = new System.Drawing.Point(451, 182);
            this.playCardButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.playCardButton.Name = "playCardButton";
            this.playCardButton.Size = new System.Drawing.Size(89, 19);
            this.playCardButton.TabIndex = 4;
            this.playCardButton.Text = "&Play Card";
            this.playCardButton.UseVisualStyleBackColor = true;
            this.playCardButton.Click += new System.EventHandler(this.PlayCard);
            // 
            // richTextScoreboard
            // 
            this.richTextScoreboard.Location = new System.Drawing.Point(836, 24);
            this.richTextScoreboard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextScoreboard.Name = "richTextScoreboard";
            this.richTextScoreboard.ReadOnly = true;
            this.richTextScoreboard.Size = new System.Drawing.Size(218, 502);
            this.richTextScoreboard.TabIndex = 7;
            this.richTextScoreboard.Text = "";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(8, 530);
            this.startGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(120, 33);
            this.startGameButton.TabIndex = 8;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGame);
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Location = new System.Drawing.Point(449, 135);
            this.currentTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(72, 13);
            this.currentTurnLabel.TabIndex = 9;
            this.currentTurnLabel.Text = "Current Turn: ";
            // 
            // currentTurn
            // 
            this.currentTurn.AutoSize = true;
            this.currentTurn.Location = new System.Drawing.Point(527, 135);
            this.currentTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTurn.Name = "currentTurn";
            this.currentTurn.Size = new System.Drawing.Size(33, 13);
            this.currentTurn.TabIndex = 10;
            this.currentTurn.Text = "None";
            // 
            // playMessageLabel
            // 
            this.playMessageLabel.AutoSize = true;
            this.playMessageLabel.Location = new System.Drawing.Point(449, 155);
            this.playMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playMessageLabel.Name = "playMessageLabel";
            this.playMessageLabel.Size = new System.Drawing.Size(76, 13);
            this.playMessageLabel.TabIndex = 11;
            this.playMessageLabel.Text = "Play Message:";
            // 
            // playMessage
            // 
            this.playMessage.AutoSize = true;
            this.playMessage.Location = new System.Drawing.Point(527, 157);
            this.playMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playMessage.Name = "playMessage";
            this.playMessage.Size = new System.Drawing.Size(33, 13);
            this.playMessage.TabIndex = 12;
            this.playMessage.Text = "None";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(659, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(139, 530);
            this.endGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(120, 33);
            this.endGameButton.TabIndex = 14;
            this.endGameButton.Text = "Exit";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 713);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playMessage);
            this.Controls.Add(this.playMessageLabel);
            this.Controls.Add(this.currentTurn);
            this.Controls.Add(this.currentTurnLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.richTextScoreboard);
            this.Controls.Add(this.btnUNO);
            this.Controls.Add(this.playCardButton);
            this.Controls.Add(this.flowLayoutComputerHand);
            this.Controls.Add(this.flowLayoutPlayersHand);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGameArea.ResumeLayout(false);
            this.panelGameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiscardPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrawPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUNOToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelGameArea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPlayersHand;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutComputerHand;
        private System.Windows.Forms.PictureBox picBoxDiscardPile;
        private System.Windows.Forms.PictureBox picBoxDrawPile;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Button btnUNO;
        private System.Windows.Forms.Button playCardButton;
        private System.Windows.Forms.RichTextBox richTextScoreboard;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentTurnLabel;
        private System.Windows.Forms.Label currentTurn;
        private System.Windows.Forms.ListBox playerHand;
        private System.Windows.Forms.ListBox computerHand;
        private System.Windows.Forms.ListBox discardPile;
        private System.Windows.Forms.Label playMessageLabel;
        private System.Windows.Forms.Label playMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button endGameButton;
    }
}

