using Microsoft.EntityFrameworkCore;

namespace CrmBL.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CRM;Trusted_Connection=True;");
        }

        public DbSet<Check> Checks { get; set;}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }

    }
}
