using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BudgetMiner.DataAccess.Entities
{
    public class System {
        [Key]
        public int SystemId { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime FirstInUse { get; set; }
        public string HoursOfOperation { get; set; }
        //De link naar department
        public Department Department { get; set; }
    }

    public class Department {
        [Key]
        public int DepartmetnsId { get; set; }
        [Required]
        public string Name { get; set; }
        public int? NumberOfUsers { get; set; }
        // foreign key naar System
        public int SystemId { get; set; }
        public System System { get; set; }
    }

    public class HostingType {
        [Key]
        public int HostingTypeId { get; set; }
        [Required]
        public string Description { get; set; }
    }

    public class Team {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Profiles {
        [Key]
        public int ProfileId { get; set; }
        [Required]
        public string Joblevel { get; set; }
        public string Function { get; set; }
    }

    public class FTE {
        public float FTEConsumption { get; set; }
        // foreign key naar Team en onderdeel van primary key
        public int TeamId { get; set; }
        // foreign key naar Profile en onderdeel van primary key
        public int ProfileId { get; set; }    
    }


}
