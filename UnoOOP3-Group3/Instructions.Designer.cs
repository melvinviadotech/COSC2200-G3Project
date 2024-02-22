namespace UnoOOP3_Group3
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.InstructionsRichText = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionsRichText
            // 
            this.InstructionsRichText.Location = new System.Drawing.Point(72, 28);
            this.InstructionsRichText.Name = "InstructionsRichText";
            this.InstructionsRichText.ReadOnly = true;
            this.InstructionsRichText.Size = new System.Drawing.Size(635, 370);
            this.InstructionsRichText.TabIndex = 0;
            this.InstructionsRichText.Text = resources.GetString("InstructionsRichText.Text");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.InstructionsRichText);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InstructionsRichText;
        private System.Windows.Forms.Button btnExit;
    }
}