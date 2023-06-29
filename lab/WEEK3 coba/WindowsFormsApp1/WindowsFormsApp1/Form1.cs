using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pesan panggilan = new pesan();
            panggilan.displaymessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesan panggilan = new pesan();
            panggilan.displaymessage("halo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pesan ID = new pesan();
            MessageBox.Show(" " + ID.namaDepan() + " " + ID.namaBelakang() + " " + ID.vurlwebsite);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pesan ID = new pesan();
            ID.webProperty = textBox1.Text;
            MessageBox.Show(ID.vurlwebsite);
        }
    }
}
