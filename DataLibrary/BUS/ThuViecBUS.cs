using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DAO;
using DataLibrary.DTO;

namespace DataLibrary.BUS
{
    public class ThuViecBUS
    {
        private static ThuViecBUS instance;
        public static ThuViecBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuViecBUS();
                }
                return instance;
            }
        }
        private ThuViecBUS() { }
        public List<tbl_ThuViec> GetAllData()
        {
            return ThuViecDAO.Instance.GetAllData();
        }
        public tbl_ThuViec GetOneData(int id)
        {
            return ThuViecDAO.Instance.GetOneData(id);
        }
        public tbl_ThuViec GetOneDataByNVID(int id)
        {
            return ThuViecDAO.Instance.GetOneDataByNVID(id);
        }
        public int DeleteData(int id)
        {
            return ThuViecDAO.Instance.DeleteData(id);
        }
        public tbl_ThuViec AddData(tbl_ThuViec data)
        {
            return ThuViecDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_ThuViec data)
        {
            return ThuViecDAO.Instance.UpdateData(data);
        }
    }
}
