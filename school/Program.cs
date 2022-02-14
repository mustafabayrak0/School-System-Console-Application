//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using school;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string input4 = "";
//        string input5 = "";
//    ListPoint:
//        List<Transcript> parts = new List<Transcript>();
//        parts.Add(new Transcript("Mustafa", "Bayrak", 1, "", "Matematik", 20, 'A', 50, 60) { });
//        parts.Add(new Transcript("Murat", "Altınışık", 2, "", "Fizik", 20, 'B', 40, 50) { });
//        parts.Add(new Transcript("Zeynel", "Yılmaz", 3, "", "Biyoloji", 30, 'C', 40, 50) { });
//        parts.Add(new Transcript("Abidin", "Ata", 4, "", "Kimya", 40, 'D', 40, 50) { });
//        parts.Add(new Transcript("Veli", "Akay", 5, "", "Tarih", 50, 'F', 40, 50) { });
//        //parts.Add(new Transcript(input4, input5, 0, "", "Coğrafya", 50, 'A', 40, 50) { });
//        //void RandomNumber()
//        //{
//        //    Random randomNumber = new Random(); 
//        //    int randnum= randomNumber.Next(0,100);
//        //    Console.WriteLine();
//        //}
//        Console.WriteLine("Sisteme hoşgeldiniz.Lütfen yapmak istediğniz işlemin numarasını tuşlayınız.");

//        int x = 0;
//    StartPoint:
//        Console.WriteLine("1)Öğrenci ekle");
//        Console.WriteLine("2)Öğrenci ara");
//        Console.WriteLine("3)Öğrenci güncelle");
//        Console.WriteLine("4)Çıkış yap");
//        int input = Convert.ToInt32(Console.ReadLine());
//        int input2 = 0;
//        int updateInput = 0;
//        if (input == 1)
//        {
//            Console.Write("Öğrenci ismi:");
//            input4 = Console.ReadLine();
//            Console.Write("Öğrenci soy ismi:");
//            input5 = Console.ReadLine();
//            Console.WriteLine("Ana menüye yönlendiriliyorsunuz.");
//            goto AddingMethod;
//        }
//        else if (input == 2)
//        {
//        TryAgain:
//            Console.WriteLine("Aradığınız öğrencinin numarasını tuşlayınız");
//            for (int i = 0; i < parts.Count; i++)
//            {
//                Console.WriteLine($"{parts[i].studentInfo.OgrenciNo}){parts[i].studentInfo.Isim}");
//            }
//            input2 = Convert.ToInt32(Console.ReadLine());
//        }
//        else if (input == 3)
//        {
//            Console.WriteLine("Güncellemek istedğiniz öğrencinin numarasını tuşlayınız");
//            input2 = Convert.ToInt32(Console.ReadLine());
//            if (input2 == 1 || input2 == 2 || input2 == 3 || input2 == 4 || input2 == 5 || input2 == 6)
//            {
//                Console.WriteLine("1)İsim,2)Soy İsim,3)Ogrenci No,4)Vize Puanı,5)Final Puanı,6)Not");
//                updateInput = Convert.ToInt32(Console.ReadLine());
//                if (input2 == 1) { }
//                goto Met;
//            }

//            else { Console.Clear(); Console.WriteLine("Hatalı tuşlama yeniden deneyiniz"); goto End; }

//        }
//        else if (input == 4) { Console.WriteLine("Çıkış yapıldı."); goto End; }
//        else { Console.Clear(); Console.WriteLine("Hatalı tuşlama.Yeniden deneyiniz."); goto StartPoint; }


//        Users user1 = new Users();
//        Courses course = new Courses();
//        Roles role = new Roles();
//        Academicians academicians = new Academicians();
//        Student student = new Student();
//    //int No()
//    //{
//    //    for (int i = 0; i < parts.Count; i++)
//    //    {
//    //        parts[i].studentInfo.OgrenciNo = parts.Count;
//    //        return x = parts[i].studentInfo.OgrenciNo;

//    //    }
//    //}

//    //int MyMethod(int x) { return x = parts.Count - (parts.Count - input2); }
//    AddingMethod:
//        void AddStudent()
//        {
//            parts.Add(new Transcript(input4, input5, 0, "", "", 50, 'A', 40, 50) { });
//        }
//        ShowMethod();
//        void ShowMethod()
//        {
//            Console.Clear(); Console.WriteLine("Adı:" + parts[input2 - 1].studentInfo.Isim + "\nSoy Adı:" + parts[input2 - 1].studentInfo.SoyIsim + "\nÖğrenci No:" + x + "\nDers Adı:" + parts[input2 - 1].crsInfo.DersAdi + "\nVize Puanı:" + parts[input2 - 1].crsInfo.VizePuani + "\nFinal Puanı:" + parts[input2 - 1].crsInfo.FinalPuani + "\nNot:" + parts[input2 - 1].crsInfo.Not);
//        }
//    Met:
//        //void UpdateMethod()
//        //{

//        //    var obj = parts.FirstOrDefault(x => x.studentInfo.Isim == parts[input2 - 1].studentInfo.Isim);
//        //    if (obj != null)
//        //    {
//        //        obj.studentInfo.Isim = "selam";
//        //    }
//        //    else if (updateInput == 2) { }
//        //    else if (updateInput == 3) { }
//        //    else if (updateInput == 4) { }
//        //    else if (updateInput == 5) { }
//        //    else if (updateInput == 6) { }
//        //}
//    End:
//        Console.WriteLine("");

//    }
//}
