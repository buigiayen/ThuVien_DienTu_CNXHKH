namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHoi")]
    public partial class CauHoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CauHoi()
        {
            CauTraLois = new HashSet<CauTraLoi>();
        }

        public int Id { get; set; }

        public int BaiVietId { get; set; }

        [Required]
        public string NoiDung { get; set; }

        public int? IdCauTraLoiDung { get; set; }

        public int? Stt { get; set; }

        public bool? Status { get; set; }

        public virtual CauTraLoi CauTraLoi { get; set; }

        public virtual tbl_BaiViet tbl_BaiViet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CauTraLoi> CauTraLois { get; set; }
    }
}
