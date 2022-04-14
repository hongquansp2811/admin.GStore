namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceiptDetail")]
    public partial class ReceiptDetail
    {
        [Key]
        public long ReceiptID { get; set; }

        public long? Memberid { get; set; }

        public long? generateby { get; set; }

        public long? createdby { get; set; }

        public DateTime? createddate { get; set; }
    }
}
