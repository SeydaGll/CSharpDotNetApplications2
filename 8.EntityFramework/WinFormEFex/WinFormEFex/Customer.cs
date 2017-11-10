using System.Collections.Generic;

namespace WinFormEFex
{
    public class Customer
    {
        public int CustomerId { get; set; }  //entity framework der ki siz classınızın içerisine sayısal bir tipten alanın karşısında customerıd yani ıd ile biter ve sınıfımızla aynı ismi taşırsa ben onu veritabanında primary key olarak ve ıdentity alan olarak işaretlerim der. yada sadece ıd dersem de olur
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; } /* neden virtual ?(lazy loading için) siz customer ı sorguladığınız zaman o customer ın birincil öğeleri gelir.
                                                                   ıd,name,surname i.onunla ilişkili olan diğer verilerin yüklenmesi başvuru yapıldığı zaman oluyo sadece.. yani bu
                                                                   costomer ın araçları neymiş bunlarıda foreach le bi dönüpte yazdırayım ekrana gibi bir niyetiniz olduğu anda sql e
                                                                   ikinci bir sorguyla o customerıd si ile bağlatılı olan araçlar getirilir..biz lazy loadinle çalıştığımız zaman 
                                                                   performansımız biraz daha yüksek oluyo !!sql e her ihtiyac duyduğumuzda sorgu gönderilmş oluyor...virtual yapmazsam lazy
                                                                   loading çalışmıcaktır . böyle bir durumda ben bir customerı talep ettiğimde o customer la alakalı olan bütün diğer
                                                                   tablolardaki verilerde çekilip getirilicektir.. istemeyeceğim bir durum bu!!!
                                                                   
                                                                   ICollection olmasının sebebide bir müşterinin birden fazla arabası olacağı içindi*/



    }
}