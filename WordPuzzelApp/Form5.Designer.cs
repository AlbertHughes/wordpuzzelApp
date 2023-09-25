namespace WordPuzzelApp
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            textBox4 = new TextBox();
            button_hint4 = new Button();
            button_start4 = new Button();
            button_next4 = new Button();
            label_lives4 = new Label();
            label_words = new Label();
            label_score4 = new Label();
            label4 = new Label();
            result4 = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(337, 309);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(421, 55);
            textBox4.TabIndex = 17;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button_hint4
            // 
            button_hint4.BackColor = Color.NavajoWhite;
            button_hint4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_hint4.Location = new Point(101, 415);
            button_hint4.Name = "button_hint4";
            button_hint4.Size = new Size(135, 67);
            button_hint4.TabIndex = 16;
            button_hint4.Text = "Hint";
            button_hint4.UseVisualStyleBackColor = false;
            button_hint4.Click += button_hint4_Click;
            // 
            // button_start4
            // 
            button_start4.BackColor = Color.Magenta;
            button_start4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_start4.Location = new Point(623, 415);
            button_start4.Name = "button_start4";
            button_start4.Size = new Size(135, 67);
            button_start4.TabIndex = 15;
            button_start4.Text = "Start";
            button_start4.UseVisualStyleBackColor = false;
            button_start4.Click += button_start4_Click;
            // 
            // button_next4
            // 
            button_next4.BackColor = Color.Magenta;
            button_next4.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button_next4.Location = new Point(337, 415);
            button_next4.Name = "button_next4";
            button_next4.Size = new Size(135, 67);
            button_next4.TabIndex = 14;
            button_next4.Text = "Next";
            button_next4.UseVisualStyleBackColor = false;
            button_next4.Click += button_next4_Click;
            // 
            // label_lives4
            // 
            label_lives4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_lives4.Location = new Point(842, 124);
            label_lives4.Name = "label_lives4";
            label_lives4.Size = new Size(143, 44);
            label_lives4.TabIndex = 13;
            label_lives4.Text = "lives: 3";
            label_lives4.Click += label_lives4_Click;
            // 
            // label_words
            // 
            label_words.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_words.Location = new Point(337, 216);
            label_words.Name = "label_words";
            label_words.Size = new Size(421, 64);
            label_words.TabIndex = 12;
            label_words.Text = "Word";
            label_words.TextAlign = ContentAlignment.MiddleCenter;
            label_words.Click += label_words_Click;
            // 
            // label_score4
            // 
            label_score4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label_score4.Location = new Point(134, 119);
            label_score4.Name = "label_score4";
            label_score4.Size = new Size(102, 79);
            label_score4.TabIndex = 11;
            label_score4.Text = "00";
            label_score4.TextAlign = ContentAlignment.MiddleCenter;
            label_score4.Click += label_score4_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.PeachPuff;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(842, 199);
            label4.Name = "label4";
            label4.Size = new Size(143, 58);
            label4.TabIndex = 10;
            label4.Text = "LEVEL 5";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // result4
            // 
            result4.BackColor = Color.Azure;
            result4.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            result4.Location = new Point(337, 120);
            result4.Name = "result4";
            result4.Size = new Size(421, 54);
            result4.TabIndex = 9;
            result4.Text = "Result";
            result4.TextAlign = ContentAlignment.MiddleCenter;
            result4.Click += result4_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1086, 600);
            Controls.Add(textBox4);
            Controls.Add(button_hint4);
            Controls.Add(button_start4);
            Controls.Add(button_next4);
            Controls.Add(label_lives4);
            Controls.Add(label_words);
            Controls.Add(label_score4);
            Controls.Add(label4);
            Controls.Add(result4);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Button button_hint4;
        private Button button_start4;
        private Button button_next4;
        private Label label_lives4;
        private Label label_words;
        private Label label_score4;
        private Label label4;
        private Label result4;
    }
}