using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Transcript
    {
        public Courses crsInfo = new Courses();
        public Student studentInfo = new Student();



        public Transcript(string OgrIsim, string OgrSoyIsim, int OgrNo, string CrsKodu, string CrsAdi, int CrsKredi, char CrsNot, int CrsVizePuani, int CrsFinalPuani)
        {
            studentInfo.Isim = OgrIsim;
            crsInfo.FinalPuani = CrsFinalPuani;
            crsInfo.VizePuani = CrsVizePuani;
            crsInfo.Not = CrsNot;
            crsInfo.Kredi = CrsKredi;
            crsInfo.DersAdi = CrsAdi;
            crsInfo.DersKodu = CrsKodu;
            studentInfo.OgrenciNo = OgrNo;
            studentInfo.SoyIsim = OgrSoyIsim;
            studentInfo.Isim = OgrIsim;
        }
    }
}

