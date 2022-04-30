namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("File")]
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            SachKinhDiens = new HashSet<SachKinhDien>();
            TaiLieuThamKhaos = new HashSet<TaiLieuThamKhao>();
            tbl_BaiViet = new HashSet<tbl_BaiViet>();
            tbl_BaiViet1 = new HashSet<tbl_BaiViet>();
            tbl_BaiViet2 = new HashSet<tbl_BaiViet>();
            tbl_BaiViet3 = new HashSet<tbl_BaiViet>();
            tuSaches = new HashSet<tuSach>();
        }

        public int ID { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        [StringLength(50)]
        public string Ex { get; set; }

        public double? size { get; set; }

        public bool? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SachKinhDien> SachKinhDiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieuThamKhao> TaiLieuThamKhaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BaiViet> tbl_BaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BaiViet> tbl_BaiViet1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BaiViet> tbl_BaiViet2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BaiViet> tbl_BaiViet3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tuSach> tuSaches { get; set; }
    }
}
