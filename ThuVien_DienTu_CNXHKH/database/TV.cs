using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThuVien_DienTu_CNXHKH.database
{
    public partial class TV : DbContext
    {
        public TV()
            : base("name=TV")
        {
        }

        public virtual DbSet<LienKet> LienKets { get; set; }
        public virtual DbSet<NhomSach> NhomSaches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_BaiViet> tbl_BaiViet { get; set; }
        public virtual DbSet<tuSach> tuSaches { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhomSach>()
                .HasMany(e => e.tbl_BaiViet)
                .WithOptional(e => e.NhomSach)
                .HasForeignKey(e => e.ID_NhomSach);
        }
    }
}
