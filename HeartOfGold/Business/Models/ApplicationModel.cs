using HeartOfGold.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold.Business.Models
{
    public class ApplicationModel : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FirstUse { get; set; }
        public int NumberOfUsers { get; set; }
        public string Manufacturer { get; set; }
        public string BudgetOwner { get; set; }

    }
}
