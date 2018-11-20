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

    public partial class SinglePlayerWindow : Form
    {
        private StringBuilder displayWord;
        private String word;
        private int chance;
        private int lettersFound;
        List<Char> wordsGuessed  = new List<Char>();
        private int imageindex=1;

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

        //Contructor that initializes the word and the creates a hidden string to display to the user.
        public void singlePlayerGame(String[] words)
        {

            Word = fetchNewWord(words).ToUpper();
            DisplayWord = new StringBuilder(Word.Length);
            for (int i = 0; i < word.Length; i++)
                DisplayWord.Append("#");

        }

        //Contains the game logic and is called each time a character is guessed
        public Boolean runGame(String word, String input)
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
                    
                    Chance-=1;
                imageindex++;
                wordsGuessed.Add(answer);
                updateImage(imageindex.ToString());
                charGuess.Text = "";
                chanceCount.Text = Chance.ToString();

                }

              

                if (LettersFound == word.Length)
                {
                //Won the Game
                updateGif("Won");
                DisplayMessage("Hurray!! Congrats!! You won !! You want to play Another Game?", "Won!!"
                       , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    result = true;
                }

                if (Chance == 0)
                {
                //Lost the Game                
                    
                DisplayMessage("Sorry You used up all the Chances!. You Lost !!! \n  The Word was : " + word.ToUpper(), "Lost!!"
                            , MessageBoxButtons.YesNo, MessageBoxIcon.Error);                  
                
                }
            
            return result;
        }

        public void DisplayMessage(String message,String caption,MessageBoxButtons options,MessageBoxIcon icon) {
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
                resetForm();
            }
            else { }
        }


        
        public SinglePlayerWindow()
        {
            
            InitializeComponent();
           
        }
        //The funtion is called when the form is loaded and it initialises all the form values using the resetForm() method.
        private void SinglePlayerWindow_Load(object sender, EventArgs e)
        {
            resetForm();
        }

        //Resets all the form values.
        public void resetForm() {
            Chance = 6;
            LettersFound = 0;
            wordsGuessed = new List<Char>();
            String[] words = new String[] { "Seine", "Rouen", "Paris", "Cathedral", "Panaroma", "JeanD'arc","Adam"
                ,"ESIGELEC","INSA","University","Technopole","Mount-Saint-Aignan","Hotel De Ville" };
            imageindex = 1;
            singlePlayerGame(words);
            updateImage("1");
            chanceCount.Text = Chance.ToString();
            wordToGuess.Text = DisplayWord.ToString();

        }

        private void charGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                this.runGame(Word, charGuess.Text.ToUpper());
                
            }

        }

        //Updates the image incase if a wrong Character is guessed
        public void updateImage(String fileName) {

            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\"+fileName+".png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        //Used for updating the gif in picture box when the game is won .
        public void updateGif(String fileName)
        {

            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + fileName + ".gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        //To Stop the Execution of the program when Close buttn is clicked
        private void SinglePlayerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit? \n Your Current Game will be lost.", "Closing", MessageBoxButtons.YesNo);
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
