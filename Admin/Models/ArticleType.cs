namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleType")]
    public partial class ArticleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ArticleType()
        {
            Articles = new HashSet<Article>();
        }

        public long Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string NameAscii { get; set; }

        public int? Number { get; set; }

        public long? PictureId { get; set; }

        public int? Parent { get; set; }

        [StringLength(1000)]
        public string Summary { get; set; }

        public string Description { get; set; }

        public long? LanguageId { get; set; }

        [StringLength(255)]
        public string SEOTitle { get; set; }

        [StringLength(255)]
        public string SEODescription { get; set; }

        [StringLength(10)]
        public string SEOKeyword { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        [StringLength(255)]
        public string IconCss { get; set; }

        [StringLength(255)]
        public string CreateBy { get; set; }

        [StringLength(255)]
        public string UpdateBy { get; set; }

        public bool? IsShow { get; set; }

        public DateTime? DeletedAt { get; set; }

        [StringLength(255)]
        public string UrlImage { get; set; }

        public bool? IsHot { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Article> Articles { get; set; }

        public virtual Picture Picture { get; set; }
    }
}
