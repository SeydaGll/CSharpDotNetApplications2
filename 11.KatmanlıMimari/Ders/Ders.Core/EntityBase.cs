using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders.Core
{
    public class EntityBase
    {
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public int CreateUserId { get; set; } = -1;
        public int ModifiedUSerId { get; set; } = -1;
    }
}
