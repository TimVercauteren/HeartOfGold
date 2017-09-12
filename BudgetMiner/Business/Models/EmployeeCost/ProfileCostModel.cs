using System.ComponentModel.DataAnnotations;
using BudgetMiner.Business.Models._base;

namespace BudgetMiner.Business.Models.EmployeeCost
{
    public class ProfileCostModel : BaseModel
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
