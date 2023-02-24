using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entites;

namespace WebApplication1.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(b =>
            { 
                b.ToTable("tbl_Book");
                b.HasKey("Id");
            });
            /*modelBuilder.Entity<Author>(a =>
            {
                a.ToTable("tbl_Author");
                a.HasKey("Id");
            });*/
        }
    }
}
