using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Admin.Models
{
    [Table("PermissionActionMapping")]
    public partial class PermissionActionMapping
    {
        public int Id { get; set; }

        public int? ActionId { get; set; }

        public int? PermissionId { get; set; }

        public virtual Action Action { get; set; }

        public virtual Permission Permission { get; set; }
    }
}