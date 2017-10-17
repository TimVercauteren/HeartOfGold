//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel.DataAnnotations;

//namespace HeartOfGold.DataAccess.Entities
//{
//    public class System {
//        [Key]
//        public int SystemId { get; set; }
//        [Required]
//        public string Description { get; set; }
//        public DateTime FirstInUse { get; set; }
//        public string HoursOfOperation { get; set; }
//        //De link naar department
//        public Department Department { get; set; }
//    }

//    public class Department {
//        [Key]
//        public int DepartmentsId { get; set; }
//        [Required]
//        public string Name { get; set; }
//        public int? NumberOfUsers { get; set; }
//        // foreign key naar System
//        public int SystemId { get; set; }
//        public System System { get; set; }
//    }

//    public class HostingType {
//        [Key]
//        public int HostingTypeId { get; set; }
//        [Required]
//        public string Description { get; set; }
//    }

//    public class Team {
//        [Key]
//        public int TeamId { get; set; }
//        [Required]
//        public string Name { get; set; }
//    }

//    public class Profiles {
//        [Key]
//        public int ProfileId { get; set; }
//        [Required]
//        public string Joblevel { get; set; }
//        public string Function { get; set; }
//    }

//    public class FTE {
//        public float FTEConsumption { get; set; }
//        // foreign key naar Team en onderdeel van primary key
//        public int TeamId { get; set; }
//        // foreign key naar Profile en onderdeel van primary key
//        public int ProfileId { get; set; }    
//    }

//    public class Applications {
//        [Key]
//        public int ApplicationId { get; set; }
//        [Required]
//        public string Description { get; set; }
//        public string Manufacturere { get; set; }
//        //foreign key naar hostingtype
//        public int HostingTypeId { get; set; }
//        //foreign key naar system
//        public int SystemId { get; set; }
//    }

//    public class SWComponent {
//        [Key]
//        public int SWComponentId { get; set; }
//        [Required]
//        public string Description { get; set; }
//        //foreign keyn naar applicatio
//        public int ApplicationId { get; set; }
//    }

//    public class LicenseCost {
//        [Key]
//        public int LicenseCostId { get; set; }
//        public float Y1 { get; set; }
//        public float? Y2 { get; set; }
//        public float? Y3 { get; set; }
//        public float? Y4 { get; set; }
//        public float? Y5 { get; set; }
//        //foreign key naar departments
//        public int Budegetowner { get; set; }
//        //foreign key naar SWComonentsId
//        public int SWComponentsId { get; set; }
//    }

//    public class Maintenance {
//        [Key]
//        public int MaintenanceCostId { get; set; }
//        public float Y1 { get; set; }
//        public float? Y2 { get; set; }
//        public float? Y3 { get; set; }
//        public float? Y4 { get; set; }
//        public float? Y5 { get; set; }
//        //foreign key naar departments
//        public int Budegetowner { get; set; }
//        //foreign key naar SWComonentsId
//        public int SWComponentsId { get; set; }
//    }

//    public class Customizations {
//        [Key]
//        public int CustomizationsId { get; set; }
//        public int? NumberOfCustomizations { get; set; }
//        public int? YearlyGrowth { get; set; }
//        //foreign key naar application


//    }
//}
