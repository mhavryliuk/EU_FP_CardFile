using CardFile.DAL.Interfaces;
using CardFile.DAL.Repositories;
using Ninject.Modules;

namespace CardFile.BLL.Infrastructure
{
    /// <summary>
    /// ServiceModule представляет специальный модуль Ninject, который служит для организации сопоставления зависимостей.
    /// В частности, он устанавливает использование EFUnitOfWork в качестве объекта IUnitOfWork.
    /// </summary>
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        /// <inheritdoc />
        /// <summary>
        /// Конструктор принимающий название подключения, которое будет определяться в файле web.config проекта, представляющего уровень представления.
        /// </summary>
        /// <param name="connection">Название подключения.</param>
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}