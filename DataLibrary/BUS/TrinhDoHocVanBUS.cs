using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DAO;
using DataLibrary.DTO;

namespace DataLibrary.BUS
{
    public class TrinhDoHocVanBUS
    {
        private static TrinhDoHocVanBUS instance;
        public static TrinhDoHocVanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrinhDoHocVanBUS();
                }
                return instance;
            }
        }
        private TrinhDoHocVanBUS() { }
        public List<tbl_TrinhDoHocVan> GetAllData()
        {
            return TrinhDoHocVanDAO.Instance.GetAllData();
        }
        public tbl_TrinhDoHocVan GetOneData(int id)
        {
            return TrinhDoHocVanDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return TrinhDoHocVanDAO.Instance.DeleteData(id);
        }
        public tbl_TrinhDoHocVan AddData(tbl_TrinhDoHocVan data)
        {
            return TrinhDoHocVanDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_TrinhDoHocVan data)
        {
            return TrinhDoHocVanDAO.Instance.UpdateData(data);
        }
    }
}
