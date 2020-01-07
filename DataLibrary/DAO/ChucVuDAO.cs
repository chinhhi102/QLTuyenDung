using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class ChucVuDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private ChucVuDAO() { }
        private static ChucVuDAO instance;
        public static ChucVuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChucVuDAO();
                }
                return instance;
            }
        }
        public List<tbl_ChucVu> GetAllData()
        {
            try
            {
                List<tbl_ChucVu> list = db.tbl_ChucVu.ToList<tbl_ChucVu>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ChucVu GetOneData(int id)
        {
            try
            {
                tbl_ChucVu data = db.tbl_ChucVu.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ChucVu AddData(tbl_ChucVu data)
        {
            try
            {
                tbl_ChucVu d = db.tbl_ChucVu.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_ChucVu data)
        {
            try
            {
                var update = db.tbl_ChucVu.Find(data.ChucVuID);
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
                tbl_ChucVu tb = db.tbl_ChucVu.Find(id);
                db.tbl_ChucVu.Remove(tb);
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