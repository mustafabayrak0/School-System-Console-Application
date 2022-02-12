using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Academicians
    {
        public Academicians() { }
        private string akademisyenAdi;
        private string akademisyenSoyAdi;
        private string akademisyenNo;

        public string AkademisyenAdi { get => akademisyenAdi; set => akademisyenAdi = value; }
        public string AkademisyenSoyAdi { get => akademisyenSoyAdi; set => akademisyenSoyAdi = value; }
        public string AkademisyenNo { get => akademisyenNo; set => akademisyenNo = value; }
    }
}