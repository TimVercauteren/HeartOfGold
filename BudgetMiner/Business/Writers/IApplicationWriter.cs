using BudgetMiner.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Writers
{
    interface IApplicationWriter
    {
        Task Insert(Application application);
        Task Update(Application application, int id);
    }
}
