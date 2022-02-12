
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace school
{
    public class Person
    {
        public Person() { }
        private string kişiAdi;
        private string kişiSoyadi;
        private string kişiNo;

        public string KişiAdi { get => kişiAdi; set => kişiAdi = value; }
        public string KişiSoyAdi { get => kişiSoyadi; set => kişiSoyadi = value; }
        public string KişiNo { get => kişiNo; set => kişiNo = value; }
    }
}
