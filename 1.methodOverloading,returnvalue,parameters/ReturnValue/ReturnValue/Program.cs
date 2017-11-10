using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan 2 sayının toplamını ortalamasını ve bölümünü hesaplayan program
            int sayi1 = 8; int sayi2 = 4;

            int toplam = Topla(sayi1, sayi2);
            int bolum = Bolme(sayi1, sayi2);
            int ortalama = Bolme(toplam, 2);

            Console.WriteLine($"\t{sayi1} ve {sayi2} \n\tToplamları : {toplam}\n\t Bölümleri : {bolum}\n\tOrtalamaları : {ortalama}");
            Console.ReadLine();

        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
        static int Bolme(int x,int y)
        {
            return x / y;
        }
    }
}
