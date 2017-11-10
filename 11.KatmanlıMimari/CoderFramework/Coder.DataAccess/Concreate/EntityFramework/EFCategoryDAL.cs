using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coder.Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Coder.DataAccess.Concreate.EntityFramework;
using Coder.DataAccess.Abstract;

namespace Coder.DataAccess.Concreate
{
    public class EFCategoryDAL: EFEntityRepositoryBase<Category,ApplicationDataContext>,ICategoryDAL//kategori nesnemizin temel operasyonlarını yürütücek olan arayüzü tanıtıcak
    {

    }
}
