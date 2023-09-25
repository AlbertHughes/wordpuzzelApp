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

namespace WordPuzzelApp
{
    public partial class Form5 : Form
    {
        bool hintDisplayed = false;
        public Form5()
        {
            InitializeComponent();

        }
        string[] words = new[] { "DeepLearn", "Backprop", "Converge", "Gradient", "Activation", "Regression", "Convolution", "Overfitting", "Regularize", "Algorithm" };
        int index4 = 0, score4 = 0, lives = 3;
        Random random = new Random();

        public void Displaywords()
        {
            string word = words[index4];
            StringBuilder wordBuilder = new StringBuilder(word);

            for (int i = 0; i < 4; i++)
            {
                int pos = random.Next(word.Length);
                wordBuilder[pos] = '_';
            }

            label_words.Text = wordBuilder.ToString();
        }


        private void result4_Click(object sender, EventArgs e)
        {

        }
        public void checkword4()
        {
            string guessedWord = textBox4.Text.ToLower();
            string actualWord = words[index4].ToLower();

            bool isCorrect = guessedWord.Equals(actualWord);
            if (isCorrect)
            {
                score4++; // Increment the score for correct guesses
            }
            result4.Text = isCorrect ? "Correct" : "Wrong";
            result4.BackColor = isCorrect ? Color.Green : Color.Red;

            label_score4.Text = $"{score4} / {words.Length}";

            if (score4 == 5)
            {
                MessageBox.Show("Congratulations! Click Ok for Results.", "Score 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form6 form6 = new Form6();
                form6.Show();
            }
            else if (index4 == words.Length - 1)
            {
                button_start4.Enabled = true;
                button_next4.Enabled = false;
            }
        }

        private void label_words_Click(object sender, EventArgs e)
        {

        }
        public void DisplayHint()
        {
            string[] hints = {
        "This term refers to a subset of machine learning that involves artificial neural " +
        "networks with multiple layers, allowing for complex pattern recognition.",
        "Short for 'backpropagation,' this is an essential algorithm in neural networks used for " +
         "In optimization and learning, this term describes the process when a sequence of values approaches " +
         "a stable or optimal solution.",
        "It represents the slope or rate of change of a function and is crucial for various optimization " +
        "techniques, like gradient descent.",
         "In neural networks, this function determines the output of a neuron based on its input, enabling " +
         "non-linearity and complexity in learning.",
        "This statistical method models the relationship between a dependent variable and one or more " +
        "independent variables, often used for prediction.",
         "A mathematical operation widely used in image processing and deep learning for features " +
         "extraction, e.g., in convolutional neural networks (CNNs).",
        "This occurs when a machine learning model learns the training data too well, capturing noise, " +
        "and performs poorly on new, unseen data.",
         "To prevent overfitting, this process adds penalties or constraints to a machine learning model " +
         "to encourage simpler and more generalized solutions.",
         "A step-by-step procedure or set of rules used to solve a problem or perform a task, " +
         "fundamental in computer science and machine learning."
        };

            string hint = index4 >= 0 && index4 < hints.Length ? hints[index4] : "No hint available";

            // Display the hint in a message box
            MessageBox.Show("Hint: " + hint, "Hint", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetGame()
        {
            index4 = 0;
            score4 = 0;
            lives = 3; // Reset lives
            label_lives4.Text = $"Lives: {lives}";
            result4.Text = "Result";
            result4.BackColor = Color.Peru;
            label_score4.Text = "00";
            textBox4.Clear(); // Use Clear() to clear the textbox
            Displaywords();
            button_next4.Enabled = true;
            button_start4.Enabled = false;
        }


        private void label_score4_Click(object sender, EventArgs e)
        {

        }

        private void button_hint4_Click(object sender, EventArgs e)
        {
            if (lives > 0 && !hintDisplayed)
            {
                DisplayHint();
                lives--; // Decrease lives when hint is clicked
                label_lives4.Text = $"Lives: {lives}";
                hintDisplayed = true;
            }
            else
            {
                MessageBox.Show("You have run out of lives. Restart the game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
        }


        private void button_next4_Click(object sender, EventArgs e)
        {
            checkword4();
            if (index4 < words.Length - 1)
            {
                index4++;
                Displaywords();
                hintDisplayed = false;
                textBox4.Text = "";
            }
        }


        private void button_start4_Click(object sender, EventArgs e)
        {
            index4 = 0;
            score4 = 0;

            result4.Text = "Result";
            result4.BackColor = Color.Peru;
            label_score4.Text = "00";
            Displaywords();
            button_next4.Enabled = true;
            button_start4.Enabled = false;
        }

        private void label_lives4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
