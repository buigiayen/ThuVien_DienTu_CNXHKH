namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HomThu")]
    public partial class HomThu
    {
        public int id { get; set; }

        [StringLength(500)]
        public string emailTo { get; set; }

        [StringLength(500)]
        public string title { get; set; }

        public string body { get; set; }

        [StringLength(1000)]
        public string fileAtt { get; set; }

        public bool? status { get; set; }

        public string EX { get; set; }
    }
}
