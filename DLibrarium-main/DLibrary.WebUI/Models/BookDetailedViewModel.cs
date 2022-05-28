using System.Collections.Generic;
using BookStore.Domain.Entities;

namespace BookStore.WebUI.Models
{
    public class BookDetailedViewModel
    {
        public Book Books { get; set; }
        public string ReturnUrl { get; set; }
    }
}