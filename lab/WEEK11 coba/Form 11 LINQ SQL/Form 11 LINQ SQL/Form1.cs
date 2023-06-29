using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_11_LINQ_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            tblmh mhs = new tblmh
            {
                nim = textBox1.Text,
                nama = textBox2.Text,
            };
            db.tblmhs.InsertOnSubmit(mhs);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Insert using LINQ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var ubah = (from a in db.tblmhs
                        where a.nim == textBox1.Text
                        select a).Single();
            ubah.nama = textBox2.Text;
            try
            {
                db.SubmitChanges();
                MessageBox.Show("update using LINQ sukses");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var delete = (from a in db.tblmhs
                          where a.nim == textBox1.Text.ToString()
                          select a).Single();
            db.tblmhs.DeleteOnSubmit(delete);
            try
            {
                db.SubmitChanges();
                MessageBox.Show("delete using linq sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
