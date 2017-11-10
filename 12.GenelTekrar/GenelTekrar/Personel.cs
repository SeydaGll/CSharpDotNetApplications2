using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    public abstract class Personel
    {
        public string AdSoyad { get; set; }

        public decimal Maas { get; set; }

        //public virtual decimal IkramiyeHesapla()
        //{
        //    return Maas*2;

        //}

        public abstract decimal IkramiyeHesapla();


        public override string ToString() // eğer personel sınıfı içerisinde biri tostring metodunu kullanırsa return adsoyad de dedik
        {
            return AdSoyad;

        }
        /*console.writeline() metodu içerisine bir nesne verdiğin zaman .tostring olarak gösterir yani sana nokta atısı sınıfın 
         * bulunduğu adresi göstrir. string dğil de personel tipi verirsen tostring i çağırır. console.writeline(p) ile
         console.writelline(p.tostring()); aynı şey . tostring i override etmiş olduk*/

        //public override bool Equals(object obj) // equals boolean dönüyo. karşılaştırmak için kullanılıyor. iki tane personelim var
        //{// bu personel birbiriyle aynı mı  değil mi bunun karşılaştırılmasını equel ile yapabilirsiniz. ve iki tane int ı karşılaştıracak 
        //    return base.Equals(obj); // olsam program bunu zaten bilr. ama personel tipini bilemez. int ler string ler built in yani sabit
        //}// personeli var eden sensin ve eşitlik tanımını yapıcak olan sensin

        public override bool Equals(object obj)  // iki personelin birbiyle karşılaştırılması..equels metodu bir personel sınıfı için kullanıldığı zaman obj geldi personel e cast edildi
        {                           // gelen nesnein ad soyadı ile benim personelimin adı soyadı eşit ise evet, bu iki personel birbirine eşittir değilse değildir..
            if (AdSoyad == ((Personel)obj).AdSoyad)
                return true;
            return false;
        }



    }

    public class Mudur:Personel
    {
        public override decimal IkramiyeHesapla()
        {
            return base.IkramiyeHesapla();  // base: içinde olduğun sınıfın türediği sınıf yani kalıtım yaptığı sınıf demek daha doğru
        }               // müdür sınıfının içindeyim kimden kalıtım yaptım personel. base personel sınıfını ifade ediyor
    }           // git diyor personelin içindeki (base.) ikramiyehesapla yı çağır.. eğer benim hesaplamam personellerin aldığı ikramiyeden 1000
    // lira fazla olucak dersen o zaman şunu yapıcaksın return base.IkramiyeHesapla()+1000; ama ben direk maaş*4 oluck demiştim.
    // base e hiç göndermeden maas*4 diyebilirim. aşağıdaki giib



    public class MudurYardimcisi:Personel
    {
        public override decimal IkramiyeHesapla()
        {
            return Maas*4;
        }
    }
}
/*virtual ile değiştiriyoruz override ile değiştiriyosun yani ezilebilsin diyosun.virtual ı ezmek için override yapıyosun*/
/*ABSTRACT-SEALED - birbirinin tersi   abstarct-override    VİRTUAL-OVERRİDE*/
/* abstract sınıf kendisinin üretilmesine izin vermez. abstract sınıfın örneği alınmaz ama bu sınıf kalıtım yapmak için kullanılabilir
 * abstarct sınıfın abstract metodu olabilir ama metodun gövdesi olmaz
 * sealed sınıf: sealed sınıfın kalıtımı yapılmaz ama üretilebilir.*/
 
    /* virtual ile abstract asarındaki fark nedir ? abstract ta sen mecburen o abstract üyeyi alt sınıfta override etmek zorunda kalıyosun. abstract üye alt sınıfta mecburen 
     * override edilmek zorunda..ama virtual da öyle bir durum yok..abstract olan metodun yazıldığı sınıfta gövdesi yok ama virtual olanın gövdesi var*/