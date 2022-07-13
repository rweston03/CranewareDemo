using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CraneWareDemo.Models
{
    public class Book
    {
        [Key]
        [Display(Name = "ID")]
        public int ID { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Book Author")]
        public string Author { get; set; }

        public Book(int iID, string sTitle, string sAuthor)
        {
            ID = iID;
            Title = sTitle;
            Author = sAuthor;
        }
    }
}