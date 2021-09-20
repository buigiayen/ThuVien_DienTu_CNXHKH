namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tuSach")]
    public partial class tuSach
    {
        [StringLength(500)]
        public string TenSach { get; set; }

        [StringLength(1000)]
        public string LinkSach { get; set; }

        public bool? status { get; set; }

        public int ID { get; set; }
    }
}
