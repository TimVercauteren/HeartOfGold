using System.ComponentModel.DataAnnotations;
using BudgetMiner.Business.Models._base;

namespace BudgetMiner.Business.Models
{
    public class ProfileCostModel : BaseModel
    {
        [DataType(DataType.Text)]
        [MaxLength(15)]
        [Required]
        [Display(Name = "Function")]
        public string FunctionTitle { get; set; }
        [DataType(DataType.Text)]
        [Required]
        [Display(Name = "Function Description")]
        public string FunctionDescription { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Base salary for junior profiles")]
        public decimal BaseJunior { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Base salary for medior profiles")]
        public decimal BaseMedior { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Base salary for senior profiles")]
        public decimal BaseSenior { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Annual increase of the salary")]
        public decimal AnnualIncrease { get; set; }
    }
}
