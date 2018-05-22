namespace CardFile.DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }               // ISBN книги
        public string BookTitle { get; set; }         // Название книги
        public string BookAuthor { get; set; }        // Автор книги
        public string BookCoAuthors { get; set; }     // Соавторы книги
        public string Publisher { get; set; }         // Издательство
        public int? YearPublication { get; set; }     // Год издания книги
        public int? PageCount { get; set; }           // Количество страниц
        public string Description { get; set; }       // Описание книги
    }
}
