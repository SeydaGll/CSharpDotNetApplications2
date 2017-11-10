using Ders.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders.Windows.WinAppUI
{
    public partial class FrmAddPerson : Form
    {
        public FrmAddPerson()
        {
            InitializeComponent();
        }

        private void FrmAddPerson_Load(object sender, EventArgs e)
        {
            cbbPhoneType.DataSource = Enum.GetValues(typeof(PhoneType));  // benim phonetype isimli combobox ın içerisine verileri koymak istiyorum. bunun için bu nesnenin data kaynağına şunu kulan diyorum yani = diyorum atama yapıyorum. kullancağın şeyi de bunun data kaynağı olucak şeye dönüştürmelisin.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbbPhoneType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
