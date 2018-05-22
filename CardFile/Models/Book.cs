using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CardFile.Models
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]           // Скрываем поле BookId
        public int BookId { get; set; }               // ISBN книги

        [Display(Name = "Название")]
        [Required]
        public string BookTitle { get; set; }         // Название книги

        [Display(Name = "Автор")]
        [Required]
        public string BookAuthor { get; set; }        // Автор книги

        [Display(Name = "Соавторы")]
        public string BookCoAuthors { get; set; }     // Соавторы книги

        [Display(Name = "Издательство")]
        public string Publisher { get; set; }         // Издательство

        [Display(Name = "Год издания")]
        public int? YearPublication { get; set; }     // Год издания книги

        [Display(Name = "Кол-во страниц")]
        public int? PageCount { get; set; }           // Количество страниц

        [Display(Name = "Описание книги")]
        [Required]
        public string Description { get; set; }       // Описание книги

        public ICollection<Copy> Copies { get; set; }

        public Book()
        {
            // Значения по умолчанию.
            BookTitle = "Заголовок не указан";
            BookAuthor = "Автор не указан";
            BookCoAuthors = "Соавтор не указан";
            Publisher = "Издатель не указан ";
            Description = "Описание отсутствует";

            // Навигационное свойство
            Copies = new List<Copy>();
        }
    }
}