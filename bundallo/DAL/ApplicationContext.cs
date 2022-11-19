using Microsoft.EntityFrameworkCore;
 
namespace bundallo
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=BundalloDB;Username=postgres;Password=postgres");
        }
    }
}