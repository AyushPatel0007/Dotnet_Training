//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Image.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        [Required(ErrorMessage ="Enetr")]
        public string Semail { get; set; }
        [Required(ErrorMessage = "Enetr")]
        public string Spassword { get; set; }
        public int Departments_Did { get; set; }
       public HttpPostedFileBase ImageFile { get; set; }

    }
}
