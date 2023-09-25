namespace WordPuzzelApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label_scoref3 = new Label();
            label2f3 = new Label();
            label1f3 = new Label();
            textBoxf3 = new TextBox();
            button_next3 = new Button();
            button_start3 = new Button();
            label1 = new Label();
            button_hintf3 = new Button();
            label_livesf3 = new Label();
            SuspendLayout();
            // 
            // label_scoref3
            // 
            label_scoref3.AutoSize = true;
            label_scoref3.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_scoref3.Location = new Point(48, 33);
            label_scoref3.Name = "label_scoref3";
            label_scoref3.Size = new Size(75, 54);
            label_scoref3.TabIndex = 12;
            label_scoref3.Text = "00";
            label_scoref3.Click += label_scoref3_Click;
            // 
            // label2f3
            // 
            label2f3.BackColor = Color.LightGoldenrodYellow;
            label2f3.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2f3.Location = new Point(200, 33);
            label2f3.Name = "label2f3";
            label2f3.Size = new Size(699, 63);
            label2f3.TabIndex = 13;
            label2f3.Text = "Result";
            label2f3.TextAlign = ContentAlignment.MiddleCenter;
            label2f3.Click += label2f3_Click;
            // 
            // label1f3
            // 
            label1f3.BackColor = Color.SeaShell;
            label1f3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1f3.Location = new Point(200, 161);
            label1f3.Name = "label1f3";
            label1f3.Size = new Size(699, 73);
            label1f3.TabIndex = 14;
            label1f3.Text = "Word";
            label1f3.TextAlign = ContentAlignment.MiddleCenter;
            label1f3.Click += label1f3_Click;
            // 
            // textBoxf3
            // 
            textBoxf3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxf3.Location = new Point(199, 297);
            textBoxf3.Margin = new Padding(3, 4, 3, 4);
            textBoxf3.Name = "textBoxf3";
            textBoxf3.Size = new Size(700, 52);
            textBoxf3.TabIndex = 15;
            textBoxf3.TextAlign = HorizontalAlignment.Center;
            textBoxf3.TextChanged += textBoxf3_TextChanged;
            // 
            // button_next3
            // 
            button_next3.BackColor = Color.Thistle;
            button_next3.Enabled = false;
            button_next3.FlatAppearance.BorderColor = Color.Black;
            button_next3.FlatAppearance.BorderSize = 100;
            button_next3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_next3.Location = new Point(200, 409);
            button_next3.Margin = new Padding(3, 4, 3, 4);
            button_next3.Name = "button_next3";
            button_next3.Size = new Size(163, 77);
            button_next3.TabIndex = 16;
            button_next3.Text = "Next";
            button_next3.UseVisualStyleBackColor = false;
            button_next3.Click += button_next3_Click;
            // 
            // button_start3
            // 
            button_start3.BackColor = Color.Thistle;
            button_start3.FlatAppearance.BorderColor = Color.Black;
            button_start3.FlatAppearance.BorderSize = 20;
            button_start3.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_start3.Location = new Point(734, 409);
            button_start3.Margin = new Padding(3, 4, 3, 4);
            button_start3.Name = "button_start3";
            button_start3.Size = new Size(165, 77);
            button_start3.TabIndex = 17;
            button_start3.Text = "Start";
            button_start3.UseVisualStyleBackColor = false;
            button_start3.Click += button_start3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(922, 123);
            label1.Name = "label1";
            label1.Size = new Size(158, 46);
            label1.TabIndex = 18;
            label1.Text = "level 3";
            label1.Click += label1_Click;
            // 
            // button_hintf3
            // 
            button_hintf3.BackColor = SystemColors.ControlDarkDark;
            button_hintf3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button_hintf3.Location = new Point(29, 334);
            button_hintf3.Name = "button_hintf3";
            button_hintf3.Size = new Size(139, 77);
            button_hintf3.TabIndex = 19;
            button_hintf3.Text = "Hint";
            button_hintf3.UseVisualStyleBackColor = false;
            button_hintf3.Click += button_hintf3_Click;
            // 
            // label_livesf3
            // 
            label_livesf3.BackColor = Color.Honeydew;
            label_livesf3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_livesf3.Location = new Point(922, 45);
            label_livesf3.Name = "label_livesf3";
            label_livesf3.Size = new Size(158, 46);
            label_livesf3.TabIndex = 20;
            label_livesf3.Text = "Lives: 3";
            label_livesf3.Click += label_livesf3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1086, 600);
            Controls.Add(label_livesf3);
            Controls.Add(button_hintf3);
            Controls.Add(label1);
            Controls.Add(button_start3);
            Controls.Add(button_next3);
            Controls.Add(textBoxf3);
            Controls.Add(label1f3);
            Controls.Add(label2f3);
            Controls.Add(label_scoref3);
            Name = "Form3";
            Text = "Hint";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_scoref3;
        private Label label2f3;
        private Label label1f3;
        private TextBox textBoxf3;
        private Button button_next3;
        private Button button_start3;
        private Label label1;
        private Button button_hintf3;
        private Label label_livesf3;
    }
}