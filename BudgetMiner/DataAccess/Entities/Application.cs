using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.Entities
{
    public class Application : EntityBase
    {
        public string Description { get; set; }
        public Licensing Licensing { get; set; }
        public Maintenance Maintenance { get; set; }

    }
}
