namespace UnoOOP3_Group3
{
    partial class AboutUno
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(105, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(576, 317);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "This game of UNO! was created by Group 3 of COSC 2200.\nThe group members are: \n-C" +
    "urtis Hemminghaus\n-Mateo Valles \n-Melvin Viado \n-Sadaqat Chaudhry\n-Zaid Ali";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AboutUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AboutUno";
            this.Text = "AboutUno";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExit;
    }
}