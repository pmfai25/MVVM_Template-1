namespace MVVM_Template.Model.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel() : base("name=EntityModel")
        {   }

        public virtual DbSet<tblGroup> tblGroups { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblGroup>()
                .Property(e => e.Group_id)
                .IsUnicode(false);

            modelBuilder.Entity<tblGroup>()
                .Property(e => e.Group_name)
                .IsUnicode(false);

            modelBuilder.Entity<tblGroup>()
                .HasMany(e => e.tblUsers)
                .WithMany(e => e.tblGroups)
                .Map(m => m.ToTable("tblUserGroup").MapLeftKey("Group_id").MapRightKey("User_id"));

            modelBuilder.Entity<tblUser>()
                .Property(e => e.User_id)
                .IsUnicode(false);

            modelBuilder.Entity<tblUser>()
                .Property(e => e.User_name)
                .IsUnicode(false);
        }
    }
}
