namespace BudgetMiner.DataAccess.Entities
{
    public class HelpDeskUsers : EntityBase
    {
        public decimal HoursOfOperation { get; set; }
        public int NumberOfCalls { get; set; }
        public decimal TrendingGrowthDecline { get; set; }
        public string BudgetOwner { get; set; }
        public TeamCost TeamCost { get; set; }
    }
}