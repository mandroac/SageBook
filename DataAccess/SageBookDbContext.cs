using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SageBookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Sage> Sages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-F0TNHT6\\MSSQLDEV; Database=SageBooks; Integrated Security=true; Trusted_Connection=true; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}