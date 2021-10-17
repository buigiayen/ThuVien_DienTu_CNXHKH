namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauTraLoi")]
    public partial class CauTraLoi
    {
        public int? IdCauHoi { get; set; }

        [Key]
        public int idTraLoi { get; set; }

        public int? IDUser { get; set; }

        public int? DapAn { get; set; }

        public virtual CauHoi CauHoi { get; set; }
    }
}
