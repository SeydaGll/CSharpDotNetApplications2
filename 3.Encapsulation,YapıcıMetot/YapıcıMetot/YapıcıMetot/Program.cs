using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kisi k = new Kisi("Merhaba yapıcı metot");
            //Kisi k1 = new Kisi();

            Kisi k = new Kisi("3873827",DateTime.Now.AddYears(-30));
            Console.WriteLine(k.TC);
            k.TC = "9839837383";
            Console.WriteLine(k.TC);
            Console.WriteLine(k.DogumTarihi);
            
        }
    }
}
