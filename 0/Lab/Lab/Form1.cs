using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "!";
            string caption = "Error";
            bool result = double.TryParse(textBox1.Text, out double b_1);
            bool result1 = double.TryParse(textBox2.Text, out double c_1);
            if(result == false)
            {
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            else if(result1 == false)
            {
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                result1 = true;
            }
            else
            {
                if(button2.BackColor == Color.DarkBlue)
                {
                    double y = (2 * x - c_1) / (sqrt(X - b_1)) + | x - c_1 |;
                }
            }
        }
    }
}
