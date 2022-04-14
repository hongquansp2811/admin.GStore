namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fiscalyear")]
    public partial class Fiscalyear
    {
        [Key]
        public int Fid { get; set; }

        public DateTime? FiscalyearFromDate { get; set; }

        public DateTime? FiscalyearToDate { get; set; }

        [StringLength(4)]
        public string Year { get; set; }
    }
}
