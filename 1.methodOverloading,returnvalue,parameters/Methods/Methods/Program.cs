using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuGoster();
        }

        static void MenuGoster()
        {
            Console.Clear();
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkartma");
            Console.WriteLine("3. Çarpma\n4. Bölme");  // n: New Line
            Console.WriteLine("Bir işlem seçiniz : ");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Topla();
                YeniIslemSorusu();
            }
        }

        static void YeniIslemSorusu()
        {
            Console.WriteLine("Yeni Bir İşlem Yapmak İster misiniz?(E/H)");
            string secim = Console.ReadLine();
            switch (secim.ToLower())
            {
                case "e":
                    MenuGoster();
                    break;
                default:
                    break;
            }

        }

        static void Topla()  // metodun imzası : geriye dönüş tipi(zorunlu),metod adı(zorunlu),eğer varsa parametreler( zorunlu değil),()
        {
            Console.Write("1.Sayıyı Girin : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Girin : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = sayi1 + sayi2;                                                 // .NET 4.6
            Console.WriteLine($"{sayi1} ve {sayi2} sayılarının toplamı : {toplam} ");  // c# 6.0 ile gelen yeni özellik// metodun gövdesi
        }

        
    }
    
}
Program p = new Program();
p.Topla();   // Program tipinde p adında değişken.. Program tipinde p adında nesnem 