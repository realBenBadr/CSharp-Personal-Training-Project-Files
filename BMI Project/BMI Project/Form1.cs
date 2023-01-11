using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double hight;
        double weight;

        double BMI(double h, double w) 
        {
            return w / (h * h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weight = Convert.ToDouble(textBox1.Text);
            hight = Convert.ToDouble(textBox2.Text);

            label4.Text = BMI(hight, weight).ToString();
        }

        
    }
}
