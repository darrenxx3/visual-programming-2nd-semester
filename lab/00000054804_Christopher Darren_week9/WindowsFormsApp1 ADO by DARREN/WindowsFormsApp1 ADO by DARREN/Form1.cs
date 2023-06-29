using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1_ADO_by_DARREN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Lihat Data");
            comboBox1.Items.Add("Lihat Data -DENGAN DATASET");
            comboBox1.Items.Add("Lihat Data -DENGAN DATAREADER");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string vconstring = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = D:\\UMN Sistem informasi 2021 - 2022\\SEMESTER 2\visual programming\\lab\00000054804_Christopher Darren_week9\\Database1.accdb";
            OleDbConnection conn = new OleDbConnection(vconstring);
            conn.Open();
            MessageBox.Show("Berhasil Konek Database");
            conn.Close();
        }
    }
}
