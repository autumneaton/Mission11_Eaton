﻿using Microsoft.EntityFrameworkCore;

namespace Mission11_Eaton.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
