using Ders.Core;
using System;
 

namespace Ders.Entity
{
   public class Phone:EntityBase
    {

        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType:byte
    {
        Work=1,
        Home=2,
        GSM,
        Fax
    }
}
