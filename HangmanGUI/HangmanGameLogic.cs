using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGUI
{
    class HangmanGameLogic
    {
       private StringBuilder displayWord;
       private String word;
        private int chance=5;
        
        //Properties of the Attribute displayWord
        public StringBuilder DisplayWord { get => displayWord; set => displayWord = value; }
        //Properties of the Attribute Word to Guess
        public string Word { get => word; set => word = value; }
        //Properties of the Attribute Chances
        public int Chance { get => chance; set => chance = value; }

        public int GetRandomNumberInRange(int minNumber, int maxNumber)
            {
                return Convert.ToInt32(new Random().NextDouble() * (minNumber - maxNumber) + minNumber);
            }

            public String fetchNewWord(String[] words)
            {

                return words[Math.Abs(GetRandomNumberInRange(0, words.Length - 1))];

            }

            public void singlePlayerGame(String[] words)
            {
            
            Word = fetchNewWord(words).ToUpper();
            DisplayWord = new StringBuilder(Word.Length);
            for (int i = 0; i < word.Length; i++)
                DisplayWord.Append("_ ");
               
            }

           /* public void twoPlayerGame()
            {
                Boolean player = true;
                int player1Score = 0, player2Score = 0;
                Console.WriteLine("This is a two Player Game");
                Console.WriteLine("Enter Player 1 Name:");
                String player1 = Console.ReadLine();
                Console.WriteLine("Enter Player 2 Name:");
                String player2 = Console.ReadLine();
                Console.WriteLine("Player Who reaches 2 points first wins the game");
                String word;
                while (player1Score != 2 && player2Score != 2)
                {
                    if (player)
                    {
                        displayScore(player1, player2, player1Score, player2Score);
                        Console.WriteLine(player1 + " turn to ask");
                        Console.WriteLine("Enter the Word to Ask:");
                        word = Console.ReadLine().ToUpper();
                        Console.Clear();
                        displayScore(player1, player2, player1Score, player2Score);
                        Console.WriteLine(player2 + " Guess the Word");
                        if (runGame(word))
                        {
                            player2Score++;
                        }
                        else
                        {
                            player1Score++;
                        }
                        player = !player;
                    }
                    else
                    {
                        displayScore(player1, player2, player1Score, player2Score);
                        Console.WriteLine(player2 + " turn to ask");
                        Console.WriteLine("Enter the Word to Ask:");
                        word = Console.ReadLine().ToUpper();
                        Console.Clear();
                        displayScore(player1, player2, player1Score, player2Score);
                        Console.WriteLine(player2 + " Guess the Word");
                        if (runGame(word))
                        {
                            player1Score++;
                        }
                        else
                        {
                            player2Score++;
                        }

                        player = !player;

                    }
                }

                if (player1Score > player2Score)
                {
                    Console.Clear();
                    displayScore(player1, player2, player1Score, player2Score);
                    Console.WriteLine("#################################################################");
                    Console.WriteLine("#############Congrats " + player1 + " !! You won the Game############");
                    Console.WriteLine("#################################################################");
                }
                else
                {
                    Console.Clear();
                    displayScore(player1, player2, player1Score, player2Score);
                    Console.WriteLine("#################################################################");
                    Console.WriteLine("#############Congrats " + player2 + " !! You won the Game########");
                    Console.WriteLine("#################################################################");
                }


            }*/

            public Boolean runGame(String word,String input)
            {

               
                List<Char> wordsGuessed = new List<Char>();           

                
                Boolean result = false;
                int lettersFound = 0;
                while (!result && Chance > 0)
                {
                    Console.WriteLine(DisplayWord);

                    Char answer = input[0];
                    if (wordsGuessed.Contains(answer))
                    {
                        Console.WriteLine("You have already guessed it!!!");
                        continue;
                    }
                    if (word.Contains(answer))
                    {
                        for (int i = 0; i < word.Length; i++)
                        {

                            if (word[i] == (answer))
                            {
                                DisplayWord[i] = word[i];
                                wordsGuessed.Add(word[i]);
                                lettersFound++;
                            }
                        }
                    }
                    else
                    {
                         Chance--;
                        wordsGuessed.Add(answer);
                        Console.WriteLine("Sorry the word does not contain this letter");
                    }

                    Console.WriteLine("Chances Left:" + Chance);

                    if (lettersFound == word.Length)
                    {
                        result = true;
                        Console.WriteLine("###########################");
                        Console.WriteLine("You have scored a point!!!!");
                        Console.WriteLine("###########################");
                        Console.WriteLine("Press Anything to Continue......");
                        Console.ReadLine();
                        Console.Clear();


                    }

                    if (Chance == 0)
                    {
                        Console.WriteLine("#################################################################");
                        Console.WriteLine("####Sorry you lost the Game!! You have used up your chances!!####");
                        Console.WriteLine("#################################################################");
                        Console.WriteLine("Press Anything to Continue.....");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                return result;
            }

            public void displayScore(String player1, String player2, int pl1Score, int pl2Score)
            {

                Console.WriteLine(player1 + ":" + pl1Score + " | " + player2 + ": " + pl2Score);

            }


            //Constructor of Hangman Single Player
            public HangmanGameLogic()
            {
            String[] words = new String[] { "Seine", "Rouen", "Paris", "Cathedral", "Panaroma", "JeanD'arc" };

            singlePlayerGame(words);
            }

           



    }
}
