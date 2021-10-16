using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApp.Areas.Admin.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tbl_Login> tbl_Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_Login>()
                .Property(e => e.UserNameAdmin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Login>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
