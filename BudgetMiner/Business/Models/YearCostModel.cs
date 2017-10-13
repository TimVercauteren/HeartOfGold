using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Models
{
    public class YearCostModel : ModelBase
    {
        public int Year { get; set; }
        public decimal LicenseDepreciation { get; set; }
        public decimal MaintenanceCost { get; set; }
    }
}
