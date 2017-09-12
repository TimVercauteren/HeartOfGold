using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.Business.Models._base
{
    public class BaseModel
    {
        [Required(AllowEmptyStrings = true)]
        public int Id { get; set; }
    }
}
