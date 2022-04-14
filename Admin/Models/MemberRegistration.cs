namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberRegistration")]
    public partial class MemberRegistration
    {
        [Key]
        public long MemID { get; set; }

        [StringLength(20)]
        public string MemberNo { get; set; }

        [StringLength(100)]
        public string MemberFName { get; set; }

        [StringLength(100)]
        public string MemberLName { get; set; }

        [StringLength(100)]
        public string MemberMName { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(10)]
        public string Age { get; set; }

        [StringLength(10)]
        public string Contactno { get; set; }

        [StringLength(30)]
        public string EmailID { get; set; }

        [StringLength(30)]
        public string Gender { get; set; }

        public int? PlantypeID { get; set; }

        public int? WorkouttypeID { get; set; }

        public long? Createdby { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long? ModifiedBy { get; set; }

        [StringLength(500)]
        public string MemImagename { get; set; }

        [StringLength(500)]
        public string MemImagePath { get; set; }

        public DateTime? JoiningDate { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public long? MainMemberID { get; set; }
    }
}
