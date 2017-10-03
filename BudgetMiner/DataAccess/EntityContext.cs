using BudgetMiner.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetMiner.DataAccess
{
    public class EntityContext : DbContext
    {
        public DbSet<DataAccess.Entities.System> Systems { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<HostingType> HostingTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<FTE> FTEs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var systemBuilder = modelBuilder.Entity<DataAccess.Entities.System>()
                .HasOne(s => s.Department)
                .WithOne(d => d.System)
                .HasForeignKey("SystemId"); //toDo check 


                
        }
    }
}
