using System;

namespace CardFile.BLL.DTO
{
    /// <summary>
    /// Промежуточная сущность.
    /// Через класс UserDTO мы будем передавать объекты пользователей между уровнями.
    /// </summary>
    public class UserDTO
    {
        public int UserId { get; set; }           // № читательского билета
        public string FullName { get; set; }      // ФИО читателя
        public DateTime Birthday { get; set; }    // Дата рождения
        public string HomeAddress { get; set; }   // Домашний адрес
        public string HomePhone { get; set; }     // № домашнего телефона
    }
}