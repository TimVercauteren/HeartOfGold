using HeartOfGold.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using HeartOfGold.Business.Models;

namespace HeartOfGold.DataAccess
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbContextOptions options) : base(options) { }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<YearCost> YearlyCosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var appBuilder = modelBuilder.Entity<Application>();
            appBuilder.HasKey(a => a.Id);
            //toDo::Configure Properties

            var componentBuilder = modelBuilder.Entity<Component>();
            componentBuilder.HasKey(c => c.Id);
            componentBuilder
                .HasOne(c => c.Application)
                .WithMany(a => a.Components)
                .HasForeignKey(c => c.ApplicationId);
            //toDo:: Configure properties

            var yearlyCostBuilder = modelBuilder.Entity<YearCost>();
            yearlyCostBuilder.HasKey(yc => yc.Id);
            yearlyCostBuilder
                .HasOne(yc => yc.Component)
                .WithMany(c => c.YearlyCosts)
                .HasForeignKey(yc => yc.ComponentId);
            //toDO:: Configure Properties
        }

        public DbSet<HeartOfGold.Business.Models.ApplicationModel> ApplicationModel { get; set; }

        public DbSet<HeartOfGold.Business.Models.ComponentModel> ComponentModel { get; set; }

        public DbSet<HeartOfGold.Business.Models.YearCostModel> YearCostModel { get; set; }

    }
}
