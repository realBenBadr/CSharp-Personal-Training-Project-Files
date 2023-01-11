using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Registery_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> name = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            name.Add(textBox1.Text);
            name.Sort();
            listBox1.DataSource = null;
            listBox1.DataSource= name;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            name.Remove(textBox1.Text);
            listBox1.DataSource = null;
            listBox1.DataSource = name;
            textBox1.Text = "";
        }


    }
}
