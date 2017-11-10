using System;
using System.Collections.Generic;
using System.Data.Entity; //DataContext i kalıtım yapınca geldi. artık datacontext özelliği taşıyan sınıfım var
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//eğer code first çalışacaksak bizim sql serverdaki database i bu tarafta nesne olarak karşılayabilecek nesneye ihtiyacım var. buna biz DataContext diyoruz
//linq tarafında designer a link i eklediğim zaman otomatik oluşturuyodu. şimdi elle yapıyorum ve ordaki kadar çok kod da yok içerisinde


namespace FirstEFApp // 1)) database oluşturuyorum.... EFTestDb database i 
{
    public class EFTestDbContext:DbContext // 2))) bunun entity framework ün data context özelliğini kazanabilmesi için gerekli bir takım kalıtımlar yaparız.bir datacontext olmasını istiyosanız DbContext sınıfından kalıtım yapmalısınız 
    {                                           // artık bu benim datacontext özelliği taşıyan sınıfım.birde buna cotr diyip devam ediyorum
        public EFTestDbContext() : base("Server=.;Database=EftestDb;User Id=sa;Password=654321a!") // 3)))database i oluşturduk. kendimiz oluşturuoyruz. EftestDb databse i
        {
                        //aslında boş bırakabilirsin ama ben özel bir connectionstring yazmak istediğim için yazıyorum..app.config içerisine de yazabilirdin..artık database oluşturmam için yapcak başka birşey de kalmadı
        }

        public DbSet<Category> Categories { get; set; }  // 6))) bildirme kısmı.. veritabanına oluşturuyoruz. benim data context imde bir tane prop var ve bu prob in tipi DbSet
                                                         // DbSet data seti yani sizin veritabanı tarafındaki tablonuzun uygulama tarafındaki karşılığı DbSet. Eğer Categories isminde bir tablo olsun istiyosanız buraya gelip
                                                         // DBSET DİYİP prop oluşturuyosunuz. birden çok category bunun içerisinde yer alacağı için Categories diyorum

        // 7 )))database i sql tarafında oluşturmam için öncelikle migration ı açmam lazım..benim uygulama tarafında geliştirdiğim kodlar ile database tarafındaki oluşturulan tabloların
        // kolonlarının yada diğer özelliklern migrate edilemsi eşleştirilmesi .package manager consolu aç . Enable-Migrations yaz enter de. bunu dediğim anda solutionda migration dosyası
        // var ve içerisinde configuration.cs yazılmış bunun içerisinde ....--->

        public DbSet<Product> Products { get; set; }  //21)) her ürün kategorinin altında bunu nasıl bildiricem??category sınıfına gidiyorum br categornin altında birden fazla ürün olabilr

    }
}
// 4)))artık benim database için olması gereken tabloları oluşturmamız lazım. uygulamam içerinde mesela bu e-ticaret uygulaması olsun. bunda category vardır birde categorının altında
// product vardır.<hemen gidiyorum uygulamam için kategorş sınıfı yazıyorum.--> categori sınıfına git

// 10 )) şimdi database i oluşturcaz.. package a add-Migration addCategories YAZIYORUZ...migratona isim veriyoruz(  addCategories). kategori oluşturdum bunun için bir migration
// eşleştirme dosyası oluşturmuş oluyorum. bu eşleştirme dosyasının içerisinde de yapılcak olan değişikliklerden bahsedecek . kategorinin eklendiğini ismine baktığım an anlarım

// 11)) migration dosyası altına 210921621_addCategories.cs yi oluşturuyorum..bunun içerisinde DbMigration dan kalıtım yapan bir sınıf var. sınıf Up() ve Down() metoduna sahip
// yani sen bu migratıno a yükseltirsen database seviyeni ben bu tabloyu oluştuurucam diyo. categories tablosunu. ıd si name i, primary key olarak ıd yi atıcam dyo. otomatik yapıyo hepsini
// down durumunda yani ben bu migratıon ı geri almak istersemde dropTable (dbo.Categories) diyo.. tabloyu oluşturup kurucam..
// o zaman yap dersek yani database i oluşturması için manage-console a Update-Database diyorum entera basıyorum

//12)) sql server a bakalım. database imiz oluştu. efdbtest orada tablolarında dbo.categories birde dbo._migrationHistory var.bu sizin c# tarafındaki migrations klasörünüzle
//sürekli güncellenerek çalışıyor..böylelikle entityframework data base hangi migration da benim uygulamam hangi migrationda sürekli bunu ayırt edebiliyor

// 17)) package e AddCategories migration ına tekrar dönmek istiyorum. napmalıyım ?? update-database -TargetMigration:AddCategories .. istediğin migrationa geçmek icin
// update-database den sonra targetmigration diyerek hedef belirtebiliyosunuz.. böyle yapınca nvarchar(max) a geri döndü.. istediğiniz migrationa gecebilmek için update-database -TargetMigration:
//diyip hedef belirtebiliyosunuz...böylelikle sürekli uuygulama içerisinde migration lar arasında gezinti de yapabilirsiniz..böylelikle bir ona bir buna atla yapılabliyor..büyük küçük harf öenmli değil
// tarhih kısımlaarını yazmak önemli değil. onu oluştururken benzersiz oluştursun migration ları diye otomatik basıyor

/* kategori tablosunu ekledik ben buunu geri almak istiyorum ne yapmalıyım ??
 * package-manager console a ??

 */
