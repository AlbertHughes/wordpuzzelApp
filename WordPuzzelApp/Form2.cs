using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordPuzzelApp
{
    public partial class Form2 : Form
    {
        private bool hintClicked = false;
        public Form2()
        {
            InitializeComponent();

        }
        string[] words = new[] { "Algorithm","Database","Programming","Cybersecurity","Network","Server","Cloud","Software"
            ,"Hardware","Firewall","Encryption", };
        string[] hints = new[]
       {
            "A step-by-step procedure or set of rules for solving a problem or performing a task.",
            "A structured collection of data that is organized and can be accessed, managed, and updated.",
            "The process of creating instructions that tell a computer how to perform a specific task.",
            "The practice of protecting computers, servers, mobile devices, electronic systems, networks, and data from digital attacks.",
            "A group of interconnected devices, such as computers, that can communicate with each other.",
            "A computer or system that provides resources, data, services, or programs to other computers or devices.",
            "A network of servers that are accessed over the internet to store and manage data.",
            "A collection of programs, data, and instructions that tell a computer how to perform specific tasks.",
            "The physical components of a computer system, such as the processor, memory, and storage devices.",
            "A security device or software that monitors and controls incoming and outgoing network traffic.",
            "The process of converting information or data into a code to prevent unauthorized access."
        };

        int index1 = 0, score1 = 0, remainingLives = 3;
        Random random = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            Displaywords();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkwordf2();

        }
        public void Displaywords()
        {
            string word = words[index1];

            for (int i = 0; i < 5; i++)
            {
                int pos = random.Next(word.Length);
                word = word.Remove(pos, 1).Insert(pos, "_");
            }

            label1f2.Text = word;
        }


        public void checkwordf2()
        {
            string guessedWord = textBoxf2.Text.ToLower();
            string actualWord = words[index1].ToLower();
            bool isCorrect = guessedWord.Equals(actualWord);

            if (isCorrect)
            {
                score1++;
            }
                label2f2.Text = isCorrect ? "Correct" : "Wrong";
            label2f2.BackColor = isCorrect ? Color.Green : Color.Red;

           

            if (score1 == 5)
            {
                    MessageBox.Show("Congratulations! Click Ok to go to level 3.", "Score 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.ShowDialog();
                    level_button.Enabled = true;
            }
            
            else if (index1 == words.Length - 1)
            {
                button_start2.Enabled = true;
                button_next2.Enabled = false;
                level_button.Enabled = false;
            }

            textBoxf2.Text = "";
            label_scoref2.Text = $"{score1} / {words.Length}";
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            index1 = 0;
            score1 = 0;

            label2f2.Text = "Result";
            label2f2.BackColor = Color.Peru;
            label_scoref2.Text = "00";

            button_next2.Enabled = true;
            button_start2.Enabled = false;

            Displaywords();
        }


        private void button_next_Click(object sender, EventArgs e)
        {

            checkwordf2();
            if (index1 < words.Length - 1)
            {
                index1++;
                Displaywords();
            }
        }



        private void level_button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }


        private void label1f2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxf2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_scoref2_Click(object sender, EventArgs e)
        {

        }
        private void RestartGame()
        {
            index1 = 0;
            score1 = 0;
            remainingLives = 3;

            label2f2.Text = "Result";
            label2f2.BackColor = Color.Peru;
            label_scoref2.Text = "00";

            button_start2.Enabled = false;
            button_next2.Enabled = true;

            Displaywords();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            remainingLives--;

            label_remaining_lives.Text = "Lives: " + remainingLives.ToString();

            if (remainingLives == 0)
            {
                MessageBox.Show("You've run out of lives. Restart the game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestartGame();
            }

            hintClicked = true;
            if (hintClicked)
            {
                label4_hint.Text = hints[index1];
            }
        }

    }
}
