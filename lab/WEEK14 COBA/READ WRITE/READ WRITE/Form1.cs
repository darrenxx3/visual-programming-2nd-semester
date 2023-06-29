using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace READ_WRITE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static string BACA()
        {
            FileStream fs = new FileStream("D:\\UMN Sistem informasi 2021 - 2022\\SEMESTER 2\visual programming\\lab", FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            return (sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        static void TULIS(string kata)
        {
            FileStream fs = new FileStream("D:\\UMN Sistem informasi 2021 - 2022\\SEMESTER 2\visual programming\\lab", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(kata);
            sw.Close();
            fs.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TULIS(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = BACA();
        }
    }
}
