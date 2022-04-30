namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraCuuThuatNgu")]
    public partial class TraCuuThuatNgu
    {
        public int id { get; set; }

        public string ThuatNgu { get; set; }

        public bool? status { get; set; }

        public int PhanLoai { get; set; }

        public string MoTaThuatNgu { get; set; }
    }
}
