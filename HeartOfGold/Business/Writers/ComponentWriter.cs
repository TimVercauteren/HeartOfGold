using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeartOfGold.DataAccess.Entities;

namespace HeartOfGold.Business.Writers
{
    public class ComponentWriter : IComponentWriter
    {
        public Task Insert(Component component)
        {
            throw new NotImplementedException();
        }

        public Task Update(Component component, int id)
        {
            throw new NotImplementedException();
        }
    }
}
