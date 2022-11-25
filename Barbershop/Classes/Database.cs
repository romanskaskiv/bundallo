using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop.Classes
{
    public class Database : DbContext {
        public DbSet<User> users { get; set; }
        public DbSet<Haircut> haircuts { get; set; }
        public DbSet<Order> orders { get; set; }
        public Database() {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=barbershop;Username=postgres;Password=12131415");
        }
    }
}
