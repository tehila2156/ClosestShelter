using core.Models;
using Microsoft.EntityFrameworkCore;

namespace Dal_Repository_Infrastracture
{
    public class Context : DbContext
    {
        // קונסטרקטור ריק – נדרש בזמן עיצוב
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=TEHILA;Database=Tehila_locations_and_structure;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        public DbSet<Address> Adress { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<StructureType> StructureTypes { get; set; } = default!;
    }
}
