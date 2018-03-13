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
    public partial class Form1 : Form
    {
        private Binomial bi;
        private Poisson po;
        private Pascal pa;

        string currentdist;
        public Form1()
        {
            InitializeComponent();
        }

        private void Binomial_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("Enter the probability that x=0 (p)", "Enter the required number of trials (N)");
            frm3.ShowDialog();
            bi = new Binomial(frm3.result1, frm3.result2);
            PMF.Text = bi.getPMF();
            Mean.Text = bi.getMean();
            currentdist = "Binomial";
            label1.Text = "Arrivals (k)";
        }

        private void Poisson_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("Enter the arrival rate (λ)", "Enter the period (T)");
            frm3.ShowDialog();
            po = new Poisson(frm3.result1, frm3.result2);
            PMF.Text = po.getPMF();
            Mean.Text = po.getMean();
            currentdist = "Poisson";
            label1.Text = "Arrivals (k)";
        }

        private void Pascal_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3("Enter the probability that x=0 (p)", "Enter the number of arrivals (k)");
            frm3.ShowDialog();
            pa = new Pascal(frm3.result1, frm3.result2);
            PMF.Text = pa.getPMF();
            Mean.Text = pa.getMean();
            currentdist = "Pascal";
            label1.Text = "Trials (N)";
        }

        private void Evaluate_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(textBox3.Text, out result))
            {
                switch(currentdist)
                {
                    case "Binomial":
                        if (result > bi.N)
                        {
                            MessageBox.Show("Number of arrivals cannot exceed number of trials.");
                        }
                        else
                        {
                            Value.Text = bi.getResult(result);
                        }
                        break;
                    case "Poisson":
                        Value.Text = po.getResult(result);
                        break;
                    case "Pascal":
                        if (result < pa.k)
                        {
                            MessageBox.Show("Number of arrivals cannot exceed number of trials.");
                        }
                        else
                        {
                            Value.Text = pa.getResult(result);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Could not parse value. Please try again.");
            }
        }
    }
}
