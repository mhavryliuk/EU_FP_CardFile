using System;
using CardFile.DAL.EF;
using CardFile.DAL.Entities;
using CardFile.DAL.Interfaces;

namespace CardFile.DAL.Repositories
{
    /// <inheritdoc />
    /// <summary>
    /// Класс EFUnitOfWork служит для взаимодействия с БД.
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext db;
        private BookRepository bookRepository;
        private CopyRepository copyRepository;
        private UserRepository userRepository;

        /// <summary>
        /// Конструктор класса EFUnitOfWork, который принимает строку с названием подключения.
        /// </summary>
        /// <param name="connectionString">Строка с названием подключения.</param>
        public EFUnitOfWork(string connectionString)
        {
            db = new LibraryContext(connectionString);
        }

        public IRepository<Book> Books => bookRepository ?? (bookRepository = new BookRepository(db));

        public IRepository<Copy> Copies => copyRepository ?? (copyRepository = new CopyRepository(db));

        public IRepository<User> Users => userRepository ?? (userRepository = new UserRepository(db));

        #region IDisposable Support

        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        public void Save()
        {
            db.SaveChanges();
        }
    }
}