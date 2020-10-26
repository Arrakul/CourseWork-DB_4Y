using System.Data.Entity;

namespace CrmBL.Model
{
    public class CrmContext : DbContext
    {
        public CrmContext() : base("CrmConnectionString") { }

        public DbSet<Chek> Cheks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }
}
