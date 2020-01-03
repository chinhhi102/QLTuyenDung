using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class TrinhDoHocVanDTO
    {
        public TrinhDoHocVanDTO(string tenTrinhDoHocVan, int chuyenMonID)
        {
            TenTrinhDoHocVan = tenTrinhDoHocVan;
            ChuyenMonID = chuyenMonID;
        }
        public TrinhDoHocVanDTO() { }
        public TrinhDoHocVanDTO(TrinhDoHocVanDTO other)
        {
            TrinhDoHocVanID = other.TrinhDoHocVanID;
            TenTrinhDoHocVan = other.TenTrinhDoHocVan;
            ChuyenMonID = other.ChuyenMonID;
        }

        public TrinhDoHocVanDTO(int trinhDoHocVanID, string tenTrinhDoHocVan, int chuyenMonID)
        {
            TrinhDoHocVanID = trinhDoHocVanID;
            TenTrinhDoHocVan = tenTrinhDoHocVan;
            ChuyenMonID = chuyenMonID;
        }

        public int TrinhDoHocVanID { get; set; }
        public string TenTrinhDoHocVan { get; set; }
        public int ChuyenMonID { get; set; }
    }
}
