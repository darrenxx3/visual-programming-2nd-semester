using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPK_siswa
{
    class Nilai
    {
        private double tugas;
        private double uts;
        private double uas;
        private string nilaihuruf;  /*kalau error pake char*/
        private double nilaiakhir;
        private double nilairatarata;
       

        public double tugasS
        {
            get { return tugas; }
            set { tugas = value; }
        }

        public double utsS
        {
            get { return uts; }
            set { uts = value; }
        }

        public double uasS
        {
            get { return uas; }
            set { uas = value; }
        }

        public double na
        {
            get { return nilaiakhir; }
            set { nilaiakhir = value; }
        }

        public string indekshuruf /*kalau error pake char*/
        {
            get { return nilaihuruf; }
            set { nilaihuruf = value; }
        }

        public double avg
        {
            get { return nilairatarata; }
            set { nilairatarata = value; }
        }
        //buat method ngitung nilai akhir

        public double Calculate()
        {
            na = (tugas * 0.20) + (uts * 0.30) + (uas * 0.40);
            return na;
        }

        public double ngitungAVG()
        {
            avg = (tugas * 0.20) + (uts * 0.30) + (uas * 0.40);
            return avg;
        }
        public double AVERAGE()
        {
            avg = nilairatarata / 2;
            return avg;
        }

        /*mohon maaf pak untuk input rata rata saya tidak paham , sudah saya coba
         tetap saja hasilnya 0*/
        
        public string IndeksNILAI() /*kalau error pake char */
        {
            if(na >= 85 && na <= 100)
            {
                indekshuruf = "A";
            }
            else if (na >=80 && na <= 84.99) 
            {
                indekshuruf = "A-" ;
            }
            else if (na >= 75 && na <= 79.99)
            {
                indekshuruf = "B+";
            }
            else if (na >= 70 && na <= 74.99)
            {
                indekshuruf = "B";
            }
            else if (na >= 65 && na <= 79.99)
            {
                indekshuruf = "B-";
            }
            else if (na >= 60 && na <= 64.99)
            {
                indekshuruf = "C+";
            }
            else if (na >= 55 && na <= 59.99)
            {
                indekshuruf = "C";
            }
            else if (na >= 45 && na <= 54.99)
            {
                indekshuruf = "D";
            }
            else if (na >= 0 && na <= 44.99)
            {
                indekshuruf = "E";
            }
            else
            {
                indekshuruf = "F";
            }
            return indekshuruf;
        }
    }
}
