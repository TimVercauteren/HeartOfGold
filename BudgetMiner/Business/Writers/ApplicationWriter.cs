using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetMiner.DataAccess.Entities;

namespace BudgetMiner.Business.Writers
{
    public class ApplicationWriter : IApplicationWriter
    {
        public Task Insert(Application application)
        {
            throw new NotImplementedException();
        }

        public Task Update(Application application, int id)
        {
            throw new NotImplementedException();
        }
    }
}
