namespace HangmanGUI
{
    partial class WordsInput
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
            this.enterWordLbl = new System.Windows.Forms.Label();
            this.guesswordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterWordLbl
            // 
            this.enterWordLbl.AutoSize = true;
            this.enterWordLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterWordLbl.Location = new System.Drawing.Point(3, 14);
            this.enterWordLbl.Name = "enterWordLbl";
            this.enterWordLbl.Size = new System.Drawing.Size(254, 23);
            this.enterWordLbl.TabIndex = 0;
            this.enterWordLbl.Text = "Player 1 Enter a word to guess:";
            // 
            // guesswordTxt
            // 
            this.guesswordTxt.Location = new System.Drawing.Point(263, 18);
            this.guesswordTxt.Name = "guesswordTxt";
            this.guesswordTxt.Size = new System.Drawing.Size(133, 20);
            this.guesswordTxt.TabIndex = 1;
            this.guesswordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guesswordTxt_KeyDown);
            // 
            // WordsInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 49);
            this.Controls.Add(this.guesswordTxt);
            this.Controls.Add(this.enterWordLbl);
            this.Name = "WordsInput";
            this.Text = "WordsInput";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordsInput_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterWordLbl;
        private System.Windows.Forms.TextBox guesswordTxt;
    }
}