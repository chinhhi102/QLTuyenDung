using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAO;

namespace DataLibrary.BUS
{
    public class TinhHinhThuViecBUS
    {
        private static TinhHinhThuViecBUS instance;
        public static TinhHinhThuViecBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhHinhThuViecBUS();
                }
                return instance;
            }
        }
        private TinhHinhThuViecBUS() { }
        public List<tbl_TinhHinhThuViec> GetAllData()
        {
            return TinhHinhThuViecDAO.Instance.GetAllData();
        }
        public List<tbl_TinhHinhThuViec> GetAllDataByTVID(int id)
        {
            return TinhHinhThuViecDAO.Instance.GetAllDataByTVID(id);
        }
        public tbl_TinhHinhThuViec GetOneData(int id)
        {
            return TinhHinhThuViecDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return TinhHinhThuViecDAO.Instance.DeleteData(id);
        }
        public tbl_TinhHinhThuViec AddData(tbl_TinhHinhThuViec data)
        {
            return TinhHinhThuViecDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_TinhHinhThuViec data)
        {
            return TinhHinhThuViecDAO.Instance.UpdateData(data);
        }
    }
}
