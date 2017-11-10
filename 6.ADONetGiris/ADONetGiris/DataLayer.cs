using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetGiris
{                       // bu class sadece data bağlantımı gerçekletirsin başka birşeydeğil
    public class DataLayer  // ben sadece 2 tane select işlemi için her iki butonun altında da ayrı ayrı sqlconnection oluşturdum sql command yazdım..bunlar hep ikiledi. bir kodu 2 kere yazıyosak orda bir hata VARDIR.. ben bunları nasıl tekilleştirebilirim olayına bakmam lazım...
    {

        private static string cnnStr = "Server = .;Initial Catalog = NORTHWND;user id=sa;password=765432a!";  // bütün uygulamann connection stringidir bu.. global değişken. bu classı dışarısında görüntülenemesin diye private yaptık

        //SELECT-->SqlCommand nesnemin executeReader metodu
        //INSERT, UPDATE, DELETE-->SqlCommand nesnemin ExecuteNonQuery metodu

        //bu metodların birbirinden farkı var. bunu görmek için bu 2 metod için kendim 2 özel metod yazayım


        // iki metodda sql connection istiyosa bu hatadır.her iki yerdede sqlconnection nesnesi oluşturmam lazım. bir sql connection nesnesini ben 2 yerde bir oluşturuyorum
        // o zaman bana bir tane metod sql connection ı oluşturup göndersin
        private static SqlConnection CreateConnection()
        {
            //SqlConnection cn = new SqlConnection(cnnStr);
            //return cn;

            return new SqlConnection(cnnStr);
        }
        
        // sadece command oluşturmaktan sorumlu metod. çünkü her iki tarafta command isticek
        private static SqlCommand CreateCommand(string cmdText) {

            return new SqlCommand(cmdText, CreateConnection());
        }



        public static DataTable MyExecuteReader(string commandText)
        {
            // bu metodun içerisine bir sqlconnectiona e ihtiyac var
            SqlCommand cmd = CreateCommand(commandText); // connection ı açıcaz.executereader metodunu tetiklicez.gelen bir data table içerisine doldurucaz.ve geriye döndürücez
            DataTable dt = new DataTable(); //command ın connectionı nı açarken, connectionstring in hatalı olması, karşıtaraftaki sql servera ulaşılamıyor olması,gibi bazı sorunları değerlendirip ona göre değerlendirmem lazım. bunu yakalamak için try catch bloğu kullanılır. c# içerisinde HATA çıktığını öngördüğünüz kodları catch ın içerisime yazıyosunuz. hata çıması durumunda handle edebiliyosunuz. yani yakalayabiliyosunuz
            try
            {
                cmd.Connection.Open();
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
                MessageBox.Show("sql hatası oluştu");
                throw;
            }
            finally // hata çıksada çıkmasada finally bloğu içerisindeki kodlar çalıştırılır...
            {
                cmd.Connection.Close();
            }
            return dt;
        }

        public static int MyExecuteNonQuery(string commandText)
        {
            //bu metodda sql connection ister
            SqlCommand cmd = CreateCommand(commandText);
            int affected = 0;
            try
            {
                cmd.Connection.Open();
                affected = cmd.ExecuteNonQuery();   // executenonquery insert,update,delete yaptığınız zaman kaç kayıt etkilendiyse onu dönüyor
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql hatası oluştu",ex.Message);
                throw;
            }
            finally
            {
                cmd.Connection.Close();

            }
            return affected;
        }
        
        // bu sınıf sayesinde benim insert,update,delete gii birçok işlemim çok basit düzeye gelicek


    }
}
