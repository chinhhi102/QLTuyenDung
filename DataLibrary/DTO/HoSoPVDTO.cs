using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class HoSoPVDTO
    {
        public int HoSoPVID { get; set; }
        public DateTime NgayPV { get; set; }
        public string KetQuaPV { get; set; }
        public int NhanVienID { get; set; }
        public HoSoPVDTO() { }
        public HoSoPVDTO(DateTime _NgayPV, string _KetQuaPV, int _NhanVienID)
        {
            this.NgayPV = _NgayPV;
            this.KetQuaPV = _KetQuaPV;
            this.NhanVienID = _NhanVienID;
        }
        public HoSoPVDTO(HoSoPVDTO other)
        {
            this.HoSoPVID = other.HoSoPVID;
            this.NgayPV = other.NgayPV;
            this.KetQuaPV = other.KetQuaPV;
            this.NhanVienID = other.NhanVienID;
        }

        public HoSoPVDTO(int hoSoPVID, DateTime ngayPV, string ketQuaPV, int nhanVienID)
        {
            HoSoPVID = hoSoPVID;
            NgayPV = ngayPV;
            KetQuaPV = ketQuaPV;
            NhanVienID = nhanVienID;
        }
    }
}
