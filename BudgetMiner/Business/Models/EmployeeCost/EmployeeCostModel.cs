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
        [DataType(DataType.Text)]
        [MaxLength(15)]
        [Required]
        public string FunctionTitle { get; set; }
        [Required]
        public string FunctionDescription { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal BaseJunior { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal BaseMedior { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        public decimal BaseSenior { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal AnnualIncrease { get; set; }
        [Required]
        public string InstructionsHTML { get; set; }
    }
}
