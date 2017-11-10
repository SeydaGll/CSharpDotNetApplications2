using Coder.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Coder.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null); // bu get metodu tek bir tane varlık dönücek.. bunun için sorgulanabilir bir yapı olsun diye expression diyorum

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);



    }
}
