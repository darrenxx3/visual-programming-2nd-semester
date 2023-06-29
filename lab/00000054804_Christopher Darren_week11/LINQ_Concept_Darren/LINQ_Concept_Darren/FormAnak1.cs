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

namespace LINQ_Concept_Darren
{
    public partial class FormAnak1 : Form
    {
        string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
        DataSet DS = new DataSet();
        string vquery = "";

        public FormAnak1()
        {
            InitializeComponent();
        }

       
        private void FormAnak1_Load(object sender, EventArgs e)
        {
           

        }


        DataClasses1DataContext DB = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            //form.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //form.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //form.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //form.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //form.ShowDialog();


            DataClasses1DataContext DB = new DataClasses1DataContext();
            var query = (from x in DB.MstPelanggans select x).ToList();
            dataGridView1.DataSource = query;


            //var query = (from x in DB.MstPelanggans select x).ToList();
            // DataTable DT = new DataTable();
            //dataGridView1.DataSource = query;
            // foreach (DataRow item in DT.Rows)
            {
            //    int n = dataGridView1.Rows.Add();
            //    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();

            }
            
               
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from MstPelanggan where Nama like '%" + textBox1.Text + "%'";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "pelanggan");
            dataGridView1.DataSource = DS.Tables["pelanggan"];
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 form = new Form1();
            form.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.textBox3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            form.textBox4.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            form.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
