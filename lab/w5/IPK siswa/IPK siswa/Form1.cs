using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPK_siswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nilai mhs = new Nilai();
            mhs.tugasS = Convert.ToDouble(textBox3.Text);
            mhs.utsS = Convert.ToDouble(textBox4.Text);
            mhs.uasS = Convert.ToDouble(textBox5.Text);

            textBox6.Text = Convert.ToString(mhs.Calculate());
            textBox6.Text = Convert.ToString(mhs.IndeksNILAI());

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nilai mhs = new Nilai();
            mhs.tugasS = Convert.ToDouble(textBox9.Text);
            mhs.utsS = Convert.ToDouble(textBox10.Text);
            mhs.uasS = Convert.ToDouble(textBox11.Text);

            textBox12.Text = Convert.ToString(mhs.Calculate());
            textBox12.Text = Convert.ToString(mhs.IndeksNILAI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nilai mhs = new Nilai();

            mhs.avg = Convert.ToDouble(textBox13.Text);
            textBox13.Text = Convert.ToString(mhs.ngitungAVG());
            textBox13.Text = Convert.ToString(mhs.AVERAGE());
            
        }
    }
}
