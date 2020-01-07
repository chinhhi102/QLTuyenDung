using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAO;

namespace DataLibrary.BUS
{
    public class ChuyenMonBUS
    {
        private static ChuyenMonBUS instance;
        public static ChuyenMonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenMonBUS();
                }
                return instance;
            }
        }
        private ChuyenMonBUS() { }
        public List<tbl_ChuyenMon> GetAllData()
        {
            return ChuyenMonDAO.Instance.GetAllData();
        }
        public tbl_ChuyenMon GetOneData(int id)
        {
            return ChuyenMonDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return ChuyenMonDAO.Instance.DeleteData(id);
        }
        public tbl_ChuyenMon AddData(tbl_ChuyenMon data)
        {
            return ChuyenMonDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_ChuyenMon data)
        {
            return ChuyenMonDAO.Instance.UpdateData(data);
        }
    }
}
