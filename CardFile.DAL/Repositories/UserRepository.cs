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
    /// Класс репозитория для пользователей.
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        private LibraryContext db;

        public UserRepository(LibraryContext context)
        {
            db = context;
        }
        

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }
        
        public void Create(User item)
        {
        }

        public void Update(User item)
        {
        }

        public void Delete(int id)
        {
        }
    }
}