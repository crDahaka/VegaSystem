namespace VegaSystem.Persistence
{
    using Microsoft.EntityFrameworkCore;
    using VegaSystem.Models;

    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options) { }

        public DbSet<Make> Makes { get; set; }
    }
}