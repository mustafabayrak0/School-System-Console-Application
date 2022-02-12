using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{


    public class Users
    {


        public Users() { }
        private string kullaniciAdi;
        private string kullaniciSoyAdi;
        private string kullaniciNo;

        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string KullaniciSoyAdi { get => kullaniciSoyAdi; set => kullaniciSoyAdi = value; }
        public string KullaniciNo { get => kullaniciNo; set => kullaniciNo = value; }
    }

}
