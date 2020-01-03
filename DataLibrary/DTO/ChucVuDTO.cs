using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class ChucVuDTO
    {
        public int ChucVuID { get; set; }
        public string TenChucVu { get; set; }
        public string NoiDungCV { get; set; }
        public string QuyenLoiCV { get; set; }
        public ChucVuDTO() { }
        public ChucVuDTO(string _TenChucVu, string _NoiDungCV, string _QuyenLoiCV)
        {
            this.TenChucVu = _TenChucVu;
            this.NoiDungCV = _NoiDungCV;
            this.QuyenLoiCV = _QuyenLoiCV;
        }
        public ChucVuDTO(ChucVuDTO other)
        {
            this.ChucVuID = other.ChucVuID;
            this.TenChucVu = other.TenChucVu;
            this.NoiDungCV = other.NoiDungCV;
            this.QuyenLoiCV = other.QuyenLoiCV;
        }

        public ChucVuDTO(int chucVuID, string tenChucVu, string noiDungCV, string quyenLoiCV)
        {
            ChucVuID = chucVuID;
            TenChucVu = tenChucVu;
            NoiDungCV = noiDungCV;
            QuyenLoiCV = quyenLoiCV;
        }
    }
}
