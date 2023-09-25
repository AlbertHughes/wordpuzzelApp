namespace WordPuzzelApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2f2 = new Label();
            label1f2 = new Label();
            textBoxf2 = new TextBox();
            button_start2 = new Button();
            button_next2 = new Button();
            level_button = new Button();
            label_scoref2 = new Label();
            label4_hint = new Label();
            label1 = new Label();
            button_hintClicked = new Button();
            label_remaining_lives = new Label();
            SuspendLayout();
            // 
            // label2f2
            // 
            label2f2.BackColor = Color.LightGoldenrodYellow;
            label2f2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2f2.Location = new Point(199, 48);
            label2f2.Name = "label2f2";
            label2f2.Size = new Size(699, 63);
            label2f2.TabIndex = 5;
            label2f2.Text = "Result";
            label2f2.TextAlign = ContentAlignment.MiddleCenter;
            label2f2.Click += label2_Click;
            // 
            // label1f2
            // 
            label1f2.BackColor = Color.SeaShell;
            label1f2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1f2.Location = new Point(199, 163);
            label1f2.Name = "label1f2";
            label1f2.Size = new Size(699, 73);
            label1f2.TabIndex = 6;
            label1f2.Text = "Word";
            label1f2.TextAlign = ContentAlignment.MiddleCenter;
            label1f2.Click += label1f2_Click;
            // 
            // textBoxf2
            // 
            textBoxf2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxf2.Location = new Point(199, 277);
            textBoxf2.Margin = new Padding(3, 4, 3, 4);
            textBoxf2.Name = "textBoxf2";
            textBoxf2.Size = new Size(700, 52);
            textBoxf2.TabIndex = 7;
            textBoxf2.TextAlign = HorizontalAlignment.Center;
            textBoxf2.TextChanged += textBoxf2_TextChanged;
            // 
            // button_start2
            // 
            button_start2.BackColor = Color.Thistle;
            button_start2.FlatAppearance.BorderColor = Color.Black;
            button_start2.FlatAppearance.BorderSize = 20;
            button_start2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_start2.Location = new Point(734, 413);
            button_start2.Margin = new Padding(3, 4, 3, 4);
            button_start2.Name = "button_start2";
            button_start2.Size = new Size(165, 77);
            button_start2.TabIndex = 8;
            button_start2.Text = "Start";
            button_start2.UseVisualStyleBackColor = false;
            button_start2.Click += button_start_Click;
            // 
            // button_next2
            // 
            button_next2.BackColor = Color.Thistle;
            button_next2.Enabled = false;
            button_next2.FlatAppearance.BorderColor = Color.Black;
            button_next2.FlatAppearance.BorderSize = 100;
            button_next2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_next2.Location = new Point(199, 413);
            button_next2.Margin = new Padding(3, 4, 3, 4);
            button_next2.Name = "button_next2";
            button_next2.Size = new Size(163, 77);
            button_next2.TabIndex = 9;
            button_next2.Text = "Next";
            button_next2.UseVisualStyleBackColor = false;
            button_next2.Click += button_next_Click;
            // 
            // level_button
            // 
            level_button.BackColor = Color.Wheat;
            level_button.FlatAppearance.BorderColor = Color.Black;
            level_button.FlatAppearance.BorderSize = 20;
            level_button.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            level_button.Location = new Point(920, 272);
            level_button.Margin = new Padding(3, 4, 3, 4);
            level_button.Name = "level_button";
            level_button.Size = new Size(165, 77);
            level_button.TabIndex = 10;
            level_button.Text = "Form3";
            level_button.UseVisualStyleBackColor = false;
            level_button.Visible = false;
            level_button.Click += level_button3_Click;
            // 
            // label_scoref2
            // 
            label_scoref2.AutoSize = true;
            label_scoref2.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_scoref2.Location = new Point(61, 51);
            label_scoref2.Name = "label_scoref2";
            label_scoref2.Size = new Size(75, 54);
            label_scoref2.TabIndex = 11;
            label_scoref2.Text = "00";
            label_scoref2.Click += label_scoref2_Click;
            // 
            // label4_hint
            // 
            label4_hint.Location = new Point(25, 163);
            label4_hint.Name = "label4_hint";
            label4_hint.Size = new Size(150, 166);
            label4_hint.TabIndex = 12;
            label4_hint.Text = "Hint";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(916, 140);
            label1.Name = "label1";
            label1.Size = new Size(157, 46);
            label1.TabIndex = 19;
            label1.Text = "level 2";
            // 
            // button_hintClicked
            // 
            button_hintClicked.BackColor = Color.RosyBrown;
            button_hintClicked.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_hintClicked.Location = new Point(25, 365);
            button_hintClicked.Name = "button_hintClicked";
            button_hintClicked.Size = new Size(150, 66);
            button_hintClicked.TabIndex = 20;
            button_hintClicked.Text = "Hint";
            button_hintClicked.UseVisualStyleBackColor = false;
            button_hintClicked.Click += button1_Click_1;
            // 
            // label_remaining_lives
            // 
            label_remaining_lives.BackColor = Color.DarkSalmon;
            label_remaining_lives.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_remaining_lives.Location = new Point(920, 59);
            label_remaining_lives.Name = "label_remaining_lives";
            label_remaining_lives.Size = new Size(153, 52);
            label_remaining_lives.TabIndex = 21;
            label_remaining_lives.Text = "lives: 3";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1086, 600);
            Controls.Add(label_remaining_lives);
            Controls.Add(button_hintClicked);
            Controls.Add(label1);
            Controls.Add(label4_hint);
            Controls.Add(label_scoref2);
            Controls.Add(level_button);
            Controls.Add(button_next2);
            Controls.Add(button_start2);
            Controls.Add(textBoxf2);
            Controls.Add(label1f2);
            Controls.Add(label2f2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2f2;
        private Label label1f2;
        private TextBox textBoxf2;
        private Button button_start2;
        private Button button_next2;
        private Button level_button;
        private Label label_scoref2;
        private Label label4_hint;
        private Label label1;
        private Button button_hintClicked;
        private Label label_remaining_lives;
    }
}