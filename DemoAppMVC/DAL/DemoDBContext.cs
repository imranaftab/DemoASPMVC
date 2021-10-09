using System;
using System.Data.Entity;

namespace DemoAppMVC.DAL
{
    public class DemoDBContext : DbContext
    {
        public DemoDBContext() : base("DemoDbContext")
        {
        }
        public DbSet<BooksEntity> Books { get; set; }
    }
}
