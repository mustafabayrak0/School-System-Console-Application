using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Student
    {

        private string isim;
        private string soyIsim;
        private int ogrenciNo;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    }

}
