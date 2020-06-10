using CrmDL.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;

namespace CrmDL.EF
{
    public class Context: ApiAuthorizationDbContext<ApplicationUser>
    {
        public Context(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder
                .Entity<Product>()
                .HasOne(u => u.Brand)
                .WithMany(m => m.Products)
                .HasForeignKey(p => p.BrandId);
        */
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryStatus> DeliveryStatuses { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

    }
}
