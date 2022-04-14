using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    [Table("AppUserRoleMapping")]
    public partial class AppUserRoleMapping
    {
        public int Id { get; set; }

        public int? AppUserId { get; set; }

        public int? RoleId { get; set; }

        public DateTime? ExpiredDate { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}