namespace ThuVien_DienTu_CNXHKH.database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        public string Password { get; set; }

        public bool? status { get; set; }

        public bool isAdmin { get; set; }
    }
}
