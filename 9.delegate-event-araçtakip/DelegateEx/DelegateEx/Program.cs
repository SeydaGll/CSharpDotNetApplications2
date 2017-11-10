using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    class Program
    {
        public delegate void MatematikHandler(int a,int b);  // delega min geriye dönüş tipi ne ise bu delegeme üye olan metodlarımın geriye dönüş tipide aynı olmak zorunda. delege min parametrik yapısı ne ise bütün metodlarımın parametrik yapısı aynı olmalı
        /* geri dönüş tipi
         * parametreleri çok önemli*/
        static void Main(string[] args)
        {
            MatematikHandler temsilcim = Topla;   // topla metodunu tetikleyeceksin diyorum
            temsilcim += Cikart;   // temsilcim = topla,cikart,carp gibi bir kullanımı YOK.
            temsilcim += Carp;
            temsilcim += Bol;   // kullanım şekli bu şekilde...
            //herhangi bir şeyler var bu arara
            temsilcim -= Carp;
            temsilcim(10,5);
            temsilcim.Invoke(10, 5);  // bu şekilde de çalıştırılabilir.
            
        }

        static void Topla(int x,int y )
        {
            Console.WriteLine("Topla metodu çalıştı"+(x+y));
        }

        static void Cikart(int x, int y)
        {
            Console.WriteLine("Çıkart metodu çalıştı" + (x - y));
        }
        static void Carp(int x, int y)
        {
            Console.WriteLine("Topla metodu çalıştı" + (x * y));
        }
        static void Bol(int x, int y)
        {
            Console.WriteLine("Topla metodu çalıştı" + (x / y));
        }
    }

}
