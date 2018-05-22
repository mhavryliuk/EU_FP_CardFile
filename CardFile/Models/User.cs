using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CardFile.Models
{
    // Связь один ко многим: Один читатель - много Экзепляров
    // Required - поле обязательное для заполнения
    // RegularExpression - регулярное выражение для проверки введенных данных

    public class User
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }           // № читательского билета

        [Display(Name = "ФИО читателя")]
        [Required(ErrorMessage = "Поле ФИО читателя обязательно для заполнения")]
        public string FullName { get; set; }      // ФИО читателя

        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Поле Дата рождения обязательно для заполнения")]
        public DateTime Birthday { get; set; }    // Дата рождения читателя

        [Display(Name = "Домашний адрес")]
        [Required(ErrorMessage = "Поле Домашний адрес обязательно для заполнения")]
        public string HomeAddress { get; set; }   // Домашний адрес читателя

        [Display(Name = "№ телефона")]
        [Required(ErrorMessage = "Поле № телефона обязательно для заполнения")]
        public string HomePhone { get; set; }     // № домашнего телефона

        public ICollection<Copy> Copies { get; set; }   // Коллекция Экземпляров связанных с Читателем.

        public User()
        {
            // Навигационное свойство
            Copies = new List<Copy>();  // Инициализируем пустым списком
        }
    }
}