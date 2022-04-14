namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            ArticleArticleGroupMappings = new HashSet<ArticleArticleGroupMapping>();
        }

        public long Id { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string TitleAscii { get; set; }

        [StringLength(255)]
        public string IconCss { get; set; }

        public long? DisplayOrder { get; set; }

        public long? PictureId { get; set; }

        public long? ArticleTypeId { get; set; }

        public long? LanguageId { get; set; }

        [StringLength(255)]
        public string UrlImage { get; set; }

        [StringLength(1000)]
        public string Summary { get; set; }

        public string Description { get; set; }

        [StringLength(255)]
        public string CreateBy { get; set; }

        public long? Viewed { get; set; }

        public string SEOTitle { get; set; }

        public string SEODescription { get; set; }

        public string SEOKeyword { get; set; }

        public bool? IsHot { get; set; }

        public string Url { get; set; }

        public bool? IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool? IsInHome { get; set; }

        public virtual ArticleType ArticleType { get; set; }

        public virtual Language Language { get; set; }

        public virtual Picture Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArticleArticleGroupMapping> ArticleArticleGroupMappings { get; set; }
    }
}
