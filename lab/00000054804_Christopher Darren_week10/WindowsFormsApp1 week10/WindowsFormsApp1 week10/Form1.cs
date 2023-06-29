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
    public partial class Form1 : Form
    {
        public string textbox
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button5.Text = "...";

            

            
        }

        //exit button at button4
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //button insert
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand insert = new SqlCommand("Insert into MstDosen(KdDosen,NaDosen, Alamat, Notelp, NoHp) values(@KdDosen,@NaDosen, @Alamat, @Notelp ,@NoHp)", con);
            insert.Parameters.AddWithValue("@KdDosen", textBox1.Text);
            insert.Parameters.AddWithValue("@NaDosen", textBox2.Text);
            insert.Parameters.AddWithValue("@Alamat", textBox3.Text);
            insert.Parameters.AddWithValue("@Notelp", textBox4.Text);
            insert.Parameters.AddWithValue("@NoHp", textBox5.Text);

            try
            {
                con.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Successfully insert your data, you can close the window");
            }
            catch
            {
                MessageBox.Show("Error, try again");
            }
            finally
            {
                con.Close();
            }
        }


        //button 2 update
        private void button2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand update = new SqlCommand("update  MstDosen set NaDosen = @NaDosen where KdDosen = @KdDosen", con);
            //update.Parameters.AddWithValue("@KdDosen", textBox1.Text);
            update.Parameters.AddWithValue("@NaDosen", textBox2.Text);

            try
            {
                con.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Successfully update your data, you can close the window");
            }
            catch
            {
                MessageBox.Show("Error, Can't Update :( ");
            }
            finally
            {
                con.Close();
            }
        }


        //button 3 delete
        private void button3_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand delete = new SqlCommand("delete MstDosen where KdDosen = @KdDosen", con);
            delete.Parameters.AddWithValue("@KdDosen", textBox1.Text);

            try
            {
                con.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Successfully delete your data, you can close the window");
            }
            catch
            {
                MessageBox.Show("Error, Can't Delete :( ");
            }
            finally
            {
                con.Close();
            }
        }


        public static string SetValueFortextBox1 = ""; 
        public void textBox1_Leave(object sender, EventArgs e)

        {
            string constring = "Data Source=LAPTOP-ADU8799N\\SQLEXPRESS;Initial Catalog=visprogw10;Integrated Security= True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand select = new SqlCommand("select NaDosen, Alamat, Notelp, NoHp FROM MstDosen");

            try
            {
                con.Open();
                SetValueFortextBox1 = textBox1.Text;
                FormAnak1 form = new FormAnak1();
                form.Show();
                
            }
            catch
            {
                MessageBox.Show("Not found, please insert your new data");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
