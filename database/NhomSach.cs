namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhomSach")]
    public partial class NhomSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhomSach()
        {
            tbl_BaiViet = new HashSet<tbl_BaiViet>();
        }

        [Key]
        public int IDNhomSach { get; set; }

        public string TenNhomSach { get; set; }

        public bool status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_BaiViet> tbl_BaiViet { get; set; }
    }
}
