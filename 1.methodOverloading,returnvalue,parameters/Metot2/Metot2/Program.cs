using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot2  // geriye değer döndürme ve parametre alma!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();

        }
        static void ShowMenu()
        {
            Console.WriteLine("İşlem Seçiniz : \n1. Toplama \n2. Çarpma \n3. Çarpma \n4. Bölme ");
            string secim = Console.ReadLine();
            Console.WriteLine("işlem için 2 adet sayı girin : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());


            if (secim=="1")
            {
                Topla(sayi1, sayi2);

            }
            Console.ReadLine();
        }

        static void Topla(int operant1, int operant2)
        {
            Console.WriteLine("Toplam " + (operant1 + operant2));
        }
        static void Cikarma(int operant1, int operant2)
        {
            Console.WriteLine("Kalan " + (operant1 - operant2));
        }
    }
}
