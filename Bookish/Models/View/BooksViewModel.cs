﻿using System.Collections.Generic;
using Bookish.Models.Database;

namespace Bookish.Models.View
{
    public class BooksViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}