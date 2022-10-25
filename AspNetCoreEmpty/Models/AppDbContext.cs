using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpty.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pie> Pie { get; set; }
        public DbSet<Category> Category { get; set; }






    }
}
