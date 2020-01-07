namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TaiKhoan
    {
        public void copy(tbl_TaiKhoan o)
        {
            TenTaiKhoan = o.TenTaiKhoan;
            MatKhau = o.MatKhau;
        }

        [Key]
        [Column(Order = 0)]
        public int TaiKhoanID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenTaiKhoan { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
