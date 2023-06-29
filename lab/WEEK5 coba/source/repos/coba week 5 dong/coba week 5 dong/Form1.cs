using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba_week_5_dong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_tambah();
        }

        public void p_tambah()
        {
            int hasil = Convert.ToInt16(textBox1.Text) + Convert.ToInt16(textBox2.Text);
            label1.Text = hasil.ToString();
        }

        public void p_tambah_parameter(int a, int b)
        {
            int hasil = a + b;
            label1.Text = hasil.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            p_tambah_parameter(a, b);
        }

        public string f_tambah()
        {
            int hasil = Convert.ToInt16(textBox1.Text) +Convert.ToInt16(textBox2.Text);
            return hasil.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = f_tambah();
        }


        public string f_tambah_parameter(int a, int b)
        {
            int hasil = a + b;
            return hasil.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            label1.Text = f_tambah_parameter(a, b);
        }

        public void byvalue( int c)
        {
            c *= c;
        }
        public void byref(ref int c)
        {
            c *= c;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int c = 2;
            MessageBox.Show("sebelum passing value is "+ c.ToString());
            byvalue(c);
            MessageBox.Show("setelah Passsing value iss " + c.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int c = 2;
            MessageBox.Show("sebelum passing ref is " + c.ToString());
            byref(ref c);
            MessageBox.Show("setelah Passsing ref iss " + c.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random vrandom = new Random();
            label1.Text = vrandom.Next(1, 4).ToString();
        }
    }
}
