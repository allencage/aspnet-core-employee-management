using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Repo.EF.Models.DataManager;

namespace Repo.EF.Models
{
    public class Status
    {
        [Key]
        [ForeignKey("Employee")]
        public long EmployeeId { get; set; }
        [Required]
        public bool IsHired { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        public DateTime? DepartedDate { get; set; }
        [Required]
        public EmploymentType EmploymentType { get; set; }

        public virtual Employee Employee{get;set;}
    }
}
