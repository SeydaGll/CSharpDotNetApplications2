using Ders.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.MockDataBase
{
    public static  class Phonebook 
    {
         static Phonebook()
        {
            if (People==null) 
                People = new List<Person>();
            
        }
        public static List<Person> People { get; set; }

        
    }
}
