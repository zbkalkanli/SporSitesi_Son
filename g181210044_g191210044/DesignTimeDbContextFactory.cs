using g181210044_g191210044.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace g181210044_g191210044
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SporContext>
    {
        public SporContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SporContext>();
            var connectionString = "Server= LAPTOP-IPMG3S6I\\MSSQLSERVER02; Database=SporDb; Trusted_Connection=True;";
            builder.UseSqlite(connectionString);
            return new SporContext(builder.Options);
        }
    }
}
