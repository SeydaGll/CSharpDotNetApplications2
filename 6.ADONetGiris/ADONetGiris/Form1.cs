using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
          {
        //    string cnnStr = "Server = 192.168.1.112;Initial Catalog = NORTHWND;user id=sa;password=123456a!";
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = cnnStr;
        //    connection.Open(); // köprü yolu açıldı. unutulmamalıdır.

        //    SqlCommand command = new SqlCommand();
        //    command.Connection = connection; // sqlcmment bu yolu kullanıcak
        //    command.CommandText = "SELECT ContactName FROM Customers";
        //    //command.Connection


        //    SqlDataReader rd = command.ExecuteReader();  //executereader size senin komutu karşı tarafta execute edip sonucu çalıştırı sana getiriyor..

        //    while (rd.Read())  // içerisine true yada false dönecek bşr koşul gerekli. read metodu 
        //    {
        //        lbxCustomers.Items.Add(rd["ContactName"]);
        //    }
        //    // while için içerisine true yada false dönecek bir koşul gerekli. read()  metodu 
        //    //Read() komutu eğer satır bulabilmişse o satıra geçer ve geriye true sonucu döndürür.  

        //    rd.Close();         //reader online olarak çalışır. her sorguda gidip sql servea bağlanır sonucu getiri. canlı calışır veri tabanıyla..
        //    connection.Close();  // bu kapatmalısın. ram den getirmiyo her seferinde sql den getiriyo

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  // verileri rame yükleyip ramden verileri alma. yani bir defa sql den verileri çek onu ram e yükle ordan verileri al.. yani sql i yorma performansı artır
        {
            ////connection string, sql connection, sql command, ..
            //SqlConnection connection = new SqlConnection("Server = 192.168.1.112;Initial Catalog = NORTHWND;user id=sa;password=123456a!");
            //connection.Open();

            //SqlCommand command = new SqlCommand("SELECT ContactName FROM Customers", connection);

            //DataTable dt = new DataTable();// Datatable sql server daki tablolarınızı ram üzerinde saklmak üzere yada ordan tablo şeklinde dönen sonuçlarınızı ram üzerinde saklamak üzere geliştirilmiş üzere geliştirilmiş nesne
            //dt.Load(command.ExecuteReader());  //datareader nesnesini load metodu kendi içerisinden okuyup datatable e dolduruyor. artık data table ın içrisinde

            
            //// şimdi verilerimi alıcam
            //foreach (DataRow row in dt.Rows)   // rows koleksiyonunda gez..her rows datarowscollection ı ise her gelen de bir datarow dur.. yani her gelen satır
            //{
            //    lbxCustomers.Items.Add(row.ItemArray[0]);   //sizin çalıştırdığınız sorgu sonucunda size satırlar ve sütunlar gelir.. ben birinci satrdaysam hangi sütunla kesisen veriyi alıcağımı söylemeliyim.. rows içerisinde yani satırların içerisinde döngü kurduğum için bu döngünün her bir adımında bir tane satır ele alınır. peki ben bu satırdaki verilerden hangi sütunu istiyorum bildirmeliyim!!
                
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // datalayer katmanımda veriyi select sorgusuyla getiricek olan myexecutereader() metodu..geriye datatable dönüyor
            DataTable dt = DataLayer.MyExecuteReader("SELECT ContactName FROM Customers");

            foreach (DataRow row in dt.Rows)
            {
                lbxCustomers.Items.Add(row.ItemArray[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();



        }
    }
}
