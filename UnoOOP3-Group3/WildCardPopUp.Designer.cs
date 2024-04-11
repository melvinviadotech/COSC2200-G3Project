namespace UnoOOP3_Group3
{
    partial class WildCardPopUp
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
            this.buttonWildRed = new System.Windows.Forms.Button();
            this.buttonWildBlue = new System.Windows.Forms.Button();
            this.buttonWildGreen = new System.Windows.Forms.Button();
            this.buttonWildYellow = new System.Windows.Forms.Button();
            this.wildCardPopUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonWildRed
            // 
            this.buttonWildRed.BackColor = System.Drawing.Color.Red;
            this.buttonWildRed.Location = new System.Drawing.Point(13, 53);
            this.buttonWildRed.Name = "buttonWildRed";
            this.buttonWildRed.Size = new System.Drawing.Size(186, 180);
            this.buttonWildRed.TabIndex = 0;
            this.buttonWildRed.UseVisualStyleBackColor = false;
            this.buttonWildRed.Click += new System.EventHandler(this.buttonWildRed_Click);
            // 
            // buttonWildBlue
            // 
            this.buttonWildBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonWildBlue.Location = new System.Drawing.Point(205, 53);
            this.buttonWildBlue.Name = "buttonWildBlue";
            this.buttonWildBlue.Size = new System.Drawing.Size(186, 180);
            this.buttonWildBlue.TabIndex = 1;
            this.buttonWildBlue.UseVisualStyleBackColor = false;
            this.buttonWildBlue.Click += new System.EventHandler(this.buttonWildBlue_Click);
            // 
            // buttonWildGreen
            // 
            this.buttonWildGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWildGreen.Location = new System.Drawing.Point(13, 239);
            this.buttonWildGreen.Name = "buttonWildGreen";
            this.buttonWildGreen.Size = new System.Drawing.Size(186, 180);
            this.buttonWildGreen.TabIndex = 2;
            this.buttonWildGreen.UseVisualStyleBackColor = false;
            this.buttonWildGreen.Click += new System.EventHandler(this.buttonWildGreen_Click);
            // 
            // buttonWildYellow
            // 
            this.buttonWildYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonWildYellow.Location = new System.Drawing.Point(205, 239);
            this.buttonWildYellow.Name = "buttonWildYellow";
            this.buttonWildYellow.Size = new System.Drawing.Size(186, 180);
            this.buttonWildYellow.TabIndex = 3;
            this.buttonWildYellow.UseVisualStyleBackColor = false;
            this.buttonWildYellow.Click += new System.EventHandler(this.buttonWildYellow_Click);
            // 
            // wildCardPopUpLabel
            // 
            this.wildCardPopUpLabel.AutoSize = true;
            this.wildCardPopUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wildCardPopUpLabel.Location = new System.Drawing.Point(108, 9);
            this.wildCardPopUpLabel.Name = "wildCardPopUpLabel";
            this.wildCardPopUpLabel.Size = new System.Drawing.Size(183, 29);
            this.wildCardPopUpLabel.TabIndex = 4;
            this.wildCardPopUpLabel.Text = "Choose A Color";
            // 
            // WildCardPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 428);
            this.ControlBox = false;
            this.Controls.Add(this.wildCardPopUpLabel);
            this.Controls.Add(this.buttonWildYellow);
            this.Controls.Add(this.buttonWildGreen);
            this.Controls.Add(this.buttonWildBlue);
            this.Controls.Add(this.buttonWildRed);
            this.Name = "WildCardPopUp";
            this.Text = "WildCardPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWildRed;
        private System.Windows.Forms.Button buttonWildBlue;
        private System.Windows.Forms.Button buttonWildGreen;
        private System.Windows.Forms.Button buttonWildYellow;
        private System.Windows.Forms.Label wildCardPopUpLabel;
    }
}