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
            this.picBoxDiscardPile = new System.Windows.Forms.PictureBox();
            this.picBoxDrawPile = new System.Windows.Forms.PictureBox();
            this.flowLayoutPlayersHand = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutComputerHand = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.btnUNO = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTurnStatus = new System.Windows.Forms.Label();
            this.richTextScoreboard = new System.Windows.Forms.RichTextBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
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
            this.btnExit.Location = new System.Drawing.Point(1250, 760);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelGameArea
            // 
            this.panelGameArea.Controls.Add(this.picBoxDiscardPile);
            this.panelGameArea.Controls.Add(this.picBoxDrawPile);
            this.panelGameArea.Location = new System.Drawing.Point(268, 145);
            this.panelGameArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGameArea.Name = "panelGameArea";
            this.panelGameArea.Size = new System.Drawing.Size(824, 501);
            this.panelGameArea.TabIndex = 3;
            // 
            // picBoxDiscardPile
            // 
            this.picBoxDiscardPile.Location = new System.Drawing.Point(212, 409);
            this.picBoxDiscardPile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxDiscardPile.Name = "picBoxDiscardPile";
            this.picBoxDiscardPile.Size = new System.Drawing.Size(193, 82);
            this.picBoxDiscardPile.TabIndex = 1;
            this.picBoxDiscardPile.TabStop = false;
            // 
            // picBoxDrawPile
            // 
            this.picBoxDrawPile.Location = new System.Drawing.Point(10, 409);
            this.picBoxDrawPile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxDrawPile.Name = "picBoxDrawPile";
            this.picBoxDrawPile.Size = new System.Drawing.Size(184, 82);
            this.picBoxDrawPile.TabIndex = 0;
            this.picBoxDrawPile.TabStop = false;
            // 
            // flowLayoutPlayersHand
            // 
            this.flowLayoutPlayersHand.Location = new System.Drawing.Point(268, 675);
            this.flowLayoutPlayersHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPlayersHand.Name = "flowLayoutPlayersHand";
            this.flowLayoutPlayersHand.Size = new System.Drawing.Size(824, 90);
            this.flowLayoutPlayersHand.TabIndex = 4;
            // 
            // flowLayoutComputerHand
            // 
            this.flowLayoutComputerHand.Location = new System.Drawing.Point(268, 35);
            this.flowLayoutComputerHand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutComputerHand.Name = "flowLayoutComputerHand";
            this.flowLayoutComputerHand.Size = new System.Drawing.Size(824, 90);
            this.flowLayoutComputerHand.TabIndex = 5;
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Location = new System.Drawing.Point(794, 651);
            this.btnDrawCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(88, 19);
            this.btnDrawCard.TabIndex = 2;
            this.btnDrawCard.Text = "&Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            // 
            // btnUNO
            // 
            this.btnUNO.Location = new System.Drawing.Point(980, 651);
            this.btnUNO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUNO.Name = "btnUNO";
            this.btnUNO.Size = new System.Drawing.Size(88, 19);
            this.btnUNO.TabIndex = 3;
            this.btnUNO.Text = "&UNO!";
            this.btnUNO.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(887, 651);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(88, 19);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "&Play Card";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblTurnStatus
            // 
            this.lblTurnStatus.AutoSize = true;
            this.lblTurnStatus.Location = new System.Drawing.Point(9, 84);
            this.lblTurnStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTurnStatus.Name = "lblTurnStatus";
            this.lblTurnStatus.Size = new System.Drawing.Size(35, 13);
            this.lblTurnStatus.TabIndex = 6;
            this.lblTurnStatus.Text = "label1";
            // 
            // richTextScoreboard
            // 
            this.richTextScoreboard.Location = new System.Drawing.Point(1119, 145);
            this.richTextScoreboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextScoreboard.Name = "richTextScoreboard";
            this.richTextScoreboard.ReadOnly = true;
            this.richTextScoreboard.Size = new System.Drawing.Size(218, 502);
            this.richTextScoreboard.TabIndex = 7;
            this.richTextScoreboard.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 799);
            this.Controls.Add(this.richTextScoreboard);
            this.Controls.Add(this.lblTurnStatus);
            this.Controls.Add(this.btnUNO);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.flowLayoutComputerHand);
            this.Controls.Add(this.flowLayoutPlayersHand);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.panelGameArea);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNO!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGameArea.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTurnStatus;
        private System.Windows.Forms.RichTextBox richTextScoreboard;
    }
}

