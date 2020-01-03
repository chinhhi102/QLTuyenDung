using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DTO
{
    public class PhongBanDTO
    {
        public PhongBanDTO(string tenPhongBan, string diaChi, string sDTPB)
        {
            TenPhongBan = tenPhongBan;
            DiaChi = diaChi;
            SDTPB = sDTPB;
        }
        public PhongBanDTO() { }
        public PhongBanDTO(PhongBanDTO other)
        {
            PhongBanID = other.PhongBanID;
            TenPhongBan = other.TenPhongBan;
            DiaChi = other.DiaChi;
            SDTPB = other.SDTPB;
        }

        public PhongBanDTO(int phongBanID, string tenPhongBan, string diaChi, string sDTPB)
        {
            PhongBanID = phongBanID;
            TenPhongBan = tenPhongBan;
            DiaChi = diaChi;
            SDTPB = sDTPB;
        }

        public int PhongBanID { get; set; }
        public string TenPhongBan { get; set; }
        public string DiaChi { get; set; }
        public string SDTPB { get; set; }
    }
}
