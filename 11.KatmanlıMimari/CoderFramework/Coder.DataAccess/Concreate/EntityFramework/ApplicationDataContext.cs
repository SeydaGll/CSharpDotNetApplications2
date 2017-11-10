using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coder.DataAccess.Concreate.EntityFramework
{
    public class ApplicationDataContext:DbContext
    {
        public ApplicationDataContext()
            :base("Server=localhost;Database=CoderAppDb;User Id=sa;Password=54321!a")
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
