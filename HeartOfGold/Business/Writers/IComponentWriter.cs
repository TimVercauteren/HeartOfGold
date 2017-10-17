using HeartOfGold.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Writers
{
    interface IComponentWriter
    {
        Task Insert(Component component);
        Task Update(Component component, int id);
    }
}
