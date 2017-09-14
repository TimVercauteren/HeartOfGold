using BudgetMiner.DataAccess.Entities;
using System.Data.Entity;

namespace BudgetMiner.DataAccess
{
    public class EntityContext : DbContext
    {
        public EntityContext() : base("name=EntityContext"){}
        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<BaseMaintenance> BaseMaintenance { get; set; }
        public virtual DbSet<BaseMaintenanceCycle> BaseMaintenanceCycle { get; set; }
        public virtual DbSet<BaseManagement> BaseManagement { get; set; }
        public virtual DbSet<Function> Function { get; set; }
        public virtual DbSet<HelpDeskUsers> HelpDeskUsers { get; set; }
        public virtual DbSet<LicenseComponent> LicenseComponents { get; set; }
        public virtual DbSet<Licensing> Licesing { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<MaintenanceComponent> MaintenanceComponent { get; set; }
        public virtual DbSet<TeamCost> TeamCost { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Config for lowercase properties in DB
            modelBuilder.Properties().Configure(c =>
            {
                var name = c.ClrPropertyInfo.Name;
                var newName = name.ToLower();
                c.HasColumnName(newName);
            });

            var applicationBuilder = modelBuilder.Entity<Application>();
            //
            var baseMaintenanceBuilder = modelBuilder.Entity<BaseMaintenance>();
            //
            var baseMaintenanceCycleBuilder = modelBuilder.Entity<BaseMaintenanceCycle>();
            //
            var baseManagementBuilder = modelBuilder.Entity<BaseManagement>();
            //
            var functionBuilder = modelBuilder.Entity<Function>();
            //
            var helpDeskUserBuilder = modelBuilder.Entity<HelpDeskUsers>();
            //
            var licenseComponentBuilder = modelBuilder.Entity<LicenseComponent>();
            //
            var licensingBuilder = modelBuilder.Entity<Licensing>();
            //
            var maintenanceBuilder = modelBuilder.Entity<Maintenance>();
            //
            var maintenanceComponentBuilder = modelBuilder.Entity<MaintenanceComponent>();
            //
            var teamCostComponentBuilder = modelBuilder.Entity<TeamCost>();
            //

        }
    }
}
