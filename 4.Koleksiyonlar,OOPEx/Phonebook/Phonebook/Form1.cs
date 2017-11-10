using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form  // ağırlıklı olarak  buranın altına biz kodlar yazabiliyorux 
    {
        public Form1()
        {
            InitializeComponent();

            Person person    = new Person();
            person.Name = "Ahmet";
            person.Surname = "Bircan";
            Phones phone = new Phones()
            {
                AreaCode = "5320",
                PhoneNumber = "2587456",
                PhoneType = PhoneType.GSM
            };
            Phones phone2 = new Phones()
            {
                AreaCode = "5453",
                PhoneNumber = "9865443",
                PhoneType = PhoneType.FAX
            };
            person.Phone.Add(phone);
            person.Phone.Add(phone2);
        }
    }
}
