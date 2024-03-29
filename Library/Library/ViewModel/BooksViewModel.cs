﻿using Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.ViewModel
{
    public class BooksViewModel
    {
        public List<Book> Books { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public string Category { get; set; }
    }
}
