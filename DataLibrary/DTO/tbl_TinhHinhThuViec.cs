namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TinhHinhThuViec
    {
        public void copy(tbl_TinhHinhThuViec o)
        {
            TinhHinhThuViecID = 
            ThuViecID = o.ThuViecID;
            ThaiDoLamViec = o.ThaiDoLamViec;
            KinhNghiemLamViec = o.KinhNghiemLamViec;
            HieuQuaLamViec = o.HieuQuaLamViec;
            NgayCapNhap = o.NgayCapNhap;
        }

        [Key]
        public int TinhHinhThuViecID { get; set; }
        public int ThuViecID { get; set; }

        public string KhaNangLamViec { get; set; }

        public string ThaiDoLamViec { get; set; }

        public string KinhNghiemLamViec { get; set; }

        public string HieuQuaLamViec { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhap { get; set; }
    }
}
