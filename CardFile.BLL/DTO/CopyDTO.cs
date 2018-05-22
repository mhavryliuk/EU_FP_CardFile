using System;

namespace CardFile.BLL.DTO
{
    /// <summary>
    /// Промежуточная сущность.
    /// Через класс CopyDTO мы будем передавать объекты экземпляров между уровнями.
    /// </summary>
    public class CopyDTO
    {
        public int CopyId { get; set; }         // Инвентарный № книги
        public int? BookId { get; set; }        // (FK) ISBN книги
        public DateTime BegDate { get; set; }   // Дата взятия книги
        public DateTime EndDate { get; set; }   // Дата, когда должна быть возвращена книга
        public int? UserId { get; set; }        // (FK) № читательского билета
    }
}