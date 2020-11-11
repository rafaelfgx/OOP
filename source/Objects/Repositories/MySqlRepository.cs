using System.Collections.Generic;

namespace Objects
{
    public abstract class MySqlRepository<T> : IRepository<T>
    {
        public void Insert(T entity)
        {
            /// Implementation
        }

        public IEnumerable<T> List()
        {
            /// Implementation

            return new List<T>();
        }

        public T Select(int id)
        {
            /// Implementation

            return default;
        }

        public void Update(T entity)
        {
            /// Implementation
        }
    }
}
