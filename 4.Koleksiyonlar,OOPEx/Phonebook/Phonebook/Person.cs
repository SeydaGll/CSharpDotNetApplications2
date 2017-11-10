using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Person
    {
        public Person()
        {
            Phone = new List<Phones>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Phones>  Phone { get; set; }
        public override string ToString()
        {
            return Name +" " + Surname;
        }
        
    } 
 
   
}
