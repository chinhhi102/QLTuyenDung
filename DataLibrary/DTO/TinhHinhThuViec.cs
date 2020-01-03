using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class TinhHinhThuViec
    {
        public TinhHinhThuViec(string khaNangLamViec, string thaiDoLamViec, string kinhNghiemLamViec, string hieuQuaLamViec, DateTime ngayChapNhan)
        {
            KhaNangLamViec = khaNangLamViec;
            ThaiDoLamViec = thaiDoLamViec;
            KinhNghiemLamViec = kinhNghiemLamViec;
            HieuQuaLamViec = hieuQuaLamViec;
            NgayChapNhan = ngayChapNhan;
        }
        public TinhHinhThuViec() { }
        public TinhHinhThuViec(TinhHinhThuViec other)
        {
            TinhHinhThuViecID = other.TinhHinhThuViecID;
            KhaNangLamViec = other.KhaNangLamViec;
            ThaiDoLamViec = other.ThaiDoLamViec;
            KinhNghiemLamViec = other.KinhNghiemLamViec;
            HieuQuaLamViec = other.HieuQuaLamViec;
            NgayChapNhan = other.NgayChapNhan;
        }

        public TinhHinhThuViec(int tinhHinhThuViecID, string khaNangLamViec, string thaiDoLamViec, string kinhNghiemLamViec, string hieuQuaLamViec, DateTime ngayChapNhan)
        {
            TinhHinhThuViecID = tinhHinhThuViecID;
            KhaNangLamViec = khaNangLamViec;
            ThaiDoLamViec = thaiDoLamViec;
            KinhNghiemLamViec = kinhNghiemLamViec;
            HieuQuaLamViec = hieuQuaLamViec;
            NgayChapNhan = ngayChapNhan;
        }

        public int TinhHinhThuViecID { get; set; }
        public string KhaNangLamViec { get; set; }
        public string ThaiDoLamViec { get; set; }
        public string KinhNghiemLamViec { get; set; }
        public string HieuQuaLamViec { get; set; }
        public DateTime NgayChapNhan { get; set; }
    }
}
