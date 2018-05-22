using System;
using System.Collections.Generic;

namespace CardFile.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс репозиториев IRepository, который используется для увеличения гибкости подключения к БД.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
