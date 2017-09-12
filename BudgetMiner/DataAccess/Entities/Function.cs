
namespace BudgetMiner.DataAccess.Entities
{
    public class Function : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal BaseJunior { get; set; }
        public decimal BaseMedior { get; set; }
        public decimal BaseSenior { get; set; }
        public decimal AnnualIncrease { get; set; }
        public Seniority MyProperty { get; set; }
    }
    public enum Seniority
    {
        Junior,
        Medior,
        Senior
    }
}