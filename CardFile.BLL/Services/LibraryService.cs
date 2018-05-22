using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardFile.BLL.Interfaces;
using CardFile.DAL.Interfaces;

namespace CardFile.BLL.Services
{
    class LibraryService : ILibraryService
    {
        IUnitOfWork Database { get; set; }

        /// <summary>
        /// Конструктор класса LibraryService.
        /// </summary>
        /// <param name="uow">Объект IUnitOfWork, через который идет взаимодействие с уровнем DAL.</param>
        public LibraryService(IUnitOfWork uow)
        {
            Database = uow;
        }

        // Реализовать методы, которые будут описаны в интерфейсе ILibraryService!!!





        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
