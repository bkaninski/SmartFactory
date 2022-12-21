using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SmartFactory.Infrastructure.Configuration;
using SmartFactory.Infrastructure.Data.Configuration;

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
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new PositionConfiguration());
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new ShiftConfiguration());
            builder.ApplyConfiguration(new ProductionConfiguration());
            builder.ApplyConfiguration(new LeaveConfiguration());
            builder.ApplyConfiguration(new CareerConfiguration());
            builder.ApplyConfiguration(new RolesConfiguration());
            builder.ApplyConfiguration(new UsersRoleConfiguration());
            

            base.OnModelCreating(builder);
        }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Production> Productions { get; set; }

        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Career> Careers { get; set; }
    }
}