using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1_test_w8
{
    public partial class fcustomer : Form
    {
        public fcustomer()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fcustomer_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("A");
            listBox1.Items.Add("B");
            listBox1.Items.Add("C");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(object vitem in listBox1.Items)
            {
                listBox2.Items.Add(vitem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (object vitem in listBox1.SelectedItems)
            {
                listBox2.Items.Add(vitem.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.Clear(); //clear semua item secar seluruh
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList arrays = new ArrayList();
            foreach(object vitem in listBox2.SelectedItems)
            {
                arrays.Add(vitem);
            }
            foreach(object vitem in  arrays.ToArray())
            {
                listBox2.Items.Remove(vitem);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fcustomer custom = new fcustomer();
            Application.Exit();
            //Close();
        }
    }
}
