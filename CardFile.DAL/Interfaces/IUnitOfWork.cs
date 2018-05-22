using System;
using CardFile.DAL.Entities;

namespace CardFile.DAL.Interfaces
{
    /// <summary>
    /// В связи с использованием нескольких репозиториев для каждой сущности,
    /// для упрощения использования подключения к БД используется паттерн Unit Of Work.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Book> Books { get; }
        IRepository<Copy> Copies { get; }
        IRepository<User> Users { get; }
        void Save();
    }
}