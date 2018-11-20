using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGUI
{
    public partial class WordsInput : Form
    {
        private String player;
        public WordsInput(String player)
        {
            this.player = player;
            InitializeComponent();
            enterWordLbl.Text = player + " enter a word to guess:";
        }

        public string Player { get => player; set => player = value; }

        //Action event that brings in the guess form when enter is pressed.
        private void guesswordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoublePlayerWindowcs doublepl = new DoublePlayerWindowcs(guesswordTxt.Text.ToUpper());
                this.Visible = false;
                doublepl.Visible = true;
            }
        }

        //To Stop the Execution of the program when Close buttn is clicked
        private void WordsInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit? \n Your Current Game will be lost", "Closing...", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
