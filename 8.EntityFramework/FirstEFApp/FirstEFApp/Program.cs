using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEFApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //18))uygulamam açıldığı an ben kendim kategory eklemek istersem nasıl yaparım?
            //Console.WriteLine("Kategori adını yazın");
            //string catName = Console.ReadLine();
            //Category c = new Category() { CategoryName = catName };

            //EFTestDbContext ctx = new EFTestDbContext();
            //ctx.Categories.Add(c);
            //ctx.SaveChanges();

            //19)) bir çok ilişki nasıl kurulur ?? ---> product isminde sınıfım olsun


            ////24))). şunu isteyebilirim.. t. dediğim zaman category nın direk adınada erişeyim istiyorum. categoryıd geliyo. bu gelince  illaki bbunu kullandıktan sonra ekstra bir sorgu daha yapmak zorundayım
            //Product t = new Product();    //kategorinin kendisi gelsin direk. bu ürünün kategorsii neymiş onu direk görmek istiyorum
            //t.

            // bu şu şekilde çözülür.. 25))--->product

            //26)
            //Product p = new Product();
            //p.Category.CategoryName  // artık bu şekilde bire çok tablolar arasında geçişler yapabiliyorum.. joın-lerle uğraşmak zoruda değilm.. ***


            //Category c = new Category() { CategoryName = "Kitap" };
            //c.Products = new List<Product>
            //{
            //    new Product{Name ="ASP.NET Core MVC",Price=35,Stock=50},
            //    new Product{Name="İtalyan Mutfak Sırları",Price=45,Stock=150 }
            //};
            //EFTestDbContext db = new EFTestDbContext();
            //db.Categories.Add(c);
            //db.SaveChanges();

            /*SELECT C..CategoryName,P.[Name],P.Price   sql de iki tablo içindekileri yanyana göstermek istediğim zaman oluşturacağım sorgudur.
             FROM Categories C INNER JOIN Products P
              ON C.categoryıd==P.Categoryıd*/

            EFTestDbContext db = new EFTestDbContext();
            var query = db.Categories.ToList();
            foreach (Category cat in query)
            {
                Console.WriteLine($"{cat.CategoryName}");
                foreach (Product p in cat.Products)
                {
                    Console.WriteLine($"\t{p.Name},{p.Price}");
                }
            }

            Console.ReadLine();
        }
    }
}
//1) code first çalışıcaksak datacontext oluşturuyoruz...class ekledik yani nesneyi eklemiş olduk

// özet
//1-veri tabanını oluşturmak için entity framework ü kurmak.pachage manager .. install-pachage entity framewrok yazıyoduk
//2-context oluşturman gerekiyor. oluşturmak kolay. bir class oluşşturup dbcontext ten kalıtım yaptığınızda contextiniz hazır
//eğer kendiniz bir kullanıcı adı ve şifreyle istediğiniz servera connection stringle bağlanmak isstiyosan bir ctr ile işi bitiriyosun
//3)) sonra eklemek istediğin her bir tablo için class ına DBset tipinden bir property haline getiriyosun..class ın tablo kutusunda görünmesini istediğin ne varsa bunları yazıyosun..
//4))- migration ları enable ediyoduk..Enable-Migrations migraitonları açıyoe
//5)) class içrisindeki property lerden üzerine herhangi bir kısıtlama vs getirmek istiyosan , data uzunluğu nvarchar max olmasın 50 karakterolsun. hatta bu alan zorunlu bir alan olsun
// istiyosan yine property nin üzerine [Required].. bu ne demek ben sql server a hiç gitmeden sql serverda yapabildiim herşeyi uygulama katmanımda da çözebiliyorum anlamına geliyor..