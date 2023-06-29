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
using System.Data.SqlClient;

namespace _00000054804_Christopher_Darren_week14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataClasses1DataContext DB = new DataClasses1DataContext();//get data from database
        private void button1_Click(object sender, EventArgs e)//nampilan data dari SQL 
        {
            var abc = from x in DB.pelanggans select x;
            dataGridView1.DataSource = abc;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//button buat Nampilin Crystal report
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)//buat generate ke.txt
        {
            try
            {
                string filename;

                using (SaveFileDialog save = new SaveFileDialog())//untuk save ke direktori mana entar akan dicetak
                {
                    save.Filter = "Text Document | *.txt";
                    save.AddExtension = true;
                    //save.DefaultExt = ".aload";
                    save.DefaultExt = ".txt";
                    save.ShowDialog();

                    filename = save.FileName;
                }

                if(dataGridView1.DataSource != null)
                {
                    int coulumcount = dataGridView1.Columns.Count;
                    int rowcount = dataGridView1.Rows.Count;

                    TextWriter text = new StreamWriter(filename);
                    for(int i = 0; i < rowcount -1; i++)
                    {
                        for(int j =0; j < coulumcount; j++)
                        {
                            text.Write(" " + dataGridView1.Rows[i].Cells[j].Value.ToString() + " " + " | ");
                        }
                        text.WriteLine("");
                        text.WriteLine("-----------------------------------------------");

                    }
                    text.Close();
                    MessageBox.Show("Data has been input");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}