namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ThuViec
    {
        public void copy(tbl_ThuViec o)
        {
            NhanVienID = o.NhanVienID;
            NgayThuViec = o.NgayThuViec;
            NgayKetThucThuViec = o.NgayKetThucThuViec;
        }

        [Key]
        public int ThuViecID { get; set; }

        public int? NhanVienID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThuViec { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThucThuViec { get; set; }
    }
}
