using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace proses_tombol_array
{
    public partial class Form1 : Form
    {

        public String histograM;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mendeklarasi int
            int a = Convert.ToInt32(textBox1.Text);//di textbox1 kita masukkan angka yang kita mau
            int[] array = new int[a];
            int sumnum = 0;
            for(int x = 0; x < a; x++)
            {
                String pesan, judul, defaultvalue;
                String myvalue;
                pesan = "Masukkan nilai elemen array" + (x + 1) + "?";//munculin windows form baru di dalam windows form
                judul = "WindowsApplication1";
                defaultvalue = "0";
                myvalue = Interaction.InputBox(pesan, judul, defaultvalue, 100, 100);
                array[x] = Convert.ToInt32(myvalue);//merubah nilai yg ada di array

                sumnum += array[x];
            }
            textBox2.Text = "Index\tValue" + Environment.NewLine;
            for(int x = 0; x < a; x++)
            {
                textBox2.Text += (x + 1) + "\t" + array[x] + Environment.NewLine;
            }
            textBox3.Text = Convert.ToString(sumnum);

            double avg = sumnum / a;
            textBox4.Text = Convert.ToString(avg);
            textBox5.Text = "Element\tValue\tHistogram" + Environment.NewLine;
            for(int x = 0; x < a; x++)
            {
                for(int y = 0; y < array[x]; y++)
                {
                    histograM += "*";// hasil inputan akan kecatat dalam bentuk *
                }
                textBox5.Text += (x + 1) + "\t" + array[x] + "\t" + histograM + Environment.NewLine;
                histograM = "";
            }
        }
    }
}
