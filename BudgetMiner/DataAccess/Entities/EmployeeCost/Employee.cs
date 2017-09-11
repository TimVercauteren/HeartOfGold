using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.Entities.EmployeeCost
{
    public class Employee : EntityBase
    {
        public Function Function { get; set; }
        public Seniority Seniority { get; set; }
        public string Name { get; set; }
        public string GivenName { get; set; }
        public decimal Salary { get; set; }
    }

    public enum Seniority
    {
        Junior,
        Medior,
        Senior
    }
}
