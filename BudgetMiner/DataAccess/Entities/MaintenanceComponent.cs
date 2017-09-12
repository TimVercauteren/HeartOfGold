namespace BudgetMiner.DataAccess.Entities
{
    public class MaintenanceComponent: EntityBase
    {
        public string Component { get; set; }
        public decimal MaintenanceCost { get; set; }
    }
}