namespace UnoOOP3_Group3
{
    partial class TechSupport
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
            this.techSupportRichText = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // techSupportRichText
            // 
            this.techSupportRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techSupportRichText.Location = new System.Drawing.Point(91, 60);
            this.techSupportRichText.Name = "techSupportRichText";
            this.techSupportRichText.ReadOnly = true;
            this.techSupportRichText.Size = new System.Drawing.Size(604, 326);
            this.techSupportRichText.TabIndex = 0;
            this.techSupportRichText.Text = "If you encounter technical issues whilst playing UNO!\nPlease contact us at group3" +
    "uno!@noemail.ca\n";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(290, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TechSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.techSupportRichText);
            this.Name = "TechSupport";
            this.Text = "TechSupport";
            this.Load += new System.EventHandler(this.TechSupport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox techSupportRichText;
        private System.Windows.Forms.Button btnExit;
    }
}