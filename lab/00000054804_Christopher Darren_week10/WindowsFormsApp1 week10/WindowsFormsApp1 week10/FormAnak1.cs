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


namespace WindowsFormsApp1_week10
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
            label2.Text = Form1.SetValueFortextBox1;
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            DS.Clear();
            vquery = "select * from MstDosen where KdDosen like '%" + label2.Text + "%'";
            SqlDataAdapter DA = new SqlDataAdapter(vquery, conn);
            DA.Fill(DS, "dosen");
            dataGridView1.DataSource = DS.Tables["dosen"];
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //form.textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString;
                 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

