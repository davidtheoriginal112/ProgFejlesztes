using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string secretWord;
        private int attempts;
        private char[] correct;

        // важливо: один Random, а не новий кожного разу
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            secretWord = GenerateRandomWord(5);
            attempts = 6;
            correct = new string('_', 5).ToCharArray();

            lblResult.Text = "Слово: " + new string(correct);
            lblAttempts.Text = $"Залишилось спроб: {attempts}";

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private string GenerateRandomWord(int length)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            char[] word = new char[length];

            for (int i = 0; i < length; i++)
            {
                word[i] = letters[random.Next(letters.Length)];
            }

            return new string(word);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();

            if (guess.Length != 5)
            {
                MessageBox.Show("Введіть слово з 5 літер!");
                return;
            }

            attempts--;

            for (int j = 0; j < 5; j++)
            {
                if (guess[j] == secretWord[j])
                {
                    correct[j] = guess[j];
                }
            }

            lblResult.Text = "Слово: " + new string(correct);
            lblAttempts.Text = $"Залишилось спроб: {attempts}";

            if (new string(correct) == secretWord)
            {
                MessageBox.Show("Ви вгадали!");
                StartNewGame();
            }
            else if (attempts <= 0)
            {
                MessageBox.Show($"Ви програли. Слово було: {secretWord}");
                StartNewGame();
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }
    }
}