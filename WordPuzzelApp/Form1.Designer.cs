namespace WordPuzzelApp
{
    partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button_next = new Button();
            button_start = new Button();
            label2 = new Label();
            label_score = new Label();
            button1 = new Button();
            level_button = new Button();
            label3_hint = new Label();
            button_hint = new Button();
            label_lives = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 165);
            label1.Name = "label1";
            label1.Size = new Size(699, 73);
            label1.TabIndex = 0;
            label1.Text = "Word ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button_next
            // 
            button_next.BackColor = Color.Thistle;
            button_next.Enabled = false;
            button_next.FlatAppearance.BorderColor = Color.Black;
            button_next.FlatAppearance.BorderSize = 100;
            button_next.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_next.Location = new Point(203, 428);
            button_next.Margin = new Padding(3, 4, 3, 4);
            button_next.Name = "button_next";
            button_next.Size = new Size(218, 77);
            button_next.TabIndex = 2;
            button_next.Text = "Next";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += button1_Click;
            // 
            // button_start
            // 
            button_start.BackColor = Color.Thistle;
            button_start.FlatAppearance.BorderColor = Color.Black;
            button_start.FlatAppearance.BorderSize = 20;
            button_start.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_start.Location = new Point(685, 428);
            button_start.Margin = new Padding(3, 4, 3, 4);
            button_start.Name = "button_start";
            button_start.Size = new Size(218, 77);
            button_start.TabIndex = 3;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button2_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGoldenrodYellow;
            label2.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(203, 51);
            label2.Name = "label2";
            label2.Size = new Size(699, 63);
            label2.TabIndex = 4;
            label2.Text = "Result";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_score.Location = new Point(50, 53);
            label_score.Name = "label_score";
            label_score.Size = new Size(75, 54);
            label_score.TabIndex = 6;
            label_score.Text = "00";
            label_score.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(943, 99);
            button1.Name = "button1";
            button1.Size = new Size(131, 53);
            button1.TabIndex = 7;
            button1.Text = "LEVEL 1";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click_1;
            // 
            // level_button
            // 
            level_button.BackColor = Color.Wheat;
            level_button.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            level_button.Location = new Point(943, 291);
            level_button.Name = "level_button";
            level_button.Size = new Size(133, 72);
            level_button.TabIndex = 8;
            level_button.Text = "NEXT LEVEL";
            level_button.UseVisualStyleBackColor = false;
            level_button.Visible = false;
            level_button.Click += button2_Click_1;
            // 
            // label3_hint
            // 
            label3_hint.BackColor = Color.LightCyan;
            label3_hint.Location = new Point(12, 165);
            label3_hint.Name = "label3_hint";
            label3_hint.Size = new Size(160, 126);
            label3_hint.TabIndex = 9;
            label3_hint.Text = "Hint";
            label3_hint.Click += label3_Click_1;
            // 
            // button_hint
            // 
            button_hint.BackColor = Color.Wheat;
            button_hint.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_hint.Location = new Point(12, 359);
            button_hint.Name = "button_hint";
            button_hint.Size = new Size(160, 72);
            button_hint.TabIndex = 10;
            button_hint.Text = "Hint";
            button_hint.UseVisualStyleBackColor = false;
            button_hint.Click += button_hint_Click;
            // 
            // label_lives
            // 
            label_lives.BackColor = Color.RosyBrown;
            label_lives.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_lives.Location = new Point(943, 34);
            label_lives.Name = "label_lives";
            label_lives.Size = new Size(131, 45);
            label_lives.TabIndex = 11;
            label_lives.Text = "Lives: 3";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(203, 273);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(699, 75);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1086, 600);
            Controls.Add(textBox1);
            Controls.Add(label_lives);
            Controls.Add(button_hint);
            Controls.Add(label3_hint);
            Controls.Add(level_button);
            Controls.Add(button1);
            Controls.Add(label_score);
            Controls.Add(label2);
            Controls.Add(button_start);
            Controls.Add(button_next);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_next;
        private Button button_start;
        private Label label2;
        private Label label_score;
        private Button button1;
        private Button level_button;
        private Label label3_hint;
        private Button button_hint;
        private Label label_lives;
        private TextBox textBox1;
    }
}