using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_3_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        double h;
        double w;
        

        double BMI(double w, double h) 
        {
        
            return (w /(h * h));
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            h = Convert.ToDouble(textBox1.Text);
            w = Convert.ToDouble(textBox2.Text);

            label4.Text = BMI(w, h).ToString();
        }
    }
}
