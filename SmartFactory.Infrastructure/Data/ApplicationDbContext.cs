using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartFactory.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Production> Productions { get; set; }

        public DbSet<Leave> Leaves { get; set; }
    }
}