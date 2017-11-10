using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrencı ogrenci = new Ogrencı();
            //ogrenci.Set_TCNO("23823898987");
            //Console.WriteLine(ogrenci.Get_TCNO());
            //ogrenci.Set_TCNO("93838383832");
            //Console.WriteLine(ogrenci.Get_TCNO());

            ogrenci.TCNO = "9483948934";  // seti kullanmak istersem karşısına bir değer yazabiliyorum
            Console.WriteLine(ogrenci.TCNO);  // geti kullanmak istersem de bu şekilde kullanabiliyorum.değişken kullanır gibi. () olayı yok

        }
    }
}
