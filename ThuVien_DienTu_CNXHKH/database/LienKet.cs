namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienKet")]
    public partial class LienKet
    {
        public int id { get; set; }

        [StringLength(100)]
        public string Mota { get; set; }

        public string link { get; set; }
        public bool status { get; set; }
    }
}
