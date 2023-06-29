using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngitung_si_Ali
{
    class Hitung
    {
        //supaya bisa ke input maka dibuat lah class
        double total;
        public double hitung(int konsumsi, int transportasi, int akomodasi, 
            int komunikasi, int kuliah, int buku_pel, int semester)
        {
            konsumsi = konsumsi * 30 * 6 * semester;
            transportasi = transportasi * 26 * semester;
            akomodasi = akomodasi * 6 * semester;
            komunikasi = komunikasi * 6 * semester;
            kuliah = kuliah * semester;
            buku_pel = buku_pel * semester;
            total = konsumsi + transportasi + akomodasi + komunikasi + kuliah + buku_pel + semester;
            return total;
        }
        public void display(string popup)
        {
            MessageBox.Show(popup, " --");
        }
    }
}
