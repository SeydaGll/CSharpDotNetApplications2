using Coder.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Coder.DataAccess.Abstract;

namespace Coder.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        //dependence injection
        private ICategoryDAL _categoryDal;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDal = categoryDAL;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
