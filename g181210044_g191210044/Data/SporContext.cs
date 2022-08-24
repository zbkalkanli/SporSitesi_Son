using g181210044_g191210044.Entity;
using Microsoft.EntityFrameworkCore;

namespace g181210044_g191210044.Data
{
    public class SporContext:DbContext
    {
        public SporContext(DbContextOptions<SporContext> options) : base(options)
        {

        }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<BlogYazari> BlogYazarlari { get; set; }
        public DbSet<BlogYazisi> BlogYazilari { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = sporSitesi.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }
    }
}
