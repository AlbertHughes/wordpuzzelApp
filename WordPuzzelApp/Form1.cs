using System.DirectoryServices.ActiveDirectory;
using static System.Formats.Asn1.AsnWriter;

namespace WordPuzzelApp
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private int index = 0;
        private int score = 0;
        private int lives = 3;
        private readonly string[] words = { "computer", "signature", "polymorphism", "encapsulation", "abstraction", "highway", ".net framework", "forest", "chocolate", "parliament" };
        private Random random = new Random();
        private int animationState = 1;
        private string originalWord;

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;

            label2.Text = "Result";
            label2.BackColor = Color.Peru;
            label_score.Text = "00";
            Displaywords();
            button_next.Enabled = true;
            button_start.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkword();
            if (index < words.Length - 1)
            {
                index++;
                Displaywords();
            }


        }
        // function to dispaly words
        public void Displaywords()
        {
            string word = words[index];

            for (int i = 0; i < 5; i++)
            {
                int pos = random.Next(word.Length);
                word = word.Remove(pos, 1).Insert(pos, "_");
            }

            label1.Text = word;

        }

        private Dictionary<string, string> wordHints = new Dictionary<string, string>
        {
            {"computer", "An electronic device for processing data."},
            {"signature", "A person's name written in a distinctive way."},
            {"polymorphism", "The ability of an object to take on many forms."},
            {"encapsulation", "The bundling of data and methods into a single unit."},
            {"abstraction", "The process of simplifying complex systems by focusing on essential details."},
            {"highway", "A public road, typically with multiple lanes for high-speed traffic."},
            {".net framework", "A software framework developed by Microsoft for building Windows applications."},
            {"forest", "It's a large area covered with trees and vegetation."},
            {"chocolate", "It's a sweet treat made from cacao beans."},
            {"parliament", "It's a legislative body that represents the citizens and makes laws in a country."}
        };

        private string GetWordHint(string word)
        {
            if (wordHints.TryGetValue(word.ToLower(), out string hint))
            {
                return hint;
            }

            return "No hint available.";
        }

        public void checkword()
        {
            bool isCorrect = textBox1.Text.ToLower() == words[index];
            label2.Text = isCorrect ? "Correct" : "Wrong";
            label2.BackColor = isCorrect ? Color.Green : Color.Red;

            if (isCorrect)
            {
                score++;
                

                if (score == 5)
                {
                    MessageBox.Show("Congratulations! Click Ok to go to level 2.", "Score 5", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var newForm = new Form2();
                    newForm.ShowDialog();
                    level_button.Enabled = true;
                }
            }
            else if (index == words.Length - 1)
            {
                button_start.Enabled = true;
                button_next.Enabled = false;
                level_button.Enabled = false;
            }

            textBox1.Text = "";
            label_score.Text = $"{score} / {words.Length}";
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
            Form6.Instance.lab1 = label_score;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_hint_Click(object sender, EventArgs e)
        {
            if (lives > 0)
            {
                string hint = GetWordHint(words[index]);
                label3_hint.Text = hint;
                lives--;
            }
            else
            {
                MessageBox.Show("You have run out of lives. Restart the game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }

            label_lives.Text = $"Lives: {lives}";
        }
        private void ResetGame()
        {
            index = 0;
            score = 0;
            lives = 3;
            label2.Text = "Result";
            label2.BackColor = Color.Peru;
            label_score.Text = "00";
            button_start.Enabled = false;

            Displaywords();
            button_next.Enabled = true;
        }
        
        private void button_start_Click(object sender, EventArgs e)
        {
          
            
        }


    }
}



