using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school;
namespace school
{
    class Program
    {
        static void Main(string[] args)
        {
            new String(' ', 10);
            string str = new string(' ', 32);
            Student student = new Student();
            string input4 = "";
            string input5 = "";
            int input2 = 0;
            int updateInput = 0;
            int input = 0;
            List<Transcript> parts = new List<Transcript>();
            parts.Add(new Transcript("Mustafa", "Bayrak", 1, 'A', 'A', 'A', 'A', 'A') { });
            parts.Add(new Transcript("Murat", "Altınışık", 2, 'A', 'A', 'A', 'A', 'A') { });
            parts.Add(new Transcript("Zeynel", "Yılmaz", 3, 'A', 'A', 'A', 'A', 'A') { });
            parts.Add(new Transcript("Abidin", "Ata", 4, 'A', 'A', 'A', 'A', 'A') { });
            parts.Add(new Transcript("Veli", "Akay", 5, 'A', 'A', 'A', 'A', 'A') { });
            string[] lectures = { "Matematik", "Fizik", "Bilgisayara giriş", "İngilizce", "Lineer Cebir" };

            void ShowMethod()
            {
                Console.Clear(); Console.Write("Adı:" + parts[input2 - 1].studentInfo.Isim + "\nSoy Adı:" + parts[input2 - 1].studentInfo.SoyIsim + "\nÖğrenci No:" + parts[input2 - 1].studentInfo.OgrenciNo + "\nDers Adı:\n");
            }
            void CourseShow()
            {
                Console.WriteLine(lectures[0] + ":" + parts[input2 - 1].crsInfo.Not1 + "\n" + lectures[1] + ":" + parts[input2 - 1].crsInfo.Not2 + "\n" + lectures[2] + ":" + parts[input2 - 1].crsInfo.Not3 + "\n" + lectures[3] + ":" + parts[input2 - 1].crsInfo.Not4 + "\n" + lectures[4] + ":" + parts[input2 - 1].crsInfo.Not5);
            }
            
            Console.WriteLine("Sisteme hoşgeldiniz.Lütfen yapmak istediğniz işlemin numarasını tuşlayınız.");
        Begin:
            Console.WriteLine("1)Öğrenci ekle");
            Console.WriteLine("2)Öğrenci ara");
            Console.WriteLine("3)Öğrenci güncelle");
            Console.WriteLine("4)Çıkış yap");
            input = Convert.ToInt32(Console.ReadLine());
            void UpdateMethod()
            {
                Console.Write("\nYeni Ad:"); string updateInput1 = Console.ReadLine();
                Console.Write("Yeni Soy Ad:"); string updateInput2 = Console.ReadLine();
                Console.Write("Yeni Matematik Notu:"); char updateInput3 = Convert.ToChar(Console.ReadLine());
                Console.Write("Yeni Fizik Notu:"); char updateInput4 = Convert.ToChar(Console.ReadLine());
                Console.Write("Yeni Bilgisayara Giriş Notu:"); char updateInput5 = Convert.ToChar(Console.ReadLine());
                Console.Write("Yeni İngilizce Notu:"); char updateInput6 = Convert.ToChar(Console.ReadLine());
                Console.Write("Yeni Lineer Cebir Notu:"); char updateInput7 = Convert.ToChar(Console.ReadLine());
                parts[input2 - 1].studentInfo.Isim = updateInput1;
                parts[input2 - 1].studentInfo.SoyIsim = updateInput2;
                parts[input2 - 1].crsInfo.Not1 = updateInput3;
                parts[input2 - 1].crsInfo.Not2 = updateInput4;
                parts[input2 - 1].crsInfo.Not3 = updateInput5;
                parts[input2 - 1].crsInfo.Not4 = updateInput6;
                parts[input2 - 1].crsInfo.Not5 = updateInput7;
                Console.Clear();
                Console.WriteLine("Güncelleme başarılı.Ana menüye yönlendiriliyorsunuz...");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            }
            if (input == 1)
            {
                Console.Write("Öğrenci ismi:");
                input4 = Console.ReadLine();
                Console.Write("Öğrenci soy ismi:");
                input5 = Console.ReadLine();
                void AddStudent()
                {
                    parts.Add(new Transcript(input4, input5, parts.Count + 1, 'A', 'A', 'A', 'A', 'A') { });
                }

                AddStudent();
                Console.Clear();
                Console.WriteLine("Yapmak istediğiniz işlemi tuşlayınız.");
                goto Begin;
            }
            else if (input == 2)
            {
                Console.Clear();
            SearchPoint:
                Console.WriteLine("Aradığınız öğrencinin numarasını tuşlayınız");
                for (int i = 0; i < parts.Count; i++)
                {
                    Console.WriteLine($"{parts[i].studentInfo.OgrenciNo}){parts[i].studentInfo.Isim}");
                }
                input2 = Convert.ToInt32(Console.ReadLine());


                if (input2 < parts.Count + 1 && input2 > 0)
                { ShowMethod(); CourseShow(); }
                else
                {
                    Console.WriteLine("Hatalı tuşlama.Yeniden deneyiniz.");
                    goto SearchPoint;
                }
                Console.WriteLine("Ana menüye dönmek istiyorsanız 1'e,çıkış yapmak istiyorsanız 2'ye basınız.");
                int afterShow = Convert.ToInt32(Console.ReadLine());
                if (afterShow == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Yapmak istediğiniz işlemi tuşlayınız.");
                    goto Begin;
                }

                else if (afterShow == 2)
                {
                    Console.WriteLine("Çıkış yapıldı.");
                    goto End;
                }
            }

            else if (input == 3)
            {
                Console.Clear();
                Console.WriteLine("Admin parolasını giriniz");
                Console.Write("Parola:");
                int adminpswd = Convert.ToInt32(Console.ReadLine());
                if (adminpswd == 123)
                {
                    Console.Clear();
                    Console.WriteLine("Admin girişi başarılı");
                    for (int i = 0; i < parts.Count; i++)
                    {
                        Console.WriteLine($"{parts[i].studentInfo.OgrenciNo}){parts[i].studentInfo.Isim}");
                    }
                    Console.WriteLine("Güncellemek istedğiniz öğrencinin numarasını tuşlayınız");
                    input2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    ShowMethod();
                    CourseShow();
                    UpdateMethod();
                    goto Begin;
                }
                else { Console.WriteLine("Hatalı tuşlama"); goto Begin; }
            }
            else if (input == 4) { Console.WriteLine("Çıkış yapıldı."); goto End; }
        End:
            Console.WriteLine();
        }
    }
}

