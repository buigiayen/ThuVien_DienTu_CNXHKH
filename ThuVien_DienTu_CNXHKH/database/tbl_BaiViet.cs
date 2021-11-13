namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BaiViet
    {
        public int id { get; set; }

        public string TenBaiViet { get; set; }

        [StringLength(1000)]
        public string Link_ppt { get; set; }

        [StringLength(1000)]
        public string Link_voice { get; set; }

        public int? ID_CauHoi { get; set; }

        public int? ID_NhomSach { get; set; }

        public bool status { get; set; }

        public string LinkWord { get; set; }

        public virtual NhomSach NhomSach { get; set; }
    }
}
