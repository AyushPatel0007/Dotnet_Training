using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping_Website_UI.Models
{
    public class RoleDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}