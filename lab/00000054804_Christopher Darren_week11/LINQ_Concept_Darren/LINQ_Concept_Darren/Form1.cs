using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Concept_Darren
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//insert data menuju database.
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            MstPelanggan pelanggan = new MstPelanggan
            {
                KodePelanggan = textBox1.Text,
                Nama = textBox2.Text,
                Alamat = textBox3.Text,
                Umur = textBox4.Text
            };
            DB.MstPelanggans.InsertOnSubmit(pelanggan);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Successfully saved data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)//update data yang sudah ada di database
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var ubah = (from a in DB.MstPelanggans
                        where a.KodePelanggan == textBox1.Text
                        select a).Single();
            ubah.Nama = textBox2.Text;
            ubah.Alamat = textBox3.Text;
            ubah.Umur = textBox4.Text;
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("Successfully changed data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)//delete data yang ada di database kemudian ditampilkan di data gridview
        {
            DataClasses1DataContext DB = new DataClasses1DataContext();
            var delete = (from a in DB.MstPelanggans
                          where a.KodePelanggan == textBox1.Text.ToString()
                          select a).Single();
            DB.MstPelanggans.DeleteOnSubmit(delete);
            try
            {
                DB.SubmitChanges();
                MessageBox.Show("delete using linq sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAnak1 form = new FormAnak1(); //buat nampilin form ke dua
            form.Show();
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}