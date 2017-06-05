using DomainData;
using System.Collections.Generic;

namespace DomainRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
    }
}
