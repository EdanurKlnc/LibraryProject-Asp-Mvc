using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book { 
                    Id = 1,
                    Title="deneme kitap",
                    Author="Edanur kılınç",
                    PublicationDate= DateTime.Now,
                    PageCount=100,
                }
                );
        }
    }
}
