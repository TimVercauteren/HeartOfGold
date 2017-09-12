using System.Collections.Generic;

namespace BudgetMiner.DataAccess.Entities
{
    public class Maintenance : EntityBase
    {
        public List<MaintenanceComponent> Components { get; set; }
        public string BudgetOwner { get; set; }
        public decimal YearlyIncrease { get; set; }
    }
}