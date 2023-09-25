namespace WordPuzzelApp
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label_Total = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label_Total
            // 
            label_Total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_Total.Location = new Point(92, 100);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(186, 56);
            label_Total.TabIndex = 0;
            label_Total.Text = "Total Score:  00";
            label_Total.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(257, 480);
            button1.Name = "button1";
            button1.Size = new Size(165, 60);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(603, 480);
            button2.Name = "button2";
            button2.Size = new Size(165, 60);
            button2.TabIndex = 2;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1086, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label_Total);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Label label_Total;
        private Button button1;
        private Button button2;
    }
}