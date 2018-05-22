using System;
using System.Data.Entity;
using CardFile.DAL.Entities;

namespace CardFile.DAL.EF
{
    /// <summary>
    /// Класс контекста данных.
    /// </summary>
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Статический конструктор контекста, который содержит инициализатор БД.
        /// </summary>
        static LibraryContext()
        {
            Database.SetInitializer<LibraryContext>(new LibraryDbInitializer());
        }

        /// <summary>
        /// Конструктор контекста.
        /// </summary>
        /// <param name="connectionString">Строка подключения.</param>
        public LibraryContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    /// <summary>
    /// Класс DropCreateDatabaseAlways позволяет при каждом новом запуске заполнять базу данных заново некоторыми начальными данными.
    /// При отсутствии необходимости, отключить автозапуск при старте приложения в файле Global.asax
    /// </summary>
    public class LibraryDbInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext db)
        {
            // ********** Инициализация БД Книгами ********** //
            db.Books.Add(new Book
            {
                BookTitle = "CLR via C#.",
                BookAuthor = "Джеффри Рихтер",
                Publisher = "Питер",
                YearPublication = 2018,
                PageCount = 896,
                Description = "Книга подробно описывает внутреннее устройство и функционирование общеязыковой исполняющей среды (CLR) Microsoft .NET Framework версии 4.5."
            });

            db.Books.Add(new Book
            {
                BookTitle = "Фантомас",
                BookAuthor = "Пьер Сувестр",
                BookCoAuthors = "Марсель Аллен",
                Publisher = "Радуга",
                YearPublication = 1991,
                PageCount = 232,
                Description = "Эта книга начинает публикацию серии романов о неуловимом Фантомасе."
            });

            db.Books.Add(new Book
            {
                BookTitle = "Nudge. Архитектура выбора.",
                BookAuthor = " Ричард Талер",
                BookCoAuthors = "Касс Санстейн",
                Publisher = "Манн, Иванов и Фербер",
                YearPublication = 2017,
                PageCount = 240,
                Description = "Международный бестселлер в лучших традициях фрикономики и исследований Гладуэлла — о том, как мы принимаем решения и делаем выбор и как можно помогать людям принимать лучшие решения."
            });

            //db.Books.Add(new Book {
            //BookTitle = "",
            //BookAuthor = "",
            //BookCoAuthors = "",
            //Publisher = "",
            //YearPublication = ,
            //PageCount = ,
            //Description = "" });

            db.SaveChanges();


            // ********** Инициализация БД Пользователями ********** //
            db.Users.Add(new User
            {
                FullName = "Пантелеев Вадим Петрович",
                Birthday = DateTime.Parse("1985.11.02"),
                HomeAddress = "Киев, пр. Гонгадзе 7, кв. 23",
                HomePhone = "753-29-84"
            });

            db.Users.Add(new User
            {
                FullName = "Селезнева Алиса Эдуардовна",
                Birthday = DateTime.Parse("1999.03.25"),
                HomeAddress = "Киев, ул. Гагарина, 25Г, кв. 9",
                HomePhone = "433-87-63"
            });

            //db.Users.Add(new User { FullName = "", Birthday = DateTime.Parse(""), HomeAddress = "", HomePhone = ""});

            db.SaveChanges();


            // ********** Инициализация БД Экземплярами ********** //
            db.Copies.Add(new Copy { BookId = 1, BegDate = DateTime.Parse("2018.05.14"), EndDate = DateTime.Parse("2018.05.29"), UserId = 1 });
            db.Copies.Add(new Copy { BookId = 3, BegDate = DateTime.Parse("2018.04.30"), EndDate = DateTime.Parse("2018.06.22"), UserId = 2 });

            //db.Copies.Add(new Copy { BookId = , BegDate = DateTime.Parse(""), EndDate = DateTime.Parse(""), UserId = });

            db.SaveChanges();

            base.Seed(db);
        }
    }
}
