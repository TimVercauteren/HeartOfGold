using BudgetMiner.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Writers
{
    interface IComponentWriter
    {
        Task Insert(Component component);
        Task Update(Component component, int id);
    }
}
