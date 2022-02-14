using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school;

namespace school
{
    class Deneme
    {
        static void Main(string[] args)
        {
            Users user1 = new Users();
            Courses course = new Courses();
            Roles role = new Roles();
            Academicians academicians = new Academicians();
            Student student = new Student();
            string input4 = "";
            string input5 = "";
            int input2 = 0;
            int updateInput = 0;
            int input = 0;
            List<Transcript> parts = new List<Transcript>();
            parts.Add(new Transcript("Mustafa", "Bayrak", 1, "", "Matematik", 20, 'A', 50, 60) { });
            parts.Add(new Transcript("Murat", "Altınışık", 2, "", "Fizik", 20, 'B', 40, 50) { });
            parts.Add(new Transcript("Zeynel", "Yılmaz", 3, "", "Biyoloji", 30, 'C', 40, 50) { });
            parts.Add(new Transcript("Abidin", "Ata", 4, "", "Kimya", 40, 'D', 40, 50) { });
            parts.Add(new Transcript("Veli", "Akay", 5, "", "Tarih", 50, 'F', 40, 50) { });
            Console.WriteLine("Sisteme hoşgeldiniz.Lütfen yapmak istediğniz işlemin numarasını tuşlayınız.");
        Begin:
            Console.WriteLine("1)Öğrenci ekle");
            Console.WriteLine("2)Öğrenci ara");
            Console.WriteLine("3)Öğrenci güncelle");
            Console.WriteLine("4)Çıkış yap");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("Öğrenci ismi:");
                input4 = Console.ReadLine();
                Console.Write("Öğrenci soy ismi:");
                input5 = Console.ReadLine();
                void AddStudent()
                {
                    parts.Add(new Transcript(input4, input5, parts.Count + 1, "", "", 50, 'A', 40, 50) { });
                }
                AddStudent();
                Console.Clear();
                goto Begin;
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Aradığınız öğrencinin numarasını tuşlayınız");
                for (int i = 0; i < parts.Count; i++)
                {
                    Console.WriteLine($"{parts[i].studentInfo.OgrenciNo}){parts[i].studentInfo.Isim}");
                }
                input2 = Convert.ToInt32(Console.ReadLine());
                void ShowMethod()
                {

                    Console.Clear(); Console.WriteLine("Adı:" + parts[input2 - 1].studentInfo.Isim + "\nSoy Adı:" + parts[input2 - 1].studentInfo.SoyIsim + "\nÖğrenci No:" + parts[input2 - 1].studentInfo.OgrenciNo + "\nDers Adı:" + parts[input2 - 1].crsInfo.DersAdi + "\nVize Puanı:" + parts[input2 - 1].crsInfo.VizePuani + "\nFinal Puanı:" + parts[input2 - 1].crsInfo.FinalPuani + "\nNot:" + parts[input2 - 1].crsInfo.Not);
                }
                ShowMethod();
                goto Begin;
            }
            else if (input == 3)
            {
                Console.WriteLine("Güncellemek istedğiniz öğrencinin numarasını tuşlayınız");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            else if (input == 4) { Console.WriteLine("Çıkış yapıldı."); goto End; }
        End:
            Console.WriteLine();
        }
    }
}
