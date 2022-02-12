using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using school;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Sisteme hoşgeldiniz.Lütfen yapmak istediğniz işlemin numarasını tuşlayınız.");
        string input4 = "";
        string input5 = "";
    //var parts = new List<Transcript>();
    StartPoint:
        Console.WriteLine("1)Öğrenci ekle");
        Console.WriteLine("2)Öğrenci ara");
        Console.WriteLine("3)Öğrenci güncelle");
        Console.WriteLine("4)Çıkış yap");
        int input = Convert.ToInt32(Console.ReadLine());
        int input2 = 0;
        int updateInput = 0;
        Random randomNumber = new Random();
        int randNumb1 = randomNumber.Next(0, 100);
        int randNumb2 = randomNumber.Next(0, 100);
        int randNumb3 = randomNumber.Next(0, 100);
        int randNumb4 = randomNumber.Next(0, 100);
        int randNumb5 = randomNumber.Next(0, 100);
        int randNumb6 = randomNumber.Next(0, 100);
        int randNumb7 = randomNumber.Next(0, 100);
        int randNum8 = randomNumber.Next(0, 100);
        int randNum9 = randomNumber.Next(0, 100);
        int randNum10 = randomNumber.Next(0, 100);

        if (input == 1)
        {
            Console.Write("Öğrenci ismi:");
            input4 = Console.ReadLine();
            Console.Write("Öğrenci soy ismi:");
            input5 = Console.ReadLine();
            Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
            goto StartPoint;
        }
        else if (input == 2)
        {
        TryAgain:
            Console.WriteLine("Aradığınız öğrencinin numarasını tuşlayınız");
            Console.Write($"1)Mustafa,2)Murat,3)Zeynel,4)Abidin,5)Veli");
            if (input4 != "") { Console.WriteLine($",6){input4}"); }
            else { Console.WriteLine(""); }
            input2 = Convert.ToInt32(Console.ReadLine());
            if (0 < input2) { goto ListPoint; }
            else { Console.Clear(); Console.WriteLine("Hatalı tuşlama yeniden deneyiniz"); goto TryAgain; }
        }
        else if (input == 3)
        {
            Console.WriteLine("Güncellemek istedğiniz öğrencinin numarasını tuşlayınız");
            input2 = Convert.ToInt32(Console.ReadLine());
            if (input2 == 1 || input2 == 2 || input2 == 3 || input2 == 4 || input2 == 5 || input2 == 6)
            {
                Console.WriteLine("1)İsim,2)Soy İsim,3)Ogrenci No,4)Vize Puanı,5)Final Puanı,6)Not");
                updateInput = Convert.ToInt32(Console.ReadLine());
                if (input2 == 1) { }
                goto Met;
            }

            else { Console.Clear(); Console.WriteLine("Hatalı tuşlama yeniden deneyiniz"); goto End; }

        }
        else if (input == 4) { Console.WriteLine("Çıkış yapıldı."); goto End; }
        else { Console.Clear(); Console.WriteLine("Hatalı tuşlama.Yeniden deneyiniz."); goto StartPoint; }


        Users user1 = new Users();
        Courses course = new Courses();
        Roles role = new Roles();
        Academicians academicians = new Academicians();
        Student student = new Student();
    ListPoint:


        List<Transcript> parts = new List<Transcript>();
        
        parts.Add(new Transcript("Mustafa", "Bayrak", 1, "", "Matematik", 20, 'A', randNumb1, randNumb1) { });
        parts.Add(new Transcript("Murat", "Altınışık", 2, "", "Fizik", 20, 'B', 40, 50) { });
        parts.Add(new Transcript("Zeynel", "Yılmaz", 3, "", "Biyoloji", 30, 'C', 40, 50) { });
        parts.Add(new Transcript("Abidin", "Ata", 4, "", "Kimya", 40, 'D', 40, 50) { });
        parts.Add(new Transcript("Veli", "Akay", 5, "", "Tarih", 50, 'F', 40, 50) { });
        //parts.Add(new Transcript(input4, input5, 6, "", "Coğrafya", 50, 'A', 40, 50) { });
        ShowMethod();
        void ShowMethod()
        {
            Console.Clear(); Console.WriteLine("Adı:" + parts[input2 - 1].studentInfo.Isim + "\nSoy Adı:" + parts[input2 - 1].studentInfo.SoyIsim + "\nÖğrenci No:" + parts[input2 - 1].studentInfo.OgrenciNo + "\nDers Adı:" + parts[input2 - 1].crsInfo.DersAdi + "\nVize Puanı:" + parts[input2 - 1].crsInfo.VizePuani + "\nFinal Puanı:" + parts[input2 - 1].crsInfo.FinalPuani + "\nNot:" + parts[input2 - 1].crsInfo.Not);
        }
    Met:
        void UpdateMethod()
        {

            var obj = parts.FirstOrDefault(x => x.studentInfo.Isim == parts[input2 - 1].studentInfo.Isim);
            if (obj != null)
            {
                obj.studentInfo.Isim = "selam";
            }


            else if (updateInput == 2) { }
            else if (updateInput == 3) { }
            else if (updateInput == 4) { }
            else if (updateInput == 5) { }
            else if (updateInput == 6) { }

        }
    End:
        Console.WriteLine("");
    }
}
