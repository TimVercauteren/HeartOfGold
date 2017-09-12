using System.Collections.Generic;

namespace BudgetMiner.DataAccess.Entities
{
    public class BaseMaintenance
    {
        public string ProcesDescription { get; set; }
        public string BudgetOwner { get; set; }
        public IEnumerable<BaseMaintenanceCycle> Cycles { get; set; }
    }
}