namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_BaiViet()
        {
            BaiThis = new HashSet<BaiThi>();
            CauHois = new HashSet<CauHoi>();
            TaiLieuThamKhaos = new HashSet<TaiLieuThamKhao>();
        }

        public int id { get; set; }

        public string TenBaiViet { get; set; }

        public int? ID_File_PPT { get; set; }

        public int? ID_File_Voice { get; set; }

        public int? ID_NhomSach { get; set; }

        public bool status { get; set; }

        public int TrangThaiThi { get; set; }

        public int? ID_FileWord { get; set; }
        public bool? TuSachVanKien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiThi> BaiThis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauHoi> CauHois { get; set; }

        public virtual File File { get; set; }

        public virtual File File1 { get; set; }

        public virtual File File2 { get; set; }

        public virtual NhomSach NhomSach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiLieuThamKhao> TaiLieuThamKhaos { get; set; }
    }
}
