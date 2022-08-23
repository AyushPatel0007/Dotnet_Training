using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Get_POst
{
    public class ValidCheck:ValidationAttribute
    {

        protected override ValidationResult IsValid(object v,ValidationContext c)
        {
            if (v != null)
            {
                string msg = v.ToString();
                if (msg.Contains("Nitis"))
                {
                    return ValidationResult.Success;
                }
                 
            }
             return new ValidationResult("Field NOt match");
        }
         
    }
}