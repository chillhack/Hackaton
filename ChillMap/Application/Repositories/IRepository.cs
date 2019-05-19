using System;
using System.Collections.Generic;

namespace ChillMapWeb.Repositories
{
    public interface IRepository<T>
    {
        List<T> Get();
        T GetById(Guid id);
        void Remove(Guid id);
        void Remove(T elem);
        T Create(T elem);
    }
}