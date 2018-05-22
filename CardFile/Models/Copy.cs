using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CardFile.Models
{
    public class Copy
    {
        [HiddenInput(DisplayValue = false)]
        public int CopyId { get; set; }         // Инвентарный № книги

        [HiddenInput(DisplayValue = false)]
        public int? BookId { get; set; }        // (FK) ISBN книги

        [Display(Name = "Дата взятия книги")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BegDate { get; set; }   // Дата взятия книги

        [Display(Name = "Дата, когда должна быть возвращена книга")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }   // Дата, когда должна быть возвращена книга

        [Display(Name = "№ читательского билета")]
        public int? UserId { get; set; }        // (FK) № читательского билета

        // Навигационные свойства
        public Book Book { get; set; }
        public User User { get; set; }
    }
}