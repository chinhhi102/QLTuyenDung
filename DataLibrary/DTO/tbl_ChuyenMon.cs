namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ChuyenMon
    {
        public void copy(tbl_ChuyenMon o)
        {
            TenChuyenMon = o.TenChuyenMon;
        }

        [Key]
        public int ChuyenMonID { get; set; }

        [StringLength(50)]
        public string TenChuyenMon { get; set; }
    }
}
