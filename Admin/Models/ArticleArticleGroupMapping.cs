namespace Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArticleArticleGroupMapping")]
    public partial class ArticleArticleGroupMapping
    {
        public long Id { get; set; }

        public long? ArticleGroupId { get; set; }

        public long? ArticleId { get; set; }

        public virtual Article Article { get; set; }

        public virtual ArticleGroup ArticleGroup { get; set; }
    }
}
