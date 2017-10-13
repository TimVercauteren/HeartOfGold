using BudgetMiner.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
{
    public interface IComponentReader
    {
        Task<IEnumerable<Component>> GetAll();
        Task<Component> Get(int componentId);
    }
}
