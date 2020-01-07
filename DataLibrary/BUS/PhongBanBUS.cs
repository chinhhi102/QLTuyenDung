using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DAO;
using DataLibrary.DTO;

namespace DataLibrary.BUS
{
    public class PhongBanBUS
    {
        private static PhongBanBUS instance;
        public static PhongBanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongBanBUS();
                }
                return instance;
            }
        }
        private PhongBanBUS() { }
        public List<tbl_PhongBan> GetAllData()
        {
            return PhongBanDAO.Instance.GetAllData();
        }
        public tbl_PhongBan GetOneData(int id)
        {
            return PhongBanDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return PhongBanDAO.Instance.DeleteData(id);
        }
        public tbl_PhongBan AddData(tbl_PhongBan data)
        {
            return PhongBanDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_PhongBan data)
        {
            return PhongBanDAO.Instance.UpdateData(data);
        }
    }
}
