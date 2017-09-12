using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.Entities
{
    public class BaseManagement : EntityBase
    {
        public BaseMaintenance BaseMaintenanceCycle {get;set;}
        public HelpDeskUsers HelpDeskUsers { get; set; }

    }
}
