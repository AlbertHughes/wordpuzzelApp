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
    public partial class Form6 : Form
    {
        public static Form6 Instance;
        public Label lab1;
        public Form6()
        {
            InitializeComponent();
            Instance = this;
            lab1 = label_Total;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close the application?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit(); // Close the application
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
         

        }
    }
}
