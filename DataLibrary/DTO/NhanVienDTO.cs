using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(string hoTen, DateTime ngaySinh, string queQuan, bool gioiTinh, string danToc, string sDT, string email, int phongBanID, int chucVuID, int tDHVID, int bacLuongID, int trangThai, int chuyenMonID, int hoSoPVID)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            GioiTinh = gioiTinh;
            DanToc = danToc;
            SDT = sDT;
            Email = email;
            PhongBanID = phongBanID;
            ChucVuID = chucVuID;
            TDHVID = tDHVID;
            BacLuongID = bacLuongID;
            TrangThai = trangThai;
            ChuyenMonID = chuyenMonID;
            HoSoPVID = hoSoPVID;
        }
        public NhanVienDTO() { }
        public NhanVienDTO(NhanVienDTO other)
        {
            NhanVienID = other.NhanVienID;
            HoTen = other.HoTen;
            NgaySinh = other.NgaySinh;
            QueQuan = other.QueQuan;
            GioiTinh = other.GioiTinh;
            DanToc = other.DanToc;
            SDT = other.SDT;
            Email = other.Email;
            PhongBanID = other.PhongBanID;
            ChucVuID = other.ChucVuID;
            TDHVID = other.TDHVID;
            BacLuongID = other.BacLuongID;
            TrangThai = other.TrangThai;
            ChuyenMonID = other.ChuyenMonID;
            HoSoPVID = other.HoSoPVID;
        }

        public NhanVienDTO(int nhanVienID, string hoTen, DateTime ngaySinh, string queQuan, bool gioiTinh, string danToc, string sDT, string email, int phongBanID, int chucVuID, int tDHVID, int bacLuongID, int trangThai, int chuyenMonID, int hoSoPVID)
        {
            NhanVienID = nhanVienID;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
            GioiTinh = gioiTinh;
            DanToc = danToc;
            SDT = sDT;
            Email = email;
            PhongBanID = phongBanID;
            ChucVuID = chucVuID;
            TDHVID = tDHVID;
            BacLuongID = bacLuongID;
            TrangThai = trangThai;
            ChuyenMonID = chuyenMonID;
            HoSoPVID = hoSoPVID;
        }

        public int NhanVienID { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public bool GioiTinh { get; set; }
        public string DanToc { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public int PhongBanID { get; set; }
        public int ChucVuID { get; set; }
        public int TDHVID { get; set; }
        public int BacLuongID { get; set; }
        public int TrangThai { get; set; }
        public int ChuyenMonID { get; set; }
        public int HoSoPVID { get; set; }
    }
}
