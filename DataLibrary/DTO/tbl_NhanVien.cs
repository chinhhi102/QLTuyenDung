namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_NhanVien
    {
        public void copy(tbl_NhanVien o)
        {
            HoTen = o.HoTen;
            NgaySinh = o.NgaySinh;
            QueQuan = o.QueQuan;
            GioiTinh = o.GioiTinh;
            DanToc = o.DanToc;
            SDT = o.SDT;
            Email = o.Email;
            PhongBanID = o.PhongBanID;
            ChucVuID = o.ChucVuID;
            TDHVID = o.TDHVID;
            LuongYeuCau = o.LuongYeuCau;
            TrangThai = o.TrangThai;
            ChuyenMonID = o.ChuyenMonID;
            HoSoPVID = o.HoSoPVID;
            Mota = o.Mota;
        }

        [Key]
        public int NhanVienID { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(50)]
        public string DanToc { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? PhongBanID { get; set; }

        public int? ChucVuID { get; set; }

        public int? TDHVID { get; set; }

        [StringLength(50)]
        public string LuongYeuCau { get; set; }

        public int? TrangThai { get; set; }

        public int? ChuyenMonID { get; set; }

        public int? HoSoPVID { get; set; }

        public string Mota { get; set; }
    }
}
