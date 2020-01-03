using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class ThuViecDTO
    {
        public ThuViecDTO(int nhanSuID, DateTime ngayThuViec, DateTime ketThucNgayThuViec)
        {
            NhanSuID = nhanSuID;
            NgayThuViec = ngayThuViec;
            KetThucNgayThuViec = ketThucNgayThuViec;
        }
        public ThuViecDTO() { }
        public ThuViecDTO(ThuViecDTO other)
        {
            ThuViecID = other.ThuViecID;
            NhanSuID = other.NhanSuID;
            NgayThuViec = other.NgayThuViec;
            KetThucNgayThuViec = other.KetThucNgayThuViec;
        }

        public ThuViecDTO(int thuViecID, int nhanSuID, DateTime ngayThuViec, DateTime ketThucNgayThuViec)
        {
            ThuViecID = thuViecID;
            NhanSuID = nhanSuID;
            NgayThuViec = ngayThuViec;
            KetThucNgayThuViec = ketThucNgayThuViec;
        }

        public int ThuViecID { get; set; }
        public int NhanSuID { get; set; }
        public DateTime NgayThuViec { get; set; }
        public DateTime KetThucNgayThuViec { get; set; }
    }
}
