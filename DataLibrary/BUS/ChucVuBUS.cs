using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DAO;
using DataLibrary.DTO;

namespace DataLibrary.BUS
{
    public class ChucVuBUS
    {
        private static ChucVuBUS instance;
        public static ChucVuBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuBUS();
                }
                return instance;
            }
        }
        private ChucVuBUS() { }
        public List<tbl_ChucVu> GetAllData()
        {
            return ChucVuDAO.Instance.GetAllData();
        }
        public tbl_ChucVu GetOneData(int id)
        {
            return ChucVuDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return ChucVuDAO.Instance.DeleteData(id);
        }
        public tbl_ChucVu AddData(tbl_ChucVu data)
        {
            return ChucVuDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_ChucVu data)
        {
            return ChucVuDAO.Instance.UpdateData(data);
        }
    }
}
