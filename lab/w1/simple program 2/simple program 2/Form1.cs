using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, hasil;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            hasil = a * b;

            //label3.Text = hasil.ToString();
            label3.Text = Convert.ToString(hasil);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, hasil;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            hasil = a + b;

            //label3.Text = hasil.ToString();
            label3.Text = Convert.ToString(hasil);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, hasil;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            hasil = a - b;

            //label3.Text = hasil.ToString();
            label3.Text = Convert.ToString(hasil);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, hasil;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            hasil = a / b;

            //label3.Text = hasil.ToString();
            label3.Text = Convert.ToString(hasil);
        }
    }
}
