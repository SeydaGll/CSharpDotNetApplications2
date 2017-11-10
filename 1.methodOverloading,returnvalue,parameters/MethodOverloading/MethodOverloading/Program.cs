using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading  // aynı sınıf içerisinde birden fazla aynı isme sahip metod açabiliriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan 2 sayıyı toplayan program
            Console.WriteLine("toplam için 2 sayı girin");
            int x = Convert.ToInt32(Console.ReadLine());   Cay cay = new Cay(); // aynı şey
            int y = Convert.ToInt32(Console.ReadLine());
            Topla(x, y);

            

        }
        /// <summary>
        /// alınan 2 adet string tipinden değeri toplayarak ekranda gösterir!!
        /// </summary>
        /// <param name="a">ilk operant</param>
        /// <param name="b">ikinci operant</param>

        static void Topla(string a,string b)
        {
            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);
            int sonuc = x + y;


        }
        static void Topla(int a,int b)
        {
            int sonuc = a + b;
            Console.WriteLine(sonuc);
        }
        static void Topla(float a, float b)
        {
            float x = a + b;
            Console.WriteLine(x.ToString(""));
        }
    }
}
