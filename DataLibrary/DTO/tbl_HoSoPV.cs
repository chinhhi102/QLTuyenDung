namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_HoSoPV
    {
        public void copy(tbl_HoSoPV o)
        {
            NgayPV = o.NgayPV;
            KetQuaPV = o.KetQuaPV;
            NhanVienID = o.NhanVienID;
        }

        [Key]
        public int HoSoPVID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPV { get; set; }

        public int? KetQuaPV { get; set; }

        public int? NhanVienID { get; set; }
    }
}
