using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* ben uygulmayı yazdım.içerisine cay ,kahve su koydum bunlarla çalışabiiyodu. yeni bir içeçek daha gelsin.bide ayran var.kupa ayranlada
çalışır.çok güzel oldu. bugün tarihi itibariyle bir uygulama geliştirmişim.ve bu uygulamanın içerisinde rapor sınıfı var.bu rapor sınıfı
sadece pdf raporlar üzerinde işlem yapıyor,yarın müşteri benden pdf değilde excel raporu istedi,aynı sınıf excel içinde çalışabilmeli..
eğer bunu başarabilirsem bakım sürecinde benim işim çokkolaylşır. gider sadece excel raporu hazırlarım. o rapor işleyen sınıf hangi sınıfsa
excel içinde çalışır. ayran ı sonradan eklmedim ama bu sınıf ayran içinde çalışabiliyo*/

namespace Generic  // .net xo ile hayatımıza girdi. kendi generic sınıfları nasıl geliştireceğimizi öğrncz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bardak bardak = new Bardak();
            //bardak.Doldur()

            //Kupa<Ayran> kupa = new Kupa<Ayran>();  // Kupa of Cay  // Doldur static olmadığı için
            //Kupa.Doldur();
            //Cay cay = new Cay (){ Name="a"};
            //Kupa<Cay>.
            
        }
    }
    // birsınıf sadece bir sınıftan kalıtım yapabilir ama birden fazla interface i uygulayabilir.

    public class Bardak
    {
       public void Doldur(Cay cay)
        {
            Console.WriteLine($"{cay.Name} hazır");
        }
        public void Doldur(Kahve kahve)
        {
            Console.WriteLine($"{kahve.Name} hazır");
        }
        public void Doldur(Su su)
        {
            Console.WriteLine($"{su.Name} hazır");
        }

    }
    public class Kupa<T> where T:Icecek  // T yi sadece where ile kıstlarsın if ile falan olmaz
    {
        public void Doldur(T icecek)
        {
            Console.WriteLine(icecek.Name);
        }
    }
    public class Icecek
    {
        public string Name { get; set; }
    }
    public class Cay:Icecek
    {
      
    }
    public class Kahve:Icecek
    {
       
    }
    public class Su:Icecek
    {
        
    }
    public class Ayran:Icecek
    {
      
    }
    public class Ekmek
    {

    }
}
// Cay cay = new Cay();   Cay cay = new Cay() {Name="a"} 
// cay.Name= "ASKLSK";