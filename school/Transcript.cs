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



        public Transcript(string OgrIsim, string OgrSoyIsim, int OgrNo, char CrsNot1, char CrsNot2, char CrsNot3, char CrsNot4, char CrsNot5)
        {
            studentInfo.Isim = OgrIsim;
            studentInfo.SoyIsim = OgrSoyIsim;
            studentInfo.OgrenciNo = OgrNo;
            crsInfo.Not1 = CrsNot1;
            crsInfo.Not2 = CrsNot2;
            crsInfo.Not3 = CrsNot3;
            crsInfo.Not4 = CrsNot4;
            crsInfo.Not5 = CrsNot5;
        }
    }
}

