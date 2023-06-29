using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double result, angka, angka2, angkaresult;

            angka = Convert.ToDouble(textBox1.Text);

            result = angka;
            angkaresult = angka;
            angka = angka - 1;
            while (angka > 0)
            {
                angka2 = result;
                result = result * angka;
                textBox2.Text += angka2 + " * " + angka + " = " + result + "\r\n";
                angka = angka - 1;
            }

            textBox2.Text += "\r\nHasil Faktorial dari " + angkaresult + " adalah " + result+ "\r\n";

           
        }
    }
}
