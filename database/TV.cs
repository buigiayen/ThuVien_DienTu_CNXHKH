using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace database
{
    public partial class TV : DbContext
    {
        public TV()
            : base("name=TV")
        {
        }

        public virtual DbSet<BaiThi> BaiThis { get; set; }
        public virtual DbSet<CauHoi> CauHois { get; set; }
        public virtual DbSet<CauTraLoi> CauTraLois { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<HomThu> HomThus { get; set; }
        public virtual DbSet<LienKet> LienKets { get; set; }
        public virtual DbSet<NhomSach> NhomSaches { get; set; }
        public virtual DbSet<SachKinhDien> SachKinhDiens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_BaiViet> tbl_BaiViet { get; set; }
        public virtual DbSet<tuSach> tuSaches { get; set; }
        public virtual DbSet<TuSachKinhDien> TuSachKinhDiens { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauHoi>()
                .HasMany(e => e.CauTraLois)
                .WithRequired(e => e.CauHoi)
                .HasForeignKey(e => e.CauHoiId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CauTraLoi>()
                .HasMany(e => e.CauHois)
                .WithOptional(e => e.CauTraLoi)
                .HasForeignKey(e => e.IdCauTraLoiDung);

            modelBuilder.Entity<File>()
                .HasMany(e => e.SachKinhDiens)
                .WithOptional(e => e.File)
                .HasForeignKey(e => e.link_File);

            modelBuilder.Entity<File>()
                .HasMany(e => e.tbl_BaiViet)
                .WithOptional(e => e.File)
                .HasForeignKey(e => e.ID_File_PPT);

            modelBuilder.Entity<File>()
                .HasMany(e => e.tbl_BaiViet1)
                .WithOptional(e => e.File1)
                .HasForeignKey(e => e.ID_File_Voice);

            modelBuilder.Entity<File>()
                .HasMany(e => e.tbl_BaiViet2)
                .WithOptional(e => e.File2)
                .HasForeignKey(e => e.ID_FileWord);

            modelBuilder.Entity<File>()
                .HasMany(e => e.tuSaches)
                .WithOptional(e => e.File)
                .HasForeignKey(e => e.ID_File);

            modelBuilder.Entity<NhomSach>()
                .HasMany(e => e.tbl_BaiViet)
                .WithOptional(e => e.NhomSach)
                .HasForeignKey(e => e.ID_NhomSach);

            modelBuilder.Entity<tbl_BaiViet>()
                .HasMany(e => e.BaiThis)
                .WithRequired(e => e.tbl_BaiViet)
                .HasForeignKey(e => e.BaiVietId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_BaiViet>()
                .HasMany(e => e.CauHois)
                .WithRequired(e => e.tbl_BaiViet)
                .HasForeignKey(e => e.BaiVietId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TuSachKinhDien>()
                .HasMany(e => e.SachKinhDiens)
                .WithOptional(e => e.TuSachKinhDien)
                .HasForeignKey(e => e.IDNhomSachKinhDien);
        }
    }
}
