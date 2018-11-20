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
    public partial class DoublePlayerWindowcs : Form
    {
        private StringBuilder displayWord;
        private String word;
        private int chance;
        private int lettersFound;
        List<Char> wordsGuessed = new List<Char>();
        private int imageindex = 1;
        private static int player1Scores=0;
        private static int player2Scores=0;
        private static Boolean player = true;

        //Properties of the Attribute displayWord
        public StringBuilder DisplayWord { get => displayWord; set => displayWord = value; }
        //Properties of the Attribute Word to Guess
        public string Word { get => word; set => word = value; }
        //Properties of the Attribute Chances
        public int Chance { get => chance; set => chance = value; }
        public int LettersFound { get => lettersFound; set => lettersFound = value; }

        //To generate a random number that acts as an index for the array of words
        public int GetRandomNumberInRange(int minNumber, int maxNumber)
        {
            return Convert.ToInt32(new Random().NextDouble() * (minNumber - maxNumber) + minNumber);
        }
        //Returns a random String from the list of String
        public String fetchNewWord(String[] words)
        {

            return words[Math.Abs(GetRandomNumberInRange(0, words.Length - 1))];

        }

        public void doublePlayerGame(String word)

        { 
            //updates the lable value based on the player playing
            if (player)
            {
               
                playertoGuess.Text = "Player 2 to Guess";



            }
            else {

                playertoGuess.Text = "Player 1 to Guess";
            }
            
            DisplayWord = new StringBuilder(Word.Length);
            for (int i = 0; i < word.Length; i++)
                DisplayWord.Append("#");

        }
        //Contains the complete Game logic. The Score counters are incremented each time a player wins
        //The Game ends when one of the player reaches 5 first.
        public void runGame(String word, String input)
        {





            Boolean result = false;



            Char answer = input[0];
            if (wordsGuessed.Contains(answer))
            {
                //Already Guessed this word

                DisplayMessage("You have already used this Character!!!", "Already Used!"
                   , MessageBoxButtons.OK, MessageBoxIcon.Information);
                charGuess.Text = "";
            }
            else if (word.Contains(answer))
            {



                for (int i = 0; i < word.Length; i++)
                {

                    if (word[i] == (answer))
                    {
                        DisplayWord[i] = word[i];
                        wordsGuessed.Add(word[i]);
                        charGuess.Text = "";
                        wordToGuess.Text = DisplayWord.ToString();                        
                        LettersFound++;

                    }
                }
            }
            //Wrong Guess
            else
            {

                Chance -= 1;
                imageindex++;
                wordsGuessed.Add(answer);
                updateImage(imageindex.ToString());
                charGuess.Text = "";
                chanceCount.Text = Chance.ToString();

            }



            if (LettersFound == word.Length)
            {
                //Won the Game
                if (!player)
                {
                    player1Scores += 1;
                    player1Score.Text = player1Scores.ToString();
                    updateGif("Won");
                    DisplayMessage("Player 1 Have Scored a point", "Won!!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player = !player;
                }
                else {
                    player2Scores += 1;
                    player2Score.Text = player2Scores.ToString();
                    updateGif("Won");
                    DisplayMessage("Player 2 Have Scored a point", "Won!!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    player = !player;
                }

               
                result = true;
            }

           

            if (Chance == 0)
            {
                //Lost the Game                

                DisplayMessage("Sorry You used up all the Chances!. You Lost !!! \n The Word was :"+ word.ToUpper(), "Lost!!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (player)
                {
                    player1Scores += 1;
                    player1Score.Text = player1Scores.ToString();
                    
                    DisplayMessage("Player 1 Have Scored a point", "Won!!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    player2Scores += 1;
                    player2Score.Text = player2Scores.ToString();
                    
                    DisplayMessage("Player 2 Have Scored a point", "Won!!"
                           , MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                player = !player;
                result = true;
            }

            if (result&&(player1Scores!=5 && player2Scores!=5))
            {
                if (player)
                {
                    WordsInput wordstoGuess = new WordsInput("Player 1");
                    this.Visible = false;
                    wordstoGuess.Visible = true;
                }
                else {
                    WordsInput wordstoGuess = new WordsInput("Player 2");
                    this.Visible = false;
                    wordstoGuess.Visible = true;
                }
            }
            

                if (player1Scores == 5)
                {
                    DisplayMessage("Player 1 won the Game. Do you want to play another Game?", "Player 1 won!!"
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }
                else if (player2Scores == 5)
                {
                    DisplayMessage("Player 2 won the Game. Do you want to play another Game?", "Player 2 won!!"
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                }

            


           



        }
        //Method that is used to Display a Message box whenever required
        public void DisplayMessage(String message, String caption, MessageBoxButtons options, MessageBoxIcon icon)
        {
            var resultret = MessageBox.Show(message, caption,
                                                options,
                                                icon);

            // If the no button was pressed ...
            if (resultret == DialogResult.No)
            {
                // cancel the closure of the form.
                this.Close();

            }
            else if (resultret == DialogResult.Yes)
            {
                //Form Should Refresh
                player1Scores = 0;
                player2Scores = 0;
                player = true;
                WordsInput wordstoGuess = new WordsInput("Player 1");
                this.Visible = false;
                wordstoGuess.Visible = true;
                resetForm(Word);

            }
            else { }
        }



        public DoublePlayerWindowcs()
        {

            InitializeComponent();

        }

        public DoublePlayerWindowcs(String word)
        {
            this.Word = word;
            InitializeComponent();

        }


        //Reset the form with new Values
        public void resetForm(String word)
        {
            Chance = 6;
            LettersFound = 0;
            wordsGuessed = new List<Char>();
            player1Score.Text = player1Scores.ToString();
            player2Score.Text = player2Scores.ToString();
            imageindex = 1;
            doublePlayerGame(Word);
            updateImage("1");
            chanceCount.Text = Chance.ToString();
            wordToGuess.Text = DisplayWord.ToString();

        }

        //Used to update the image in the picture box
        public void updateImage(String fileName)
        {

            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + fileName + ".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        //Used to update the gifs in the picture box
        public void updateGif(String fileName)
        {

            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + fileName + ".gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        //The fuctions is triggered when the form is loaded
        private void DoublePlayerWindowcs_Load(object sender, EventArgs e)
        {
            resetForm(Word);
        }

        //Event Handler called when Enter is pressed after typing the Guess Character
        private void charGuess_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.runGame(Word, charGuess.Text.ToUpper());

            }

        }

        //To Stop the Execution of the program when Close buttn is clicked
        private void DoublePlayerWindowcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit? \n Your Current Game will be lost", "Closing..", MessageBoxButtons.YesNo);
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
