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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        NorthwindDbDataContext ctx = new NorthwindDbDataContext();


        private void Form3_Load(object sender, EventArgs e) // öncelikle form geldiğinde dolu gelsin kategoriler
        {
            dgvCategories.DataSource = ctx.Categories.ToList();
            RefreshGrid();
        }
        void RefreshGrid() // yukarıki satır için metod yazıcam ama biraz özelleştiricem. önüne birşey yazmıyosam zaten private dır
        {
            dgvCategories.DataSource = from q in ctx.Categories
                                       select new
                                       {
                                           Id = q.CategoryID,
                                           CategoryName = q.CategoryName  // sadece bu alanlar gözüksün diye bunları seçtim
                                       };
            dgvCategories.Columns[0].Visible = false;  // 0. indexin visible(görülebilir) özelliğini false yaptık. çünkü son kullanııcı kategorilerin ıd sini görmek istemez
            // id gözükmesin sadece name gözüksün diye grid in kolonlarından 0. indeksinden görünürlük özelliğini false yapıyorum.  artık refreshgrid metodumu çağırabilirm
        }


        private void btnAdd_Click(object sender, EventArgs e)  // butona iki dafe tıklandığında götürüp kategorimin eklenmsini istiyrum
        {
            // insert yapıcağıma göre neyi insert edeceğimi bilmem lazım yani neyi eklicemi bilmem lazım
            // bir kategori eklicez. o zaman linkini oluşturduğu kategori sınıfından bir tane üretiyorum. daha öncede Person sınıfı vardı. gidiyordum person 
            // sınıfından bir tane oluşturuyodum. person sınıfını kullanarak devam ediyodum. aynı işlem
            Category category = new Category();
            category.CategoryName = txtCatName.Text;  // categoryname txtcatname in text idir.

            ctx.Categories.InsertOnSubmit(category); // benim yeni oluşturduğum kategori listesini  gönder aynı listenin için ekler gibi
            // ama burda yapmam gereken birşey daha var. böyle bırakırsam hafızada ram üzerinde categorim ekli görünecektir ama veritabanına henüz yansımamıştır
            // veritabanına yansıması için ...
            ctx.SubmitChanges();  // değişiklikleri gönderin

            dgvCategories.DataSource = ctx.Categories.ToList();  // tekrardan verileri güncellesin
            RefreshGrid();

            //  ctx üxerinde çalışırken verilerin tamamını alıp RAM e yazıyosun. ctx dediğimiz koleksiyon database in bu taraftaki ram üzerindeki yansıması
            //  gibi düşünebilirsin.ctx.categories dediğinde database ın içindeki kategoriler tablosunu işaret ediyosun ve diyosun ki ram deki kategoriler tabloma !bakın
            //    sql deki değil götür kategoriyi koy. tama koydu şimdide diyosun ki hafızada kirli olarak işaretlene alanları götür git database le eşleştir.
            //    kirli olarak ne demek sen buraya yeni kategori eklediğinde bir kategoriyi içindeki herhangi bir değeri değiştirdiğinde bunların hepsi dirty diyip işaretleniyor
            //    submitchanges geldiği zaman ne kadar dirty alan var yani kirli alan hepsini database e götürüp güncelliyo(submit changes = değişikliklerigönder)

            //  ekleme yaptık şimdi silme işlemi yapalım.ama önce gridi mi propery den düzenlemek istiyorum
            //  SelectionMode = FullRowSelect diyerek tıklandığında tüm row u seçmesini sağladm
            //  MultiSelect = false diyerel ctrl ye basıp birden fazla satır seçmemesini sağladık
            //  RowHeaderVisible = false diyerek sadece görünümün güzel olmasını sağladık
            //  AutoSizeColumnNode = Fill diyerek çektiğimizde içeriyi doldur gridin dedik

            //   bir satır seçicez sağa tıklıcaz menü açılacak sil dicez silicek. bunun için özel bir kontrolümüz var. ContextMenuStrip


        }



        private void ctxMenuForGridSilClicked(object sender, EventArgs e)
        {
            // öncelikle grid in özelllklerinden contextMenusTRİP den oluşturduğumuz seçtik 
            // sil butonun tıklandığı zaman hangi kategorinin silindiğini benim biliyor olmam  lazım 
            // bunu bilmeminde tek yolu ıd sine ulaşmak.. refreshgrid metodunda ben ıd yi 0. index kolonuna atmıştım
            int CatId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value); // value object tipinde geldiği için convert yapıyoruz
                                                                                       // artık silinmek istenen kategorinin ıd si benim elimde.mbox, messagebox ile  görelim
                                                                                       //MessageBox.Show(CatId.ToString());
                                                                                       // artık id yi bildiğime göre rahatlıkla delete işlemini çözeibilirm

            var deletedCategory = ctx.Categories.Where(q => q.CategoryID == CatId).FirstOrDefault();
            // bu sorgu tipi biraz daha farklı. bu aslında link ilk çıktığında bizim kullanmış olduğumuz sorgu tipiydi.metod içinde metod çağırarak gidiyoduk
            // from in kullanmadan direk metodlarla çalışıyoruz.. bu sorgunun diğer kullanımıda ;

            //var delCategory =( from q in ctx.Categories  //IQueryable şeklinde dönüyor.yani çoğul olarak dönüyor.istersek burda firstordefault u kullanabiliyoruz
            //                  where q.CategoryID == CatId  // kullanmanız gerekiyor çünkü burda bir tane nesne istiyor. 
            //                  select q).FirstOrDefault();                            // aynısı
            //FirstOrDefault() metodu belirtilen şartlardaki nesne bulunabiliyosa nesneyi dönüyor bulamıyorsa eğer nesneyi null olarak dönüyor size.ilkini bulabilmek için
            // böyle bir şart koştuk. 

            ctx.Categories.DeleteOnSubmit(deletedCategory);  // deleteOnSubmit() bana silmek istediğin category ne ise onu ver diyo. ama benim elimde category yok nasıl bulabilirim
                                                             // tabiki ıd si varsa category i çekersiniz. 
            ctx.SubmitChanges();
            RefreshGrid();

            // güncellemek istersek contextMenuStrip düzenle yazdık







            //}

            //int editCatId;
            //private void DUzenleToolStripMenuItem_Click(object sender, EventArgs e) // düzenleye tıklandığında 
            //{
            //    txtCatName.Text = dgvCategories.SelectedRows[0].Cells[1].Value.ToString();  // textbox ın içerisine yazsn
            //    editCatId = Convert.ToInt32(dgvCategories.SelectedRows[0].Cells[0].Value);  
            //}

            //private void Form3_Load_1(object sender, EventArgs e)
            //{

            //}
            
            // devexpress.com componentler var gridin yaptığı şeyler..

            
            //grid nesnesinde değişiklikler yaptık.. SelectionMode FullRowSelect yaptık ki sectiğimzide tüm satır seçilsin
            //MultiSelect i False yaptık ki fareyle iki satır seçemesin
            //RowHeadesVisible false yaptık görünüm güzel olsn
            //AutoSizeColumnsMode u Fill yaptık .. içeriyi tamamen doldur gridin diyoruz

            //contetxMenuStrip ekledik.. bu gride sağ tıkladığımızda gelen menudür.. peki gride tıkladığımızda bu menunun açılması için gride gittik özelliklerin contextMenuStrip ı bulduk ve isim verdiğimiz menustrip ekledik

        }
    }
}
