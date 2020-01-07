using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class NhanVienDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private NhanVienDAO() { }
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }
        }
        public List<tbl_NhanVien> GetAllData()
        {
            try
            {
                List<tbl_NhanVien> list = db.tbl_NhanVien.ToList<tbl_NhanVien>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public List<tbl_NhanVien> GetAllDataSortByViTri()
        {
            try
            {
                List<tbl_NhanVien> list = db.tbl_NhanVien.GroupBy(x => x.ChucVuID).SelectMany(x => x.OrderBy(z => z.ChucVuID)).ToList();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public List<tbl_NhanVien> GetAllDataSortByPhongBan()
        {
            try
            {
                List<tbl_NhanVien> list = db.tbl_NhanVien.GroupBy(x => x.PhongBanID).SelectMany(x => x.OrderBy(y => y.PhongBanID)).ToList();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public List<tbl_NhanVien> GetAllDataSortByChuyenMon()
        {
            try
            {
                List<tbl_NhanVien> list = db.tbl_NhanVien.GroupBy(x => x.ChuyenMonID).SelectMany(x => x.OrderBy(y => y.ChuyenMonID)).ToList();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_NhanVien GetOneData(int id)
        {
            try
            {
                tbl_NhanVien data = db.tbl_NhanVien.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_NhanVien AddData(tbl_NhanVien data)
        {
            try
            {
                tbl_NhanVien d = db.tbl_NhanVien.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_NhanVien data)
        {
            try
            {
                var update = db.tbl_NhanVien.Find(data.NhanVienID);
                update.copy(data);
                db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return 0;
            }
        }
        public int DeleteData(int id)
        {
            try
            {
                tbl_NhanVien tb = db.tbl_NhanVien.Find(id);
                db.tbl_NhanVien.Remove(tb);
                db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}