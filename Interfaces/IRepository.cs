using System.Collections.Generic;

namespace Series.Interface{
    public interface IRepository<T>{
        List<T> Lista();
        T ReturnWithId (int id);
        void Insert(T entity);
        void Delete(int id);
        void Refresh (int id, T entity);
        int NextId();
    }
}