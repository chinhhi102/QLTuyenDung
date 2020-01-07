namespace DataLibrary.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_MauThongBao
    {
        public void copy(tbl_MauThongBao o)
        {
            NoiLamViec = o.NoiLamViec;
            YeuCauKyThuat = o.YeuCauKyThuat;
            SL = o.SL;
            ChucVu = o.ChucVu;
            YeuCauKhac = o.YeuCauKhac;
            YeuCauNgoaiNgu = o.YeuCauNgoaiNgu;
            TuoiTu = o.TuoiTu;
            TuoiDen = o.TuoiDen;
            MucLuong = o.MucLuong;
            ThoiGianLamViec = o.ThoiGianLamViec;
            TinhTrangHonNhan = o.TinhTrangHonNhan;
            HinhThucTuyen = o.HinhThucTuyen;
            NgayTaoMau = o.NgayTaoMau;
        }

        [Key]
        public int ThongBaoID { get; set; }

        public string NoiLamViec { get; set; }

        public string YeuCauKyThuat { get; set; }

        public int? SL { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        public string YeuCauKhac { get; set; }

        public string YeuCauNgoaiNgu { get; set; }

        public int? TuoiTu { get; set; }

        public int? TuoiDen { get; set; }

        [StringLength(250)]
        public string MucLuong { get; set; }

        public string ThoiGianLamViec { get; set; }

        public string TinhTrangHonNhan { get; set; }

        [StringLength(50)]
        public string HinhThucTuyen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayTaoMau { get; set; }
    }
}
