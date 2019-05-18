using System.Collections.Generic;

namespace ChillMapWeb.Repositories
{
    public interface IRepository<T>
    {
        List<T> Get();
        T GetById(string id);
        void Remove(string id);
        void Remove(T elem);
        T Create(T elem);
    }
}