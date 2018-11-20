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
    public partial class Form1 : Form
    {
        //Initializes all the components and adds a default gif in the picture box
        public Form1()
        {
            InitializeComponent();
            // pictureBox1.Image = Image.FromFile("intro.gif");

            pictureBox1.Image = Image.FromFile(Application.StartupPath+"\\images\\intro.gif");
        }
        //The Button Even to opens the screen for Single player game
        private void singlePlayerBtn_Click(object sender, EventArgs e)
        {
            SinglePlayerWindow singlepl = new SinglePlayerWindow();
            this.Visible = false;
            singlepl.Visible = true;
        }

        //The Button Even to opens the screen for double player game
        private void doublePlayersBtn_Click(object sender, EventArgs e)
        {
            WordsInput wordsinput = new WordsInput("Player 1");
            this.Visible = false;
            wordsinput.Visible = true;
        }

        //To Stop the Execution of the program when Close buttn is clicked
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
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
