using System.Collections.Generic;

namespace Task_8.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T item);
        List<T> GetAll();
        T GetById(int id);
        void Update(T item);
        void Delete(int id);
    }
}