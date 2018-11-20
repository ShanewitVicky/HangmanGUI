namespace HangmanGUI
{
    partial class SinglePlayerWindow
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
            this.process1 = new System.Diagnostics.Process();
            this.guessWordLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.charGuess = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chanceLbl = new System.Windows.Forms.Label();
            this.chanceCount = new System.Windows.Forms.Label();
            this.wordToGuess = new System.Windows.Forms.Label();
            this.wordtoGuessLbl = new System.Windows.Forms.Label();
            this.questionlbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // guessWordLable
            // 
            this.guessWordLable.AutoSize = true;
            this.guessWordLable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessWordLable.Location = new System.Drawing.Point(14, 8);
            this.guessWordLable.Name = "guessWordLable";
            this.guessWordLable.Size = new System.Drawing.Size(152, 23);
            this.guessWordLable.TabIndex = 0;
            this.guessWordLable.Text = "Guess a Character";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.charGuess);
            this.panel1.Controls.Add(this.guessWordLable);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 40);
            this.panel1.TabIndex = 1;
            // 
            // charGuess
            // 
            this.charGuess.Location = new System.Drawing.Point(175, 11);
            this.charGuess.Name = "charGuess";
            this.charGuess.Size = new System.Drawing.Size(62, 20);
            this.charGuess.TabIndex = 1;
            this.charGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.charGuess_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 149);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chanceLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chanceCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.wordToGuess, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.wordtoGuessLbl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 230);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 55);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // chanceLbl
            // 
            this.chanceLbl.AutoSize = true;
            this.chanceLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLbl.Location = new System.Drawing.Point(3, 0);
            this.chanceLbl.Name = "chanceLbl";
            this.chanceLbl.Size = new System.Drawing.Size(93, 19);
            this.chanceLbl.TabIndex = 0;
            this.chanceLbl.Text = "Chances Left";
            // 
            // chanceCount
            // 
            this.chanceCount.AutoSize = true;
            this.chanceCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceCount.Location = new System.Drawing.Point(154, 0);
            this.chanceCount.Name = "chanceCount";
            this.chanceCount.Size = new System.Drawing.Size(17, 19);
            this.chanceCount.TabIndex = 0;
            this.chanceCount.Text = "0";
            // 
            // wordToGuess
            // 
            this.wordToGuess.AutoSize = true;
            this.wordToGuess.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordToGuess.Location = new System.Drawing.Point(154, 27);
            this.wordToGuess.Name = "wordToGuess";
            this.wordToGuess.Size = new System.Drawing.Size(15, 18);
            this.wordToGuess.TabIndex = 0;
            this.wordToGuess.Text = "0";
            // 
            // wordtoGuessLbl
            // 
            this.wordtoGuessLbl.AutoSize = true;
            this.wordtoGuessLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordtoGuessLbl.Location = new System.Drawing.Point(3, 27);
            this.wordtoGuessLbl.Name = "wordtoGuessLbl";
            this.wordtoGuessLbl.Size = new System.Drawing.Size(109, 19);
            this.wordtoGuessLbl.TabIndex = 0;
            this.wordtoGuessLbl.Text = "Word to Guess";
            // 
            // questionlbl
            // 
            this.questionlbl.AutoSize = true;
            this.questionlbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionlbl.Location = new System.Drawing.Point(7, 2);
            this.questionlbl.Name = "questionlbl";
            this.questionlbl.Size = new System.Drawing.Size(308, 26);
            this.questionlbl.TabIndex = 0;
            this.questionlbl.Text = "Guess the word related to Rouen?";
            // 
            // SinglePlayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 286);
            this.Controls.Add(this.questionlbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SinglePlayerWindow";
            this.Text = "SinglePlayerWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinglePlayerWindow_FormClosing);
            this.Load += new System.EventHandler(this.SinglePlayerWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guessWordLable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox charGuess;
        private System.Windows.Forms.Label chanceLbl;
        private System.Windows.Forms.Label chanceCount;
        private System.Windows.Forms.Label wordToGuess;
        private System.Windows.Forms.Label wordtoGuessLbl;
        private System.Windows.Forms.Label questionlbl;
    }
}