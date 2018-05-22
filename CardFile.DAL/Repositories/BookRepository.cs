using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardFile.DAL.EF;
using CardFile.DAL.Entities;
using CardFile.DAL.Interfaces;

namespace CardFile.DAL.Repositories
{
    /// <summary>
    /// Класс репозитория для книг.
    /// </summary>
    public class BookRepository : IRepository<Book>
    {
        private LibraryContext db;

        public BookRepository(LibraryContext context)
        {
            db = context;
        }


        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Find(Func<Book, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Book item)
        {
        }

        public void Update(Book item)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
