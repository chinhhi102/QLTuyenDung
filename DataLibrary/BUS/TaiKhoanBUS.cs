using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAO;

namespace DataLibrary.BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;
        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanBUS();
                }
                return instance;
            }
        }
        private TaiKhoanBUS() { }
        public List<tbl_TaiKhoan> GetAllData()
        {
            return TaiKhoanDAO.Instance.GetAllData();
        }
        public tbl_TaiKhoan GetOneData(int id)
        {
            return TaiKhoanDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return TaiKhoanDAO.Instance.DeleteData(id);
        }
        public tbl_TaiKhoan AddData(tbl_TaiKhoan data)
        {
            return TaiKhoanDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_TaiKhoan data)
        {
            return TaiKhoanDAO.Instance.UpdateData(data);
        }
    }
}
