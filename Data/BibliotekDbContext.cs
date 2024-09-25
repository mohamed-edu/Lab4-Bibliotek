using Lab4_Bibliotek.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4_Bibliotek.Data
{
    public class BibliotekDbContext:DbContext
    {
        public BibliotekDbContext(DbContextOptions<BibliotekDbContext> options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Books)
                .WithMany(b => b.Customers)
                .UsingEntity(j => j.ToTable("CustomerBooks"));
        }
    }
}
