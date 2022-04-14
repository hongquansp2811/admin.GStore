using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Admin.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=Context")
        {
        }

        public virtual DbSet<Action> Actions { get; set; }
        public virtual DbSet<AppUserRoleMapping> AppUserRoleMappings { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleArticleGroupMapping> ArticleArticleGroupMappings { get; set; }
        public virtual DbSet<ArticleGroup> ArticleGroups { get; set; }
        public virtual DbSet<ArticleType> ArticleTypes { get; set; }
        public virtual DbSet<AssignRoleVM> AssignRoleVMs { get; set; }
        public virtual DbSet<CustomerRegisterLog> CustomerRegisterLogs { get; set; }
        public virtual DbSet<Fiscalyear> Fiscalyears { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<MemberRegistration> MemberRegistrations { get; set; }
        public virtual DbSet<ModuleApp> ModuleApps { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionActionMapping> PermissionActionMappings { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PlanMaster> PlanMasters { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SchemeMaster> SchemeMasters { get; set; }
        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Action>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ArticleType>()
                .Property(e => e.SEOKeyword)
                .IsFixedLength();

            modelBuilder.Entity<Fiscalyear>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<ModuleApp>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ModuleApp>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ModuleApp>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<ModuleApp>()
                .Property(e => e.ClassCss)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PaymentDetail>()
                .Property(e => e.RecStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Permission>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.PlanName)
                .IsUnicode(false);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.PlanAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.ServicetaxAmout)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.ServiceTax)
                .IsUnicode(false);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.RecStatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.TotalAmout)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PlanMaster>()
                .Property(e => e.ServicetaxNo)
                .IsUnicode(false);

            modelBuilder.Entity<Topic>()
                .Property(e => e.Slug)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.AppUserRoleMappings)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.AppUserId);
        }
    }
}
