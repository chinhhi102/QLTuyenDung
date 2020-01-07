using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class TinhHinhThuViecDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private TinhHinhThuViecDAO() { }
        private static TinhHinhThuViecDAO instance;
        public static TinhHinhThuViecDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TinhHinhThuViecDAO();
                }
                return instance;
            }
        }
        public List<tbl_TinhHinhThuViec> GetAllData()
        {
            try
            {
                List<tbl_TinhHinhThuViec> list = db.tbl_TinhHinhThuViec.ToList<tbl_TinhHinhThuViec>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public List<tbl_TinhHinhThuViec> GetAllDataByTVID(int id)
        {
            try
            {
                List<tbl_TinhHinhThuViec> list = (from b in db.tbl_TinhHinhThuViec where b.ThuViecID == id select b).ToList<tbl_TinhHinhThuViec>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TinhHinhThuViec GetOneData(int id)
        {
            try
            {
                tbl_TinhHinhThuViec data = db.tbl_TinhHinhThuViec.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TinhHinhThuViec AddData(tbl_TinhHinhThuViec data)
        {
            try
            {
                tbl_TinhHinhThuViec d = db.tbl_TinhHinhThuViec.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_TinhHinhThuViec data)
        {
            try
            {
                var update = db.tbl_TinhHinhThuViec.Find(data.TinhHinhThuViecID);
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
                tbl_TinhHinhThuViec tb = db.tbl_TinhHinhThuViec.Find(id);
                db.tbl_TinhHinhThuViec.Remove(tb);
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