using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp235
{
    internal class Program
    {
        static string GenerateRandomWord(int length)
        {
            Random random = new Random();
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string word = "";
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(letters.Length);
                word += letters[index];
            }
            return word;
        }
        static void Main(string[] args)
        {
            string secretWord = GenerateRandomWord(5);
            Console.WriteLine(secretWord);
            int attempts = 6;
            char[] correct = { '_', '_', '_', '_', '_' };
            Console.WriteLine("Guess the 5-letter word!");
            for (int i = 0; i < attempts; i++)
            {
                Console.WriteLine("Word:" + new string(correct));
                Console.Write($"Attempt {i + 1}: ");
                string guess = Console.ReadLine().ToLower();
                if (guess.Length != 5)
                {
                  Console.WriteLine("");
                  i--;
                  continue;
                }
                bool allCorrect = true;
                for (int j = 0; j < 5; j++)
                {        
                    if (guess[j] == secretWord[j])
                    {
                        correct[j] = guess[j];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(guess[j]);
                    }
                    else if (secretWord.Contains(guess[j]))
                    {
                       allCorrect = false;
                       Console.ForegroundColor = ConsoleColor.Yellow;
                       Console.Write(guess[j]);
                    }
                    else
                    {
                       allCorrect = false;
                       Console.ForegroundColor = ConsoleColor.Gray;
                       Console.Write(guess[j]);
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
                if (new string(correct) == secretWord)
                {
                  Console.WriteLine("You guessed the word completely!");
                  Console.ReadLine();
                }
            }
            Console.WriteLine($" You lost. The word was: {secretWord}");
            Console.ReadLine();
        }


        }
    }    

