using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webcore_demo.Repo
{
    public class UserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; } 
        public string Roles { get; set; }
        public string Password { get; set; }
    }
}
