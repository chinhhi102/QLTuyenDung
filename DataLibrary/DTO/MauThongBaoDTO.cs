using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class MauThongBaoDTO
    {
        public int MauThongBaoID { get; set; }
        public string NoiLamViec { get; set; }
        public string YeuCauKyThuat { get; set; }
        public int SL { get; set; }
        public string ChucVu { get; set; }
        public string YeuCauKhac { get; set; }
        public string YeuCauNgoaiNgu { get; set; }
        public int TuoiTu { get; set; }
        public int TuoiDen { get; set; }
        public string MucLuong { get; set; }
        public string ThoiGianLamViec { get; set; }
        public string TinhTrangHonNhan { get; set; }
        public string HinhThucTuyen { get; set; }
        public DateTime NgayTaoMau { get; set; }
        public MauThongBaoDTO() { }
        public MauThongBaoDTO(string _NoiLamViec, string _YeuCauKyThuat, int _SL, string _ChucVu, string _YeuCauKhac, string _YeuCauNgoaiNgu, int _TuoiTu, int _TuoiDen, string _MucLuong, string _ThoiGianLamViec, string _TinhTrangHonNhan, string _HinhThucTuyen, DateTime _NgayTaoMau)
        {
            this.NoiLamViec = _NoiLamViec;
            this.YeuCauKyThuat = _YeuCauKyThuat;
            this.SL = _SL;
            this.ChucVu = _ChucVu;
            this.YeuCauKhac = _YeuCauKhac;
            this.YeuCauNgoaiNgu = _YeuCauNgoaiNgu;
            this.TuoiTu = _TuoiTu;
            this.TuoiDen = _TuoiDen;
            this.MucLuong = _MucLuong;
            this.ThoiGianLamViec = _ThoiGianLamViec;
            this.TinhTrangHonNhan = _TinhTrangHonNhan;
            this.HinhThucTuyen = _HinhThucTuyen;
            this.NgayTaoMau = _NgayTaoMau;
        }
        public MauThongBaoDTO(MauThongBaoDTO other)
        {
            this.NoiLamViec = other.NoiLamViec;
            this.YeuCauKyThuat = other.YeuCauKyThuat;
            this.SL = other.SL;
            this.ChucVu = other.ChucVu;
            this.YeuCauKhac = other.YeuCauKhac;
            this.YeuCauNgoaiNgu = other.YeuCauNgoaiNgu;
            this.TuoiTu = other.TuoiTu;
            this.TuoiDen = other.TuoiDen;
            this.MucLuong = other.MucLuong;
            this.ThoiGianLamViec = other.ThoiGianLamViec;
            this.TinhTrangHonNhan = other.TinhTrangHonNhan;
            this.HinhThucTuyen = other.HinhThucTuyen;
            this.NgayTaoMau = other.NgayTaoMau;
        }

        public MauThongBaoDTO(int mauThongBaoID, string noiLamViec, string yeuCauKyThuat, int sL, string chucVu, string yeuCauKhac, string yeuCauNgoaiNgu, int tuoiTu, int tuoiDen, string mucLuong, string thoiGianLamViec, string tinhTrangHonNhan, string hinhThucTuyen, DateTime ngayTaoMau)
        {
            MauThongBaoID = mauThongBaoID;
            NoiLamViec = noiLamViec;
            YeuCauKyThuat = yeuCauKyThuat;
            SL = sL;
            ChucVu = chucVu;
            YeuCauKhac = yeuCauKhac;
            YeuCauNgoaiNgu = yeuCauNgoaiNgu;
            TuoiTu = tuoiTu;
            TuoiDen = tuoiDen;
            MucLuong = mucLuong;
            ThoiGianLamViec = thoiGianLamViec;
            TinhTrangHonNhan = tinhTrangHonNhan;
            HinhThucTuyen = hinhThucTuyen;
            NgayTaoMau = ngayTaoMau;
        }
    }
}
