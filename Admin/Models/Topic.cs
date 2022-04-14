namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Topic")]
    public partial class Topic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Slug { get; set; }

        public int ParentId { get; set; }

        public DateTime Created_at { get; set; }

        [Required]
        [StringLength(200)]
        public string Created_by { get; set; }

        public DateTime Updated_at { get; set; }

        [Required]
        [StringLength(200)]
        public string Updated_by { get; set; }

        public int Status { get; set; }
    }
}
