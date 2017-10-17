using HeartOfGold.DataAccess;
using HeartOfGold.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Readers
{
    public class ComponentReader : IComponentReader
    {
        private EntityContext Context => Context as EntityContext;

        public async Task<Component> Get(int componentId)
        {
            return await Context.Components.FirstOrDefaultAsync(c => c.Id == componentId);
        }

        public async Task<IEnumerable<Component>> GetAll()
        {
            return await Context.Components.ToListAsync();
        }
    }
}
