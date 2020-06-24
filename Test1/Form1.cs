using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        CalculatorClass2 CalClass2 = new CalculatorClass2();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int output = CalClass2.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = output + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int output = CalClass2.Sub(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = output + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int output = CalClass2.Multi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            textBox3.Text = output + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double output = CalClass2.Div(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            output = Math.Round(output,2);
            textBox3.Text = output + "";
        }
    }
}
