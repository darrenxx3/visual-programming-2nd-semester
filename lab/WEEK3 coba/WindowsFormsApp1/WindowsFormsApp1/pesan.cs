using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class pesan
    {
        private string vnamadepan = "Christopher";
        private string vnamabelakang = "Darren";

        public string vurlwebsite = "yahahahayuuu.com";

        public string namaDepan()
        {
            return vnamadepan;
        }

        public string namaBelakang()
        {
            return vnamabelakang;
        }

        public string webProperty
        {
            get{ return vurlwebsite;}
            set { vurlwebsite = value; }
        }







        public void displaymessage()
        {
            MessageBox.Show("You've been pranked");
        }

        public void displaymessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
