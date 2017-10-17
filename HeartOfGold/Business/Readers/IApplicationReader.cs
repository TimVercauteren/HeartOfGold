using HeartOfGold.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Readers
{
    public interface IApplicationReader
    {
        Task<IEnumerable<Application>> GetAll();
        Task<Application> Get(int appId);
    }
}