using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Models.EmployeeCost
{
    public class EmployeeCostModel
    {
        [Required]
        public string FunctionTitle { get; set; }
        [Required]
        public string FunctionDescription { get; set; }
        public decimal BaseJunior { get; set; }
        public decimal BaseMedior { get; set; }
        public decimal BaseSenior { get; set; }
        public decimal AnnualIncrease { get; set; }
        public string InstructionsHTML { get; set; }
    }
}
