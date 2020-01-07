using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class ThuViecDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private ThuViecDAO() { }
        private static ThuViecDAO instance;
        public static ThuViecDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuViecDAO();
                }
                return instance;
            }
        }
        public List<tbl_ThuViec> GetAllData()
        {
            try
            {
                List<tbl_ThuViec> list = db.tbl_ThuViec.ToList<tbl_ThuViec>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ThuViec GetOneData(int id)
        {
            try
            {
                tbl_ThuViec data = db.tbl_ThuViec.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ThuViec GetOneDataByNVID(int id)
        {
            try
            {
                tbl_ThuViec data = db.tbl_ThuViec.Find(new tbl_ThuViec(){ NhanVienID = id });
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ThuViec AddData(tbl_ThuViec data)
        {
            try
            {
                tbl_ThuViec d = db.tbl_ThuViec.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_ThuViec data)
        {
            try
            {
                var update = db.tbl_ThuViec.Find(data.ThuViecID);
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
                tbl_ThuViec tb = db.tbl_ThuViec.Find(id);
                db.tbl_ThuViec.Remove(tb);
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