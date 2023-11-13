using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    // Ortak alanların tutulduğu yer
    public interface IEntityBaseRepository<T>where T :class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>filter=null);
        // context.set<Product>().where(p=>p.ProductId<5).ToList()
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
