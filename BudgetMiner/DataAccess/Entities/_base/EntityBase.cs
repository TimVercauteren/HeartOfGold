using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner.DataAccess.Entities
{
    public class EntityBase
    {
        [Required]
        int Id { get; set; }
    }
}
