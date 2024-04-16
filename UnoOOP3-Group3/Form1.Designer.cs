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
            this.playerHand = new System.Windows.Forms.ListBox();
            this.computerHand = new System.Windows.Forms.ListBox();
            this.discardPile = new System.Windows.Forms.ListBox();
            this.playMessageLabel = new System.Windows.Forms.Label();
            this.playMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelGameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiscardPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrawPile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1591, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.technicalSupportToolStripMenuItem,
            this.aboutUNOToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.technicalSupportToolStripMenuItem.Text = "Technical Support";
            this.technicalSupportToolStripMenuItem.Click += new System.EventHandler(this.technicalSupportToolStripMenuItem_Click);
            // 
            // aboutUNOToolStripMenuItem
            // 
            this.aboutUNOToolStripMenuItem.Name = "aboutUNOToolStripMenuItem";
            this.aboutUNOToolStripMenuItem.Size = new System.Drawing.Size(253, 34);
            this.aboutUNOToolStripMenuItem.Text = "About UNO!";
            this.aboutUNOToolStripMenuItem.Click += new System.EventHandler(this.aboutUNOToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1874, 1169);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 45);
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
            this.panelGameArea.Location = new System.Drawing.Point(12, 208);
            this.panelGameArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(637, 599);
            this.panelGameArea.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Discard Pile";
            // 
            // picBoxDiscardPile
            // 
            this.picBoxDiscardPile.Location = new System.Drawing.Point(95, 14);
            this.picBoxDiscardPile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxDiscardPile.Name = "picBoxDiscardPile";
            this.picBoxDiscardPile.Size = new System.Drawing.Size(85, 126);
            this.picBoxDiscardPile.TabIndex = 1;
            this.picBoxDiscardPile.TabStop = false;
            // 
            // picBoxDrawPile
            // 
            this.picBoxDrawPile.Location = new System.Drawing.Point(15, 14);
            this.picBoxDrawPile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxDrawPile.Name = "picBoxDrawPile";
            this.picBoxDrawPile.Size = new System.Drawing.Size(74, 126);
            this.picBoxDrawPile.TabIndex = 0;
            this.picBoxDrawPile.TabStop = false;
            // 
            // flowLayoutPlayersHand
            // 
            this.flowLayoutPlayersHand.Location = new System.Drawing.Point(12, 939);
            this.flowLayoutPlayersHand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPlayersHand.Name = "flowLayoutPlayersHand";
            this.flowLayoutPlayersHand.Size = new System.Drawing.Size(1236, 52);
            this.flowLayoutPlayersHand.TabIndex = 4;
            // 
            // flowLayoutComputerHand
            // 
            this.flowLayoutComputerHand.Location = new System.Drawing.Point(12, 40);
            this.flowLayoutComputerHand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutComputerHand.Name = "flowLayoutComputerHand";
            this.flowLayoutComputerHand.Size = new System.Drawing.Size(1236, 139);
            this.flowLayoutComputerHand.TabIndex = 5;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Location = new System.Drawing.Point(677, 317);
            this.btnDrawCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(133, 29);
            this.btnDrawCard.TabIndex = 2;
            this.btnDrawCard.Text = "&Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.DrawCard);
            // 
            // btnUNO
            // 
            this.btnUNO.Location = new System.Drawing.Point(677, 354);
            this.btnUNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUNO.Name = "btnUNO";
            this.btnUNO.Size = new System.Drawing.Size(133, 29);
            this.btnUNO.TabIndex = 3;
            this.btnUNO.Text = "&UNO!";
            this.btnUNO.UseVisualStyleBackColor = true;
            // 
            // playCardButton
            // 
            this.playCardButton.Location = new System.Drawing.Point(677, 280);
            this.playCardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playCardButton.Name = "playCardButton";
            this.playCardButton.Size = new System.Drawing.Size(133, 29);
            this.playCardButton.TabIndex = 4;
            this.playCardButton.Text = "&Play Card";
            this.playCardButton.UseVisualStyleBackColor = true;
            this.playCardButton.Click += new System.EventHandler(this.PlayCard);
            // 
            // richTextScoreboard
            // 
            this.richTextScoreboard.Location = new System.Drawing.Point(1254, 37);
            this.richTextScoreboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextScoreboard.Name = "richTextScoreboard";
            this.richTextScoreboard.ReadOnly = true;
            this.richTextScoreboard.Size = new System.Drawing.Size(325, 770);
            this.richTextScoreboard.TabIndex = 7;
            this.richTextScoreboard.Text = "";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(12, 815);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(180, 51);
            this.startGameButton.TabIndex = 8;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartGame);
            // 
            // currentTurnLabel
            // 
            this.currentTurnLabel.AutoSize = true;
            this.currentTurnLabel.Location = new System.Drawing.Point(673, 208);
            this.currentTurnLabel.Name = "currentTurnLabel";
            this.currentTurnLabel.Size = new System.Drawing.Size(106, 20);
            this.currentTurnLabel.TabIndex = 9;
            this.currentTurnLabel.Text = "Current Turn: ";
            // 
            // currentTurn
            // 
            this.currentTurn.AutoSize = true;
            this.currentTurn.Location = new System.Drawing.Point(790, 208);
            this.currentTurn.Name = "currentTurn";
            this.currentTurn.Size = new System.Drawing.Size(47, 20);
            this.currentTurn.TabIndex = 10;
            this.currentTurn.Text = "None";
            // 
            // playerHand
            // 
            this.playerHand.FormattingEnabled = true;
            this.playerHand.ItemHeight = 20;
            this.playerHand.Location = new System.Drawing.Point(355, 57);
            this.playerHand.Name = "playerHand";
            this.playerHand.Size = new System.Drawing.Size(112, 504);
            this.playerHand.TabIndex = 11;
            // 
            // computerHand
            // 
            this.computerHand.FormattingEnabled = true;
            this.computerHand.ItemHeight = 20;
            this.computerHand.Location = new System.Drawing.Point(481, 57);
            this.computerHand.Name = "computerHand";
            this.computerHand.Size = new System.Drawing.Size(112, 504);
            this.computerHand.TabIndex = 12;
            // 
            // discardPile
            // 
            this.discardPile.FormattingEnabled = true;
            this.discardPile.ItemHeight = 20;
            this.discardPile.Location = new System.Drawing.Point(186, 57);
            this.discardPile.Name = "discardPile";
            this.discardPile.Size = new System.Drawing.Size(153, 504);
            this.discardPile.TabIndex = 13;
            // 
            // playMessageLabel
            // 
            this.playMessageLabel.AutoSize = true;
            this.playMessageLabel.Location = new System.Drawing.Point(673, 239);
            this.playMessageLabel.Name = "playMessageLabel";
            this.playMessageLabel.Size = new System.Drawing.Size(111, 20);
            this.playMessageLabel.TabIndex = 11;
            this.playMessageLabel.Text = "Play Message:";
            // 
            // playMessage
            // 
            this.playMessage.AutoSize = true;
            this.playMessage.Location = new System.Drawing.Point(790, 242);
            this.playMessage.Name = "playMessage";
            this.playMessage.Size = new System.Drawing.Size(47, 20);
            this.playMessage.TabIndex = 12;
            this.playMessage.Text = "None";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 1009);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGameArea.ResumeLayout(false);
            this.panelGameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiscardPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrawPile)).EndInit();
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
    }
}

