using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DarulAman.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_AccessLevel> tbl_AccessLevel { get; set; }
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Donation> tbl_Donation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_AccessLevel>()
                .HasMany(e => e.tbl_Admin)
                .WithRequired(e => e.tbl_AccessLevel)
                .HasForeignKey(e => e.ACCESS_LEVEL_FID)
                .WillCascadeOnDelete(false);
        }
    }
}
