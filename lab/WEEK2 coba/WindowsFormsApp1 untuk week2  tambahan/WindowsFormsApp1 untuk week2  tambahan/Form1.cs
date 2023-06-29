using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_untuk_week2__tambahan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai = Convert.ToInt16(textBox1.Text);
            switch (nilai)
            {
                case 1:
                    MessageBox.Show("Hari Senin");
                    break;

                case 2:
                    MessageBox.Show("Hari Selasa");
                    break;

                case 3:
                    MessageBox.Show("Hari Rabu");
                    break;

                case 4:
                    MessageBox.Show("Hari Kamis");
                    break;

                case 5:
                    MessageBox.Show("Hari Jumat");
                    break;

                case 6:
                    MessageBox.Show("Hari Sabtu");
                    break;

                case 7:
                    MessageBox.Show("Hari Minggu");
                    break;

                default:// yaitu tidak ada range yang sedang dipilih maka akan masuk false
                    MessageBox.Show("Tidak ada pilihan");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
