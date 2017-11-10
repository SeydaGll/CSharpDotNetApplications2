using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetot
{
    public class Kisi   // ctor yaz
    {
        //// Constructor ( Yapıcı Metot) 
        //public Kisi(string mesaj)
        //{
        //    Console.WriteLine(mesaj);
        //}                             // tc yi zorunlu kılmak.tc yi 2 . defa değştirilmemesini de sağladım...tc yi vermeden bir kişiyi oluşturmak artık imkansız
        public Kisi(string tc,DateTime dTarihi)  // KİŞİ İLK DEFA oluşturulurken tcno ya değer yazılabilsin
        {           // ilk çağrılacak metoddur.. kisi sınıfında ilk cağrılan metottur.
            TC = tc;
            DogumTarihi = dTarihi;

        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get;  private set; }
        public DateTime DogumTarihi { get; set; }


    }
}
// KASA UYGULAMASI, MUHASEBE UYGULAMASI, PERSONEL TAKİP UYGULAMASI, MÜŞTERİ İLİŞKİLERİ UYGULAMASI( KİM BENİ ARAMIŞ, NE ZAMAN ARAMIŞ, 
//NE ZAMAN TEKLİF VERMİŞİZ, NE ZAMAN GÖRÜŞMEYE GİTMİŞİZ,MÜŞTERİ BİZDEN HANGİ ÜRÜNÜ İSTİYO, NE TEKLİF VERMİŞİZ., UYGULAMANIN BUSİNESS LOGİC 
// İNİ ORTAYA ÇIKARABİLİRSİN(İŞ MANTIĞI), VERİ TABANINA GEREK YOK BUNUN İÇİN)