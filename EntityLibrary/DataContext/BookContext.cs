using EntityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityLibrary.DataContext
{
    public class BookContext :DbContext
    {
        public BookContext():base("name=DefaultConnection")
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}