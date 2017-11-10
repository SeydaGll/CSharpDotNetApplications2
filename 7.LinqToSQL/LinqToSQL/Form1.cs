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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region sıkıntılı bir durum

            // linq ın arka tarafta nasıl çalıştığını, sorgu dilini öğrenmeyle ilgli alıştırma 
            /*string[] kisiler = { "Ayşe", "Ahmet", "Ali", "Özlem", "Özgür", "Aydın" };*/ // string array. object initilazer ile diziyi oluşturduk
                                                                                      // baş harfi A olanları listele 
                                                                                      //string[] siralanmisKisiler = new string[kisiler.Length];// en kötü ihtimal kisiler dizinin hepsinin içerisindekiler A ise length i  kadar alırım
                                                                                      //for (int i = 0; i < kisiler.Length; i++)
                                                                                      //{
                                                                                      //    if (kisiler[i].StartsWith("A"))  // startwith A ile başlıyosa dedik
                                                                                      //    {
                                                                                      //        siralanmisKisiler[];
                                                                                      //    }
                                                                                      //}
            #endregion
            #region linq
            // basit yolu LINQ
            /*var sirali*/   // şuanda bir tipi yok = diyip linq sorgusu yazıyorum
                             //var sirali = from q in kisiler// var variable ın kısaltılmışı. değişken oluşturmakiçin var kullanılablir. peki bunun tipi nedir
                             //             where q.StartsWith("A")  // where diye şart koyduk
                             //             select q; // ing diline benzer sorgu dili. şimdi siralının üzerine geldiğimizde tipinin IEnumerable<string> old görürüz
                             //generic bir koleksiyon gibi davranmaya başladı

            //IEnumerable<string>  generic bir koleksiyon oldu. yani string tipinden bir koleksyon oldu benim koleksiyonum. benim oluşturduğum bir koleksiyon
            // bunun içerisinde A ile başlayan isimler var..


            // kisilerin ICINDE geziyosun KİSİLERDEN herbirisi benim için q dur. where den sonra true yada false dönücek birşey belitrmem gerekiyor
            // ise q yu seç demiş olduk.

            //var query = from q in kisiler
            //            where q.Length > 4
            //            select q;

            // bunların hepsini if for ile yapabilmen mümkün.  
            #endregion

            // person class ını kullanarak bir kaç tane kişi eklicem

            Person p1 = new Person
            {
                NameSurname = "Ahmet Bircan"
                
            };
            //Phone p2 = new Phone();
            //p2.PhoneNumber = "93823283";
            //p2.AreaCode = "837";
            //p1.Phones.Add(p2);
            p1.Phones.Add(new Phone { AreaCode = "332", PhoneNumber = "736363535" });
            p1.Phones.Add(new Phone { AreaCode = "857", PhoneNumber = "937365252" });

            Person p2= new Person
            {
                NameSurname = "Özlem Kalender"

            };
            p2.Phones.Add(new Phone { AreaCode = "434", PhoneNumber = "567788999" });
            p2.Phones.Add(new Phone { AreaCode = "566", PhoneNumber = "054321237" });

            List<Person> personList = new List<Person>();
            personList.Add(p1);
            personList.Add(p2);
            // iki kişi oluşturduk. iki kişi için ikişer tane tel numarası yazdık. ve bunların hepsini bir liste içerisine doldurduk
                                    //Linq TO OBJECT KODLARI
            var query = from q in personList
                        where q.NameSurname.Contains("Ahmet")
                        select q.Phones;  // personlist içerisinde dolaş. adı ahmet olanın telefonlarınıı seç
            // burada seçimi yaparken q deyip seçmedik yai ahmet i seçmedikte ahmetin sadece telefonlarını seçtik
            // burada yazmış olduğumuz linq kodları linq to object kodlarıdır. ama biz bunları linq to sql de de kullanabiliyoruz.
            // onun adınada linq to sql diyoruz
            // sql deki joın olayları burda çok kolaylaşıyo
        }
    }
}
