using BudgetMiner.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
{
    interface IYearCostReader
    {
        Task<IEnumerable<YearCost>> GetAll();
        Task<YearCost> Get(int id);
    }
}
