namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuSachKinhDien")]
    public partial class TuSachKinhDien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuSachKinhDien()
        {
            SachKinhDiens = new HashSet<SachKinhDien>();
        }

        public int ID { get; set; }

        [StringLength(500)]
        public string TenTuSach { get; set; }

        public bool? status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SachKinhDien> SachKinhDiens { get; set; }
    }
}
