using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_for_looping
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int angka = 0; angka < 10; angka++)
            {
                Console.WriteLine(angka);
            }
            Console.ReadKey();*/

            /*byte angka_awal, angka_akhir, angka;

            //input
            Console.Write("Masukkan Angka Awal: ");
            angka_awal = Convert.ToByte(Console.ReadLine());
            Console.Write("Masukkan Angka Akhir: ");
            angka_akhir = Convert.ToByte(Console.ReadLine());

            //proses
            for (angka = angka_awal; angka <= angka_akhir; angka++)
            {
                if (angka % 2 != 0)
                {
                    Console.WriteLine("angka {0} adalah bilangan ganjil", angka);
                }
                else
                {
                    Console.WriteLine("angka {0} adalah bilangan genap", angka);
                }
                Console.ReadKey();*/

            /*int angka = 0;
            while (angka < 10)
            {
                Console.WriteLine(angka);
                angka++;
            }
            Console.ReadKey();*/

            /*int angka = 0;
            do
            {
                Console.WriteLine(angka);
                angka++;
            } while (angka < 10);
            Console.ReadKey();*/


            /*int angka = 0;
            do
            {
                Console.WriteLine(angka);
                if (angka == 2)//cuma angka 2
                {
                    break;//fungsi break
                }
                angka++;
            } while (angka < 10);
            Console.ReadKey();*/


            /*int angka = 0;
            do
            {
                Console.WriteLine(angka);
                if (angka == 2)
                {
                    goto cetak;
                }
                angka++;
            } while (angka < 10);

        cetak:
            Console.WriteLine("contoh goto");
            Console.ReadKey();*/

            for(int angka = 0; angka < 10; angka++)
            {
                if(angka %2 == 1)
                {
                    continue;
                }
                Console.WriteLine(angka);
            }
            Console.ReadKey();  
            }
        }
    }


        