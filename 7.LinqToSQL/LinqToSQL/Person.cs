using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class Person
    {
        public Person()
        {
            Phones = new List<Phone>();  // null hatası almamak için
        }
        public string NameSurname { get; set; }

        public List<Phone> Phones { get; set; }


    }

    public class Phone
    {
        public string AreaCode { get; set; } //bir kişi ve kisinin içerisinde birden fazla telefon olabilcek

        public string PhoneNumber { get; set; }

    }
}
