using g181210044_g191210044.Entity;
using Microsoft.EntityFrameworkCore;

namespace g181210044_g191210044.Data
{
    public class SporContext:DbContext
    {
        public SporContext(DbContextOptions<SporContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<BlogYazari> BlogYazari { get; set; }
        public DbSet<BlogYazisi> BlogYazisi { get; set; }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = sporSitesi.db");
        }
    }
}
