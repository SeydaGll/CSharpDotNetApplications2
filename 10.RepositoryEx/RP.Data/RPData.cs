using RP.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.Data
{
    public class RPData:DbContext
    {
        public RPData()
            :base("Server=.;Database=RPData;User Id=sa;Password=54321a!")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
