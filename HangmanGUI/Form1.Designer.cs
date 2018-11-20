namespace HangmanGUI
{
    partial class Form1
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
            this.singlePlayerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doublePlayersBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // singlePlayerBtn
            // 
            this.singlePlayerBtn.Location = new System.Drawing.Point(56, 259);
            this.singlePlayerBtn.Name = "singlePlayerBtn";
            this.singlePlayerBtn.Size = new System.Drawing.Size(101, 41);
            this.singlePlayerBtn.TabIndex = 0;
            this.singlePlayerBtn.Text = "Single Player";
            this.singlePlayerBtn.UseVisualStyleBackColor = true;
            this.singlePlayerBtn.Click += new System.EventHandler(this.singlePlayerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 207);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // doublePlayersBtn
            // 
            this.doublePlayersBtn.Location = new System.Drawing.Point(222, 259);
            this.doublePlayersBtn.Name = "doublePlayersBtn";
            this.doublePlayersBtn.Size = new System.Drawing.Size(101, 41);
            this.doublePlayersBtn.TabIndex = 0;
            this.doublePlayersBtn.Text = "Two Players";
            this.doublePlayersBtn.UseVisualStyleBackColor = true;
            this.doublePlayersBtn.Click += new System.EventHandler(this.doublePlayersBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangman Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.doublePlayersBtn);
            this.Controls.Add(this.singlePlayerBtn);
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button singlePlayerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button doublePlayersBtn;
        private System.Windows.Forms.Label label1;
    }
}

