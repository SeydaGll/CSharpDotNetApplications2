using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelTekrar
{
    class Program // bunun gelmesinin nedeni main metodundan dolayı
    {
        static void Main(string[] args)
        {
            //int a = 5;
            var str = Guid.NewGuid().ToString();



            Personel p = new Personel();
            p.AdSoyad = "Şeyda";
            Console.WriteLine(p);
            Console.ReadLine();
        }
         void Topla()
        {

        }

        
        
    }
}
// exe uzantılı bütün projelerde main metodu vardır. neden? uygulama çalıştığı anda main metodu tetiklenir ordan başlar. main den 
//sonra dallanıp gider. c# nesne yönelimli dildir ve bütün herşey illaki nesnedir. metodlarımzı nesnelerimizin içine yazarız. yani main metodu
//bir başka class ın içinde olmak zorunda

    /* class ı yazınca direk gidip ram a class programı yazmıyor. disk üzerinde barındırılıyor. uygulaman çalıştığında gidip class Program
     * okunuyo ve hafızada bir örneği oluşturuluyor. aynı anket formu gibi . anket formu taslaktır. anket doldurmak istediğinde onun 
     * fotokopisini çoğaltırsın. taslak bomboş duruyordur.
     */
      
    /* herşey nesnedir. class ile bir insanı,arabayı,derslik,öğrenciyi class ile tanıtabiliyorum (1), bunun yanısıra data ile etkileşim
     * yapmamı sağlayan bir data katmanı oluşturmak adına da class tanımlayabliirm. veritabanı ile ilgili işlemleri yapıck olan bir nesne
     * oluşturucam bunun için DE bir class yazıyorum..*/

    /* public: her yer.. 1.aynı assembly içerisinden erişebilirim.. ASSEMBLY NEDİR..Genel Tekrar bir assemble yada Cdr.DataLayer dll dosyası bir assembly dir..
     * program sınıfının içerisinde public li bir metod yazdım.. bu topla metoduna da hem içinde bulunduğu sınıftan, hem başka bir sınıftan hem de başka bir projeden erişebiliyorum
     * private: özel.. sadece içerisinde olduğu sınıftan erişilebilir..sadece bu sınıf içerisinde kullanmam gereken, ve dışardan görünmesini istemediğim  durumlarda
     * internal : public ile private arasında biryer..private den biraz daha yetki var public den de biraz daha az yetki var. internal sınıfa bulunduğum assembly içinden her yerden 
     * erişebiliyorum..internal bir nesneye sen sadece içerisinde olduğun assembly den erişebilyosun yani aynı proje içinden erişebiliyosun. şöyle bir durum var dilerseniz siz assembly nizi
     * kardeş assemly yapabilrsiniz.. cdr.datalayer içerisindeki internal olan nesnelerin sadece geneltekrar projesinden erişilebilir olmasınıda sağlayabilirsiniz.. başka hiçbir proje erişe
     * mesin ama genel tekrar erişebilsin istiyorsak cr.datalayer içerisinde properties var..assembly ile bilgilerinizin çoğu burda yer alır.. bunun altına gelip 
     * assembly direktifi yazabilirsiniz..[assemble: InternalVisibleTo("GenelTekrar")].. artık datalayer içerisindeki internal olan nesnelerim geneltekrar içerisinden de erişileblr hale gelmiştir
     * protected: nesne yönelimli programlama ile birlikte kullandığımız bir yapı.. sınıfların birbirinden kalıtımını görmüştük..mesela insan sınıfından türeyen personel sınfının 
     * kullanabilmesi için 1 tane metod yazdım diyelim.. bunu protected yapıyorum.. protected olduğu zaman sınıfın dışından gözükmüyo..ama kalıtım yapan sınıflardan gözüküyor!!
     * /

    /*Uygulamayı ilk ayağa kaldırdığınızda exe yi çalıştırdığnız anda o exe nin ihtiyacı olan bütün static metodlar ilk başta hafızada
     oluşturulur..static olan herhangi bir nesneyi new ile üretemezsiniz 
     bu nesneler hafızada bir kere oluşturulur ve bütün uygulama o oluşturulan nesne örneğini kullanır. bundan dolayı sizde tekrar
     new ile türetemezsiniz ve static nesneler exe yi sen ilk defa çalıştırdığında hafızada otomatik olarak oluşturulan nesnelerdeir.*/

    /*bir projede birden fazla solutıon olmaz ama bir solutionda birden fazla proje olur*/
    
  
   