using System;

namespace CardFile.DAL.Entities
{
    public class User
    {
        public int UserId { get; set; }           // № читательского билета
        public string FullName { get; set; }      // ФИО читателя
        public DateTime Birthday { get; set; }    // Дата рождения
        public string HomeAddress { get; set; }   // Домашний адрес
        public string HomePhone { get; set; }     // № домашнего телефона
    }
}
