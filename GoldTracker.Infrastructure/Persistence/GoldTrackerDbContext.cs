using GoldTracker.Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace GoldTracker.Infrastructure.Persistence
{
    public class GoldTrackerDbContext : DbContext
    {
        public GoldTrackerDbContext(DbContextOptions<GoldTrackerDbContext> options) : base(options)
        {
        }
        public DbSet<GoldPriceEtlLogs> GoldPriceEtlLogs { get; set; }
        public DbSet<GoldProduction> GoldProductions { get; set; }
        public DbSet<GoldSource> GoldSources { get; set; }
        public DbSet<GoldPrice> GoldPrices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GoldPriceEtlLogs>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<GoldProduction>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<GoldSource>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<GoldPrice>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
    }
}
