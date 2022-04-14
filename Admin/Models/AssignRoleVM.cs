namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssignRoleVM")]
    public partial class AssignRoleVM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string UserName { get; set; }
    }
}
