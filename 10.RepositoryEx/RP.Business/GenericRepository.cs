using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RP.Business
{
    public class GenericRepository<T> where T : class
    {
        private RP.Data.RPData ctx;
        DbSet<T> objectSet;
        public GenericRepository()
        {
            objectSet = Ctx.Set<T>();
        }


        public RP.Data.RPData Ctx
        {
            get
            {
                if (ctx == null)  // hafızada yoksa türet
                    ctx = new RP.Data.RPData();
                    return ctx;
            }

        }

       public IEnumerable<T> GetAll()
        {
            
            return objectSet.ToList();   // burda hata verdi. çünkü win katmanına da entity framework ü kurmam lazım!
        }

       public IEnumerable<T> GetByFilter(Expression<Func<T,bool>> filter)
        {
            /*var query = db.Where(q=>q.ProductName=="iphone")    ben q=>q.ProductName=="iphone" bu geçen sorguyu metodumdan içeriye parametre olarak almak istiyorum.. bunun için data .net in 3.5 versiyonuyla gelen expressoindan faydalanıcam*/
            
            if (filter==null)
            {
                return objectSet.ToList();
            }
            return objectSet.Where(filter);
        }

        public void Add(T entity)
        {
            objectSet.Add(entity);
            Ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            objectSet.Remove(entity);
            Ctx.SaveChanges();
        }

        public void DeleteRange(IEnumerable<T> entityList)
        {
            objectSet.RemoveRange(entityList);
            Ctx.SaveChanges();
        }


        public void Delete(int id)
        {
            var entityToDelete =  objectSet.Find(id);
            objectSet.Remove(entityToDelete);
            Ctx.SaveChanges();
        }

        



    }
}
