using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week_3_hitung_dan_tombol_advance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string jenis = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                int angka1 = int.Parse(textBox1.Text);
                int angka2 = int.Parse(textBox2.Text);
                if(jenis == "persegi panjang")
                {
                    persegi_panjang luas = new persegi_panjang();
                    textBox3.Text = luas.week_3_hitung_dan_tombol_advance(angka1, angka2).ToString();

                }
                else if(jenis == "Segitiga")
                {
                    Segitiga luas = new Segitiga();
                    textBox3.Text = luas.week_3_hitung_dan_tombol_advance(angka1, angka2).ToString();
                }
                else if(jenis == "Jajar genjang")
                {
                    Jajar_genjang luas = new Jajar_genjang();
                    textBox3.Text = luas.week_3_hitung_dan_tombol_advance(angka1, angka2).ToString();
                }
                else
                {
                    MessageBox.Show("Pilihlah perhitungan yang kamu mau");
                }
            }
            else
            {
                MessageBox.Show("Mohon diisi " + label1.Text + " dan " + label2.Text + "!!!!");
            }
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jenis = "persegi panjang";
            label1.Text = "Panjang";
            label2.Text = "Lebar";
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jenis = "Jajar genjang";
            label1.Text = "Alas";
            label2.Text = "Tinggi";
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jenis = "Segitiga";
            label1.Text = "Alas";
            label2.Text = "Tinggi";
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
