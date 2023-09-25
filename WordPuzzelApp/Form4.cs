using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordPuzzelApp
{
    public partial class Form4 : Form
    {
        bool hintDisplayed = false;
        public Form4()
        {
            InitializeComponent();
        }

        string[] words = { "Usability", "Interface", "Feedback", "Prototype", "Workflow", "Responsive", "Navigation", "Userview", "Wireframe" };
        int index3 = 0, score3 = 0, lives = 3;
        Random random = new Random();


        public void Displaywords()
        {
            string word = words[index3];

            for (int i = 0; i < 5; i++)
            {
                int pos = random.Next(word.Length);
                word = word.Remove(pos, 1).Insert(pos, "_");
            }

            label_words.Text = word;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        public void checkword4()
        {
            string guessedWord = textBox4.Text.ToLower();
            string actualWord = words[index3].ToLower();
            bool isCorrect = guessedWord.Equals(actualWord);
            if (isCorrect)
            {
                score3++;
            }
            result4.Text = isCorrect ? "Correct" : "Wrong";
            result4.BackColor = isCorrect ? Color.Green : Color.Red;

            label_score4.Text = $"{score3} / {words.Length}";

            if (score3 == 5)
            {
                MessageBox.Show("Congratulations! Click Ok to go to level 5.", "Score 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form5 form5 = new Form5();
                form5.Show();
            }
            else if (index3 == words.Length - 1)
            {
                button_start4.Enabled = true;
                button_next4.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            if (index3 >= 0 && index3 < hints.Length)
            {
                // Display the hint in a message box
                MessageBox.Show("Hint: " + hints[index3], "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lives > 0 && !hintDisplayed)
            {
                DisplayHint();
                lives--; // Decrease lives when hint is clicked
                label_lives4.Text = $"Lives: {lives}";
                hintDisplayed = true;
            }
            else if (lives <= 0)
            {
                MessageBox.Show("You have run out of lives. Restart the game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
        }


        private void ResetGame()
        {
            index3 = 0;
            score3 = 0;
            lives = 3; // Reset lives
            label_lives4.Text = $"Lives: {lives}";
            result4.Text = "Result";
            result4.BackColor = Color.Peru;
            label_score4.Text = "00";
            textBox4.Text = "";
            Displaywords();
            button_next4.Enabled = true;
            button_start4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkword4();
            if (index3 < words.Length - 1)
            {
                index3++;
                Displaywords();
                hintDisplayed = false;
                textBox4.Text = "";
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            index3 = 0;
            score3 = 0;

            result4.BackColor = Color.Peru;
            label_score4.Text = "00";
            Displaywords();
            button_next4.Enabled = true;
            button_start4.Enabled = false;
        }

    }
}

