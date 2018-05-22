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
    /// Класс репозитория для экземпляров.
    /// </summary>
    public class CopyRepository : IRepository<Copy>
    {
        private LibraryContext db;

        public CopyRepository(LibraryContext context)
        {
            db = context;
        }


        public Copy Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Copy> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Copy> Find(Func<Copy, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Create(Copy item)
        {
        }

        public void Update(Copy item)
        {
        }

        public void Delete(int id)
        {
        }
    }
}