using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametre2 //sıralama algoritması yazdığını düşün. benim elimde bir dizi var ve ben bu dizinin a dan z ye gibi sıranlmasını istiyrm
{               // bir metod yazıp benim dizimi metoddan geçtikten sonra sıralı hale çevirmeniz gerekiyor. diziyi metodunun içerisine 
                    // ref adresi ile alırsın. eğer ref adresi ile almazsan normal bir şekilde bir dizinin kopyası üzerinde çalışmış olursun
    class Program
    {
        static void Main(string[] args)
        {
            int b = 5;
            Yaz(ref b);
            Console.WriteLine("b nin değeri " + b);
        }
        static void Yaz(ref int a)
        {
            a = a + 5;
            Console.WriteLine("a nın değeri " + a);
        }
    }
}
