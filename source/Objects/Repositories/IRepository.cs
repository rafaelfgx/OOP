using System.Collections.Generic;

namespace Objects
{
    public interface IRepository<T>
    {
        void Insert(T entity);

        IEnumerable<T> List();

        T Select(int id);

        void Update(T entity);
    }
}
