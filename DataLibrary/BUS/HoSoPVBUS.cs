using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAO;

namespace DataLibrary.BUS
{
    public class HoSoPVBUS
    {
        private static HoSoPVBUS instance;
        public static HoSoPVBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoSoPVBUS();
                }
                return instance;
            }
        }
        private HoSoPVBUS() { }
        public List<tbl_HoSoPV> GetAllData()
        {
            return HoSoPVDAO.Instance.GetAllData();
        }
        public tbl_HoSoPV GetOneData(int id)
        {
            return HoSoPVDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return HoSoPVDAO.Instance.DeleteData(id);
        }
        public tbl_HoSoPV AddData(tbl_HoSoPV data)
        {
            return HoSoPVDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_HoSoPV data)
        {
            return HoSoPVDAO.Instance.UpdateData(data);
        }
    }
}
