using HeartOfGold.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Readers
{
    public interface IComponentReader
    {
        Task<IEnumerable<Component>> GetAll();
        Task<Component> Get(int componentId);
    }
}
