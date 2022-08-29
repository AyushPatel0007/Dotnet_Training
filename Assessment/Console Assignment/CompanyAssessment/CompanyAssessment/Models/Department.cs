using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyAssessment.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required(ErrorMessage = "Enter the field")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Enter only alphabets")]

        public string DeptName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}