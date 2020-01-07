namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_PhongBan
    {
        public void copy(tbl_PhongBan o)
        {
            TenPhongBan = o.TenPhongBan;
            DiaChi = o.DiaChi;
            SDTPB = o.SDTPB;
        }

        [Key]
        public int PhongBanID { get; set; }

        [StringLength(50)]
        public string TenPhongBan { get; set; }

        [StringLength(250)]
        public string DiaChi { get; set; }

        [StringLength(20)]
        public string SDTPB { get; set; }
    }
}
