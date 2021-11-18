namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiThi")]
    public partial class BaiThi
    {
        public int Id { get; set; }

        public int BaiVietId { get; set; }

        public int UserId { get; set; }

        public bool? IsThiLai { get; set; }

        public int? SoCauTraLoiDung { get; set; }

        public DateTime? ThoiGianBatDauThi { get; set; }

        public DateTime? ThoiGianKetThucThi { get; set; }

        public int? TongSoCau { get; set; }

        public virtual tbl_BaiViet tbl_BaiViet { get; set; }
    }
}
