using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // kategori seçicez(combobox dan) o kategorinin ürünlerini bana gösterecek(gridde). kategoriyi benim seçebilmem için öncelikle
        // combobox ın içerisine bütün kategorileri getirip doldurmam gerekiyor. önce bu işle başlamalıyız. bunuda form açılır açılmaz yapması
        // lazım
        NorthwindDbDataContext ctx = new NorthwindDbDataContext();  // her iki yerde kullanıldığı iiçin buraya aldım class seviyesine çıkardım

        private void Form2_Load(object sender, EventArgs e) // kategoriformun açılması olayı. form un load olayı. Form2_Load. 
        {
            // database e bağlanıcaz. kategorilerin hepsini alıp combobox ın içerisine doldurcaz...ve combobox da seçimin değişmesi
            // olayı nı yakalıcaz daha sonrasında grid in içerisine comboboxda hangi kategori seçildiyse o kategorideki ürünleri gösteriyor
            // olucaz........
            // veritabanına bağlanacağımız için bu taraftada bizim onu karşılacağımız bir sınıfımız olması lazım. buda zaten linq tarafından oluşturulmuş bir sınıf. : NorthwindDbDataContext
            //NorthwindDbDataContext ctx = new NorthwindDbDataContext();
            var categories =ctx.Categories.ToList();   // normalde categories table<categories> yani tablo tipinden ama ben bunu toList() diyerek liste tipinden ver diyorum

            cbbCategories.DataSource = categories; // combobox a verileri koy..combobox ın özelliklerinden dropdownstyle ı dropdownList yaptıkki üzerine birşey yazamasınlar
            cbbCategories.DisplayMember = "CategoryName"; // ekranda göstereceğin kısım burası
            cbbCategories.ValueMember = "CategoryID";         // ekranda gösterilmeyen ama secimden sonra benim arka taraftan almak istediğim değer. ben seçtiğm zaman bana categoryıd
                                                              //ver ekranda da categoryname i göster diyorum

            this.cbbCategories.SelectedIndexChanged += new System.EventHandler(this.cbbCategories_SelectedIndexChanged);
            // önce form yüklenirken kategorilerin hepsi doldurulsun, ondan sonra selectedindexchanged bağlansın..

            // şimdi yapacağım şey categoriyi seçtiğimde o kategorideki ürünlerin gelmesi olayı
            // kullanıcı combobox ın içerisindeki ni değiştirdiği zaman değşmesini istiyorum o zaman comboboxa giderim.

            //combobox mın adı cbbCategories idi
        }



        private void cbbCategories_SelectedIndexChanged(object sender, EventArgs e) // combobox ın olayıdır bu. yani seçili index değiştiyse..eventler den bul ve üzerine tıkla senin istediğin işlemi yapacak
        {
            //var products = from q in ctx.Products
            //               where q.CategoryID == Convert.ToInt32(cbbCategories.SelectedValue)
            //               select q;

            // grid kısmında gelen bazı kısımları görmek istemiyorsam, sadece istediğim alanlar gözüksün??

            var products = from q in ctx.Products
                           where q.CategoryID == Convert.ToInt32(cbbCategories.SelectedValue)
                           select  new
                          {                 // q category ile etkileşimli old için de category e ulaşıp categoryname i yazabldik.
                               CategoryName = q.Category.CategoryName, // q product nesnesi, product nesnesinin kategorisine git,onun adını al getir categoryname ine koy dedik
                               ProductName = q.ProductName,
                               Stock = q.UnitsInStock,
                               Price = q.UnitPrice,  // inner joın yaptık sanki inner joıne gerek kalmadan her iki tabloyu ilişkilendirip beraber yazdırabilirdik
                               AdetxFiyat = q.UnitsInStock * q.UnitPrice
                           }; // BÖYLECE daha özelleştirmiş olduk. kendi verdiğim isimle göstermek istedik
            // arka tarafta olan siz new dedikten sonra calışma zamanınnda yeni bir class oluşturuyosunuz ama bu classın bir adı yok
            //içerisinde productname, stock ve price propertylerini barındıran bir tane class oluşturuyosunuz. tek yaptığınız şey bu


            dgvProducts.DataSource = products;
        }

        private void cbbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}