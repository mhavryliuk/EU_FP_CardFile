namespace CardFile.BLL.DTO
{
    /// <summary>
    /// Промежуточная сущность.
    /// Через класс BookDTO мы будем передавать объекты книг между уровнями.
    /// </summary>
    public class BookDTO
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