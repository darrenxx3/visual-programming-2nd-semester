using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Advanced_crystal_report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=LAPTOP-ADU8799N\\SQLEXPRESS; Initial Catalog = visprogw10; Integrated Security = True;");
        SqlCommand cmd;
        SqlDataAdapter sda;
        string date1;
        string date2;

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

            private void button1_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "-" + dateTimePicker1.Value.Year;
            date2 = dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day + "-" + dateTimePicker2.Value.Year;
            sql.Open();

            DataTable dt = new DataTable();
            cmd = new SqlCommand("select * from Teman where ulang_tahun between '"+ date1 + "' and '"+ date2 + "'",sql);
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            CrystalReport1 CR = new CrystalReport1();
            CR.Database.Tables["Teman"].SetDataSource(dt);
            Form2 form = new Form2();
            form.Show();
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formula;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";

            formula = "{ Teman.ulang_tahun} >=#" + dateTimePicker1.Value + "#" + "and {Teman.ulang_tahun} <=#" + dateTimePicker2.Value +"#";
            CrystalReport1 CR = new CrystalReport1();
            Form3 form = new Form3();
            form.Show();
            
        }

      

        }
    }

