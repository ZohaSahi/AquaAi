using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AquaAi.shared.Models;
using static MudBlazor.Icons;

namespace AquaAi.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ApplicationUser> User { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetails> BillDetails { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public DbSet<Product> Inventory { get; set; }
        public DbSet<Liquid> Liquid { get; set; }
        public DbSet<SensorData> SensorData { get; set; }
        public DbSet<SensorKit> SensorKit { get; set; }
    }
}
