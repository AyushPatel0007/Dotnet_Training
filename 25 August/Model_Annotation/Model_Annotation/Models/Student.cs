//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model_Annotation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Semail { get; set; }
        public string Spassword { get; set; }
        public Nullable<int> Departments_Did { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
