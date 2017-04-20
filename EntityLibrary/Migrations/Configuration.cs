namespace EntityLibrary.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityLibrary.DataContext.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityLibrary.DataContext.BookContext context)
        {

            var Book = new System.Collections.Generic.List<Models.Book>
                {
                    new Models.Book{Title="Bluebeard", Author="Kurt Vonnegut", YearPublished=1987, Genre="Classics", IsCheckedOut=true,}
                };
            context.Book.AddOrUpdate(a => a.Title, Book.First());
            context.SaveChanges();
        }
    }
}
