using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Courses
    {
        public Courses() { }
        private string dersKodu;
        private string dersAdi;
        private int kredi;
        private char not;
        private int vizePuani;
        private int finalPuani;
        private Transcript dene;
        public string DersKodu { get => dersKodu; set => dersKodu = value; }
        public string DersAdi { get => dersAdi; set => dersAdi = value; }
        public int Kredi { get => kredi; set => kredi = value; }
        public char Not { get => not; set => not = value; }
        public int VizePuani { get => vizePuani; set => vizePuani = value; }
        public int FinalPuani { get => finalPuani; set => finalPuani = value; }
    }
}

