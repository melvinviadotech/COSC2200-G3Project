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
            this.wildCardPopUpLabel = new System.Windows.Forms.Label();
            this.buttonWildYellow = new System.Windows.Forms.Button();
            this.buttonWildGreen = new System.Windows.Forms.Button();
            this.buttonWildBlue = new System.Windows.Forms.Button();
            this.buttonWildRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wildCardPopUpLabel
            // 
            this.wildCardPopUpLabel.AutoSize = true;
            this.wildCardPopUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wildCardPopUpLabel.Location = new System.Drawing.Point(148, 9);
            this.wildCardPopUpLabel.Name = "wildCardPopUpLabel";
            this.wildCardPopUpLabel.Size = new System.Drawing.Size(120, 20);
            this.wildCardPopUpLabel.TabIndex = 9;
            this.wildCardPopUpLabel.Text = "Choose A Color";
            // 
            // buttonWildYellow
            // 
            this.buttonWildYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonWildYellow.Location = new System.Drawing.Point(215, 239);
            this.buttonWildYellow.Name = "buttonWildYellow";
            this.buttonWildYellow.Size = new System.Drawing.Size(186, 180);
            this.buttonWildYellow.TabIndex = 8;
            this.buttonWildYellow.UseVisualStyleBackColor = false;
            this.buttonWildYellow.Click += new System.EventHandler(this.buttonWildYellow_Click);
            // 
            // buttonWildGreen
            // 
            this.buttonWildGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWildGreen.Location = new System.Drawing.Point(23, 239);
            this.buttonWildGreen.Name = "buttonWildGreen";
            this.buttonWildGreen.Size = new System.Drawing.Size(186, 180);
            this.buttonWildGreen.TabIndex = 7;
            this.buttonWildGreen.UseVisualStyleBackColor = false;
            this.buttonWildGreen.Click += new System.EventHandler(this.buttonWildGreen_Click);
            // 
            // buttonWildBlue
            // 
            this.buttonWildBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonWildBlue.Location = new System.Drawing.Point(215, 53);
            this.buttonWildBlue.Name = "buttonWildBlue";
            this.buttonWildBlue.Size = new System.Drawing.Size(186, 180);
            this.buttonWildBlue.TabIndex = 6;
            this.buttonWildBlue.UseVisualStyleBackColor = false;
            this.buttonWildBlue.Click += new System.EventHandler(this.buttonWildBlue_Click);
            // 
            // buttonWildRed
            // 
            this.buttonWildRed.BackColor = System.Drawing.Color.Red;
            this.buttonWildRed.Location = new System.Drawing.Point(23, 53);
            this.buttonWildRed.Name = "buttonWildRed";
            this.buttonWildRed.Size = new System.Drawing.Size(186, 180);
            this.buttonWildRed.TabIndex = 5;
            this.buttonWildRed.UseVisualStyleBackColor = false;
            this.buttonWildRed.Click += new System.EventHandler(this.buttonWildRed_Click);
            // 
            // WildCardPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
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

        private System.Windows.Forms.Label wildCardPopUpLabel;
        private System.Windows.Forms.Button buttonWildYellow;
        private System.Windows.Forms.Button buttonWildGreen;
        private System.Windows.Forms.Button buttonWildBlue;
        private System.Windows.Forms.Button buttonWildRed;
    }
}