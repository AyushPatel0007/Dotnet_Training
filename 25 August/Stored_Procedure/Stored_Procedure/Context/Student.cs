//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Stored_Procedure.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Student
    {
        [Key]
       
        public int Sid { get; set; }
        [Required(ErrorMessage = "Enter the Name")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="Enter Valid Name")]
        public string Sname { get; set; }

        [Required(ErrorMessage ="Enter the Email")]
        [DataType(DataType.EmailAddress)]
        public string Semail { get; set; }

        [Required(ErrorMessage = "Enter the Password")]
        [DataType(DataType.Password)]

        public string Spassword { get; set; }

        [Required(ErrorMessage = "Enter the Department")]

        public int Departments_Did { get; set; }
    
        public virtual Department Department { get; set; }
    }
}