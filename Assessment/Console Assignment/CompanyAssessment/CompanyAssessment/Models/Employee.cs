using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CompanyAssessment.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage ="Enter the field")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the field")]
        [RegularExpression("male|female", ErrorMessage = "The Gender must be either 'male' or 'female' only.")]

        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter the field")]
        [RegularExpression("^[a-zA-Z ]*$",ErrorMessage ="Enter only alphabets")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter the field")]
        public int Salary { get; set; }
        [ForeignKey("Department")]
        [Required(ErrorMessage = "Enter the field")]
        [Range(0, 15, ErrorMessage = "Can only be between 0 .. 15")]

        public int Departments_DeptId { get; set; }
        public virtual Department Department { get; set; }

    }
}
