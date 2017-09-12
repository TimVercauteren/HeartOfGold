namespace BudgetMiner.DataAccess.Entities
{
    public class LicenseComponent : EntityBase
    {
        public string Name { get; set; }
        public decimal LicenseCost { get; set; }
        public decimal? Y1 { get; set; }
        public decimal? Y2 { get; set; }
        public decimal? Y3 { get; set; }
        public decimal? Y4 { get; set; }
        public decimal? Y5 { get; set; }

    }
}