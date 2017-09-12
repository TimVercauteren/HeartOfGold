using System.Collections.Generic;

namespace BudgetMiner.DataAccess.Entities
{
    public class Licensing : EntityBase
    {
        public List<LicenseComponent> Components { get; set; }
        public string BudgetOwner { get; set; }
    }
}