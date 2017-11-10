using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKIApp2.Entity;
namespace VKIApp2
{
    
    class Program
    {
        
        static void Main(string[] args)

        {
            MenuGoster();
        }
        
        
        static void MenuGoster()
        {
            Console.WriteLine("Kaç Hastanın VKI si hesaplanacaktır?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());
            DegerleriAl(kisiSayisi);
        }
        static void DegerleriAl(int degerleriAlinacakKisiSayisi)
        {
            Hasta[] hastalar = new Hasta[degerleriAlinacakKisiSayisi];
            for (int i = 0; i < hastalar.Length; i++)
            {
                Hasta h = new Hasta();
                Console.Write($"{i+1}. hastanın adı : ");
                h.name = Console.ReadLine();
                Console.Write($"{i + 1}. hastanın soyadı : ");
                h.surname = Console.ReadLine();
                Console.Write($"{i + 1}. hastanın tcnosu : ");
                h.tcno = Console.ReadLine();
                Console.Write($"{i + 1}. hastanın boyu : ");
                h.height = Convert.ToSingle(Console.ReadLine());
                Console.Write($"{i + 1}. hastanın kilosu : ");
                h.weight = Convert.ToSingle(Console.ReadLine());
                BusinessLogic.Hesaplamalar.VKIHesapla(h);
                hastalar[i] = h;

            }
            EkrandaGoster(hastalar);

        }
        static void EkrandaGoster(Hasta[] h)   //parametre yolladık
        {
            Console.Clear();
            for (int i = 0; i < h.Length; i++)
            {
                Console.WriteLine($"{h[i].name} {h[i].surname} {h[i].tcno} {h[i].VKIDeger} {h[i].VKISonuc}");
            }
            Console.WriteLine("Yeni hastalar için hesaplama yapmak istiyor musunuz?");
            string secim = Console.ReadLine();
            if (secim.ToLower()=="e")
            {
                Console.Clear();
                MenuGoster();
            }
            
            
        }
            
        

    }

}

/* hastalar[i] = new Hasta(); dizi oluşturduk ama dizinin içinde eleman yok. hastalar dizinin i indeksindeki elemanı = şudur dicem
 * yeni bir hasta oluşturarak atamam lazım. class ları new ile oluşturabiliyordum*/
