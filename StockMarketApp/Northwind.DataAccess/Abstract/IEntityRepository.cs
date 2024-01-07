using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        void Update(T entity);
        void Delete(T entity);
        void Add(T  entity);
        T Get(Expression<Func<T, bool>> filter);

    }
}
