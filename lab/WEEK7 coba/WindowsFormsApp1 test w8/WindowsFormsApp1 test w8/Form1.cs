using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_test_w8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
        
        private void textBox1_Leave(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcustomer vform = new fcustomer();
            vform.Show();
            
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplies vform = new supplies();
            vform.Show();
        }
    }
}
