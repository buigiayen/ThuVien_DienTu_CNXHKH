namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiLieuThamKhao")]
    public partial class TaiLieuThamKhao
    {
        public int id { get; set; }

        public int? idFile { get; set; }

        public int? idBaiViet { get; set; }

        public bool? status { get; set; }

        [StringLength(500)]
        public string TenTaiLieu { get; set; }

        public virtual File File { get; set; }

        public virtual tbl_BaiViet tbl_BaiViet { get; set; }
    }
}
