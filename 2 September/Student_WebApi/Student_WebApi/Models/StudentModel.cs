using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Student_WebApi.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("School")]
        public int Schools_Sid { get; set; }
        public virtual School School { get; set; }
    }
}