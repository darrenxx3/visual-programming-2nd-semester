using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConsoleApp2_net_frame
{
    class Program
    {
        static void Main(string[] args)
        {
         //Console.Write("Masukkan Angka Awal : ");
         //Console.Write("test");
         //Console.ReadKey();
            MessageBox.Show("test");
            Console.ReadKey();
            int angka = 0;
            if (angka % 2 == 1)
            {
                Console.Write("Bilangan Genap");
            }
            else if (angka %2 == 1)
            {
                Console.WriteLine("Bilangan Ganjil");
            }
            else
            {
                Console.WriteLine("Anda tidak memasukkan angka! ");
            }
        }
    }
}
