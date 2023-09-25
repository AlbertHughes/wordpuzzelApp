using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WordPuzzelApp
{
    public partial class Form3 : Form
    {
        bool hintDisplayed = false;

        string[] words = { "Animation", "Malware", "Gamified", "Eye-Tracking", "JavaScript", "Artboard", "Aesthetics", "Personal", "Encryption" };
        int index2 = 0, score2 = 0, lives = 3;
        Random random = new Random();

        public Form3()
        {
            InitializeComponent();
            button_hintf3.Click += button_hintf3_Click;
        }

        public void Displaywords()
        {
            string word = words[index2];

            for (int i = 0; i < 5; i++)
            {
                int pos = random.Next(word.Length);
                word = word.Remove(pos, 1).Insert(pos, "_");
            }

            label1f3.Text = word;
        }


        public void DisplayHint()
        {
            string[] hints = {
        "This is a type of malicious software.",
        "This is a generic term for various types of harmful software.",
        "This is a markup language used for web development.",
        "This is a style sheet language used for web design.",
        "This is a programming language commonly used for web development.",
        "This allows different software applications to communicate with each other.",
        "This involves creating intelligent agents that mimic human behavior.",
        "This deals with handling and analyzing large datasets.",
        "This is a global network of connected computers."
        };

            if (index2 >= 0 && index2 < hints.Length)
            {
                // Display the hint in a message box
                MessageBox.Show("Hint: " + hints[index2], "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Handle the case where the index is out of range
                MessageBox.Show("No hint available.", "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public void checkwordf3()
        {
            string guessedWord = textBoxf3.Text.ToLower();
            string actualWord = words[index2].ToLower();
            bool isCorrect = guessedWord.Equals(actualWord);

            if (isCorrect)
            {
                score2++; // Increment the score for correct guesses
            }

            label2f3.Text = isCorrect ? "Correct" : "Wrong";
            label2f3.BackColor = isCorrect ? Color.Green : Color.Red;

            textBoxf3.Text = "";
            label_scoref3.Text = $"{score2} / {words.Length}";

            if (score2 == 5)
            {
                MessageBox.Show("Congratulations! Click Ok to go to the next level.", "Level Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();
                // Add code here to go to the next level or end the game as needed.
            }
            else if (index2 == words.Length - 1)
            {
                button_start3.Enabled = true;
                button_next3.Enabled = false;
            }
        }


        private void button_start3_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button_next3_Click(object sender, EventArgs e)
        {
            checkwordf3();
            if (index2 < words.Length - 1)
            {
                index2++;
                Displaywords();
                hintDisplayed = false;
            }
        }

        private void RestartGame()
        {
            index2 = 0;
            score2 = 0;

            label2f3.Text = "Result";
            label2f3.BackColor = Color.Peru;
            label_scoref3.Text = "00";
            Displaywords();
            button_next3.Enabled = true;
            button_start3.Enabled = false;
        }




        private void textBoxf3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_hintf3_Click(object sender, EventArgs e)
        {
            if (lives <= 0)
            {
                MessageBox.Show("You have run out of lives. Restart the game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
                return; // Exit the method to prevent further execution.
            }

            if (!hintDisplayed)
            {
                DisplayHint();
                lives--; // Decrease lives when hint is clicked
                label_livesf3.Text = $"Lives: {lives}";
                hintDisplayed = true;
            }
        }


        private void ResetGame()
        {
            index2 = 0;
            score2 = 0;
            lives = 3;

            label_livesf3.Text = $"Lives: {lives}";
            label2f3.Text = "Result";
            label2f3.BackColor = Color.Peru;
            label_scoref3.Text = "00";

            Displaywords();
            button_start3.Enabled = false;
            button_next3.Enabled = true;
        }

        private void label2f3_Click(object sender, EventArgs e)
        {

        }

        private void label1f3_Click(object sender, EventArgs e)
        {

        }

        private void label_scoref3_Click(object sender, EventArgs e)
        {

        }

        private void label_livesf3_Click(object sender, EventArgs e)
        {

        }
    }
}
