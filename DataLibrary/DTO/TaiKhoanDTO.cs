using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tenTaiKhoan, string matKhau)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
        }
        public TaiKhoanDTO() { }
        public TaiKhoanDTO(TaiKhoanDTO other)
        {
            TaiKhoanID = other.TaiKhoanID;
            TenTaiKhoan = other.TenTaiKhoan;
            MatKhau = other.MatKhau;
        }

        public TaiKhoanDTO(int taiKhoanID, string tenTaiKhoan, string matKhau)
        {
            TaiKhoanID = taiKhoanID;
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
        }

        public int TaiKhoanID { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}
