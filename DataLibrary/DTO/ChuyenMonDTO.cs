using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class ChuyenMonDTO
    {
        public int ChuyenMonID { get; set; }
        public string TenChuyenMon { get; set; }
        public ChuyenMonDTO() { }
        public ChuyenMonDTO(string _TenChuyenMon)
        {
            this.TenChuyenMon = _TenChuyenMon;
        }
        public ChuyenMonDTO(ChuyenMonDTO other)
        {
            this.ChuyenMonID = other.ChuyenMonID;
            this.TenChuyenMon = other.TenChuyenMon;
        }

        public ChuyenMonDTO(int chuyenMonID, string tenChuyenMon)
        {
            ChuyenMonID = chuyenMonID;
            TenChuyenMon = tenChuyenMon;
        }
    }
}
