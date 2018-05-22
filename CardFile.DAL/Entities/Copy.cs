using System;

namespace CardFile.DAL.Entities
{
    public class Copy
    {
        public int CopyId { get; set; }         // Инвентарный № книги
        public int? BookId { get; set; }        // (FK) ISBN книги
        public DateTime BegDate { get; set; }   // Дата взятия книги
        public DateTime EndDate { get; set; }   // Дата, когда должна быть возвращена книга
        public int? UserId { get; set; }        // (FK) № читательского билета
    }
}
