using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
    }
    public class Application : EntityBase
    {
        public string Description { get; set; }
        public DateTime FirstUse { get; set; }
        public int NumberOfUsers { get; set; }
        public string Manufacturer { get; set; }
        public string BudgetOwner { get; set; }

        public IEnumerable<Component> Components { get; set; }
    }
    public class Component : EntityBase
    {
        public string Name { get; set; }
        public decimal LicenseCost { get; set; }
        public decimal MainCost { get; set; }
        public decimal YearPercentIncrease { get; set; }
        public string BudgetOwner { get; set; }

        public IEnumerable<YearCost> YearlyCosts { get; set; }

        public int ApplicationId { get; set; }
        public Application Application { get; set; }

        internal Task<Task<System.ComponentModel.Component>> ToList()
        {
            throw new NotImplementedException();
        }
    }

    public class YearCost : EntityBase
    {
        public int Year { get; set; }
        public decimal LicenseDepreciation { get; set; }
        public decimal MaintenanceCost { get; set; }

        public Component Component { get; set; }
        public int ComponentId { get; set; }
    }
}
