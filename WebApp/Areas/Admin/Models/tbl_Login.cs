namespace WebApp.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Login
    {
        [Key]
        [StringLength(20)]
        public string UserNameAdmin { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
