using System.Collections.Generic;

namespace BudgetMiner.DataAccess.Entities
{
    public class Team : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<Function> Profiles { get; set; }
        public decimal AnnualTurnover { get; set; }
        public decimal HiringCost { get; set; }
        public decimal ExpectedTeamGrowth { get; set; }
        public decimal ManagementAllocation { get; set; }
    }
}
