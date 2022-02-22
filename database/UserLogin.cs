namespace database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        [Key]
       
        public int id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public bool? status { get; set; }

        public bool isAdmin { get; set; }

        [StringLength(200)]
        public string TenSinhVien { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
    }
}
