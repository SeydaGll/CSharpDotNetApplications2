using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetGiris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Yenile();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {                                                     // benzersiz ister. biz şimdilik companyname in ilk 5 karaterini al diyoruz
            string cmdText = $"INSERT INTO Customers VALUES('{txtContactName.Text.Substring(0,5)}','{txtCompanyName.Text}','{txtContactName.Text}','{txtContactTitle.Text}','{txtAddress.Text}','{txtCity.Text}','{txtRegion.Text}','{txtPostalCode.Text}','{txtCountry.Text}','{txtPhone.Text}','{txtFax.Text}')";
            DataLayer.MyExecuteNonQuery(cmdText);
            //veri eklendi ben bunu nasıl görcem.gridin yenilenmesi gerekiyor.yani verilerin tekrardan çekilmesi lazım
            //farklı yöntemleri var
            // burda kontrol edilmesi gerekiyor
            //eğer MyExecuteNonQuery den dönen kayıt 1 ise verieklenmiş demektir.o zaman aynıveriyi al gridin en altınada ekle. normalde doğru olan yötem budur. 
            // normalde ben yapmış olduğun işlemde veriyi eklmek için bir sql sorgusu göndercem sonraısnda veriyi göstermek bir sql sorguus daha çalıştırcam.
            Yenile();
        }

        void Yenile()
        {
            grdCustomers.DataSource = DataLayer.MyExecuteReader("SELECT*FROM Customers");
        }


    }
}
