namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SachKinhDien")]
    public partial class SachKinhDien
    {
        public int ID { get; set; }

        public int? IDNhomSachKinhDien { get; set; }

        [StringLength(1000)]
        public string TenBai { get; set; }

        public int? link_File { get; set; }

        public bool? status { get; set; }

        public virtual File File { get; set; }

        public virtual TuSachKinhDien TuSachKinhDien { get; set; }
    }
}
