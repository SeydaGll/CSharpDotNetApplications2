using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormEFex
{
    public class WinformDBContext:DbContext
    {
        public WinformDBContext()
            : base("Server = .; Database=WinformDB;User Id = sa; Password=54321a!")
        {
            Database.SetInitializer<WinformDBContext>(
                new MigrateDatabaseToLatestVersion<WinformDBContext, WinFormEFex.Migrations.Configuration>());
        }  // benim database imi daima en son versiyonuna güncelle demiş olduk
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
/*burada database ın sürekli otomatik olarak güncellenmesini istedik..önceki örnek uygulamda burası false idi..sonra true yaprık..dedik ki benim database ım bu uygualama her çalıştığında 
 * otomatik olaraktan güncellensin.. eklediğim herhangi bir kolon data tablo vs varsa yada sildiklerim otomatik olarak güncellensin .. bu add migration yazıp update databse dememe gerek kalmıyo
 * her seferinde.. amaa bunu yazınca sorun çıkıyo.. eğer sen bugün vehicle diye bir alan oluşturdun sonra da gittin bu vehicle ı sildin o zaman virtual tablosu içerisindeki verileri
 * kaybedeceksin. ve bunun sorumluluğunu .net üstlenmez. bunuda sen bildirmek zorundasın.. otomatik migraton data lose alout diyosun ben kabul ediyorum otomatik migration daki veri kayıplarını 
 * dityip true diyosun.. ve buda yetmiyo çünkü ben bir database i güncelleyeceksem bunun birçok yolu vardır.. database i komple silip tekrar yenisini oluşturabilrim, sadece en güncel
 * versiyonlara çıkartabilirim gibi birçok yol var.. bunuda hangi strateji ile güncelleneceğini yukarda bildirdim. diyoki database imin initializer ına yani başlatıcısına git benim
 * WinformDBContext nesnesi ile çalış.. yani benim datacontext im budur diyip generic olan metoda öncelikle bildiriyorum datacontaxet mi.. sonra bunun ctro sına da iki parametre
 * gönderiyorum. 1. parametre stratejimin ne olduğu,MigrateDatabaseToLatestVersion. databasee mi en son versiyonuna güncelle demiş oldum.2. de hangi configurasyon ayarına göre güncelle
 * yim diyo.. new dro kısmıda var onlarda kullanılabilir..*/
