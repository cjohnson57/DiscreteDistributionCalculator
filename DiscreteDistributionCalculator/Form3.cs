using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscreteDistributionCalculator
{
    public partial class Form3 : Form
    {
        public double result1;
        public double result2;
        public Form3(string label1text, string label2text)
        { 
            InitializeComponent();
            label1.Text = label1text;
            label2.Text = label2text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out result1) && double.TryParse(textBox2.Text, out result2))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Could not parse value. Please try again.");
            }
        }
    }
}
