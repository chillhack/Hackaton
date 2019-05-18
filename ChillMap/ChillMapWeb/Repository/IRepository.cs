using System;
using System.Collections.Generic;
using ChillMapWeb.Entities;

namespace ChillMapWeb.Repository
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