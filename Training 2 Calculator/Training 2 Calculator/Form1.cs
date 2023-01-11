using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_2_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;

        string sum(double a, double b) 
        {

            return Convert.ToString(a + b);

        }

        string min(double a, double b) 
        {
        
            return Convert.ToString(a - b);

        }

        string time(double a, double b)
        {

            return Convert.ToString(a * b);

        }

        string div(double a, double b) 
        {
            
            return Convert.ToString(a / b);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(sum(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(min(a, b));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(time(a, b));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(div(a, b));
        }
    }
}
