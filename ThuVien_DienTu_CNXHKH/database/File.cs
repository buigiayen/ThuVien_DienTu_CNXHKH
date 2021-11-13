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
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }

        [StringLength(50)]
        public string Ex { get; set; }

        public double? size { get; set; }

        public bool? status { get; set; }
    }
}
