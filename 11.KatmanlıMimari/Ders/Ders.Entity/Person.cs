using System;
using System.Collections.Generic; 
using Ders.Core;

namespace Ders.Entity
{
    public class Person:EntityBase
    {
        public Person()
        {
            Phones = new List<Phone>();
           Addresses = new List<Address>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
