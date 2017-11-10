using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEFex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WinformDBContext db = new WinformDBContext();  /* datacontext sınıflarımızı biz bbu şekilde kullanmıyoruz..using bloğu içerisinde kullanıyoruz...
            //                                                biz bu datacontext i kullandık ve işi bittiğinde hafızadan da hemen silinmesini isteriz..çünkü yüklüce bir dosya  */
            //using (WinformDBContext db = new WinformDBContext()) // using den çıkınca ramden silinecek. datacontext Idisposeble almış yani ramden silinebilir diyo
            //{

            //}
            WinformDBContext db = new WinformDBContext();
            gridList.DataSource = (from q in db.Customers
                                  select new
                                  {
                                      CustomerId = q.CustomerId,
                                      NameSurname = q.Name + " " + q.Surname
                                  }).ToList();
            gridList.Columns[0].Visible = false;
            
        }
    }
}
