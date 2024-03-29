namespace database
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

        public int? ID_File { get; set; }

        public bool? status { get; set; }

        public int ID { get; set; }

        [StringLength(500)]
        public string LoaiTaiLieu { get; set; }

        [StringLength(500)]
        public string TacGia { get; set; }

        [StringLength(50)]
        public string NamXuatBan { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public virtual File File { get; set; }
    }
}
