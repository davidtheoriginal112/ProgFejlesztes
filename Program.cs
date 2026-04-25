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
            Console.WriteLine("Вгадай слово з 5 букв!");
            for (int i = 0; i < attempts; i++)
            {
                Console.WriteLine("Слово: " + new string(correct));
                Console.Write($"Спроба {i + 1}: ");
                string guess = Console.ReadLine().ToLower();
                if (guess.Length != 5)
                {
                  Console.WriteLine("Введи рівно 5 букв!");
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
                  Console.WriteLine("🎉 Ти повністю вгадав слово!");
                  Console.ReadLine();
                }
            }
            Console.WriteLine($" Ти програв. Слово було: {secretWord}");
            Console.ReadLine();
        }


        }
    }    

