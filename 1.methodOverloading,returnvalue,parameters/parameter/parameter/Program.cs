using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameter
{
    class Program
    {
        static void Main(string[] args)  // passing by value..yaz metoduna değişkenin değerinii geçirdik.
        {
            int b = 5;
            Yaz(b);   // metoda değeri burda gönderiyorum.. 
            Console.WriteLine("Main metodunda b nin değeri "+b);
        }
        static void Yaz(int a)
        {
            a = a + 5;
            Console.WriteLine("Yaz metodunda a nın değeri "+a);
        }
    }
}
