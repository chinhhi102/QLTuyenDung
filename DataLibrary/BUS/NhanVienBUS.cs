using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAO;

namespace DataLibrary.BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }
        }
        private NhanVienBUS() { }
        public List<tbl_NhanVien> GetAllData()
        {
            return NhanVienDAO.Instance.GetAllData();
        }
        public List<tbl_NhanVien> GetAllDataSortByViTri()
        {
            return NhanVienDAO.Instance.GetAllDataSortByViTri();
        }
        public List<tbl_NhanVien> GetAllDataSortByPhongBan()
        {
            return NhanVienDAO.Instance.GetAllDataSortByPhongBan();
        }
        public List<tbl_NhanVien> GetAllDataSortByChuyenMon()
        {
            return NhanVienDAO.Instance.GetAllDataSortByChuyenMon();
        }
        public tbl_NhanVien GetOneData(int id)
        {
            return NhanVienDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return NhanVienDAO.Instance.DeleteData(id);
        }
        public tbl_NhanVien AddData(tbl_NhanVien data)
        {
            return NhanVienDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_NhanVien data)
        {
            return NhanVienDAO.Instance.UpdateData(data);
        }
    }
}
