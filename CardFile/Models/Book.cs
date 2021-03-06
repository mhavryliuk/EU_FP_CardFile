﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CardFile.Models
{
    // Required - поле обязательное для заполнения
    // Range - диапазон допустимых значений для поля ввода
    // StringLength - допустимая длина слова для поля ввода

    public class Book
    {
        [HiddenInput(DisplayValue = false)]           // Скрываем поле BookId
        public int BookId { get; set; }               // ISBN книги

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле Название обязательно для заполнения")]
        public string BookTitle { get; set; }         // Название книги

        [Display(Name = "Автор")]
        [Required(ErrorMessage = "Поле Автор обязательно для заполнения")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Поле может вмещать от 3 до 15 символов")]
        public string BookAuthor { get; set; }        // Автор книги

        [Display(Name = "Соавторы")]
        public string BookCoAuthors { get; set; }     // Соавторы книги

        [Display(Name = "Издательство")]
        [StringLength(25, ErrorMessage = "Название издательства не может привышать 25 символов")]
        public string Publisher { get; set; }         // Издательство

        [Display(Name = "Год издания")]
        [Range(1900, 2018, ErrorMessage = "Значение поля Год издания должно попадать в диапазон от 1900 до 2018")]
        public int? YearPublication { get; set; }     // Год издания книги

        [Display(Name = "Кол-во страниц")]
        public int? PageCount { get; set; }           // Количество страниц

        [Display(Name = "Описание книги")]
        [Required(ErrorMessage = "Поле Описание книги обязательно для заполнения")]
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