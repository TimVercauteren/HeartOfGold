using BudgetMiner.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Readers
{
    public interface IApplicationReader
    {
        Task<IEnumerable<Application>> GetAll();
        Task<Application> Get(int appId);
    }
}