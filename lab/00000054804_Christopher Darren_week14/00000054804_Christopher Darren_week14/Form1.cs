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

namespace _00000054804_Christopher_Darren_week14
{
    public partial class Form1 : Form
    {

        string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
        DataSet DS = new DataSet();
        string vquery = "";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "id_pelanggan";
            dataGridView1.Columns[1].Name = "nama_pelanggan";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

 
        }

        //DataClasses1DataContext DB = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
          

            String[] add = { textBox1.Text, textBox2.Text };
            dataGridView1.Rows.Add(add);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            textBox2.Focus();
        }

        DataClasses1DataContext DB = new DataClasses1DataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            string id; 
            string namapelanggan = "";
            for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
            {
                id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                namapelanggan = dataGridView1.Rows[i].Cells[1].Value.ToString();

                var abc = new pelanggan
                {
                    id_pelanggan = id,
                    nama_pelanggan = namapelanggan
                };
                DB.pelanggans.InsertOnSubmit(abc);

                try
                {
                    DB.SubmitChanges();
                    MessageBox.Show("Successfully added to DB");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        void loadData()
        {
            var abc = from x in DB.pelanggans select x;
            dataGridView1.DataSource = abc;
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
