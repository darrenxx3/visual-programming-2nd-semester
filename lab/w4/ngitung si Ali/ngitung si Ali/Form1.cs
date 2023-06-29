using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngitung_si_Ali
{
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();
        }
        private object count;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int konsumsi, transportasi, akomodasi, komunikasi, kuliah, buku_pel, semester;
            double total;
            string popup, temp;

            semester = Convert.ToInt32(textBox2.Text);
            konsumsi = Convert.ToInt32(textBox3.Text);
            transportasi = Convert.ToInt32(textBox4.Text);
            akomodasi = Convert.ToInt32(textBox5.Text);
            komunikasi = Convert.ToInt32(textBox6.Text);
            kuliah = Convert.ToInt32(textBox7.Text);
            buku_pel = Convert.ToInt32(textBox8.Text);
            total = count.hitung(konsumsi, transportasi, akomodasi, komunikasi, kuliah,buku_pel, semester);
            temp = string.Format("{0:n}", total);

            if(semester < 7 || semester > 14)
            {
                MessageBox.Show("Pastikan Kamu Berkuliah di Semester 7 dan Tidak lebih dari 14 Semesterr");
            }
            else
            {
                popup = Convert.ToString("Halo," + textBox1.Text + "Biaya yang akan kamu keluarkan untuk kuliah selama " + semester );
                count.display(popup);
            }
        }
    }
    }

