using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class PhongBanDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private PhongBanDAO() { }
        private static PhongBanDAO instance;
        public static PhongBanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhongBanDAO();
                }
                return instance;
            }
        }
        public List<tbl_PhongBan> GetAllData()
        {
            try
            {
                List<tbl_PhongBan> list = db.tbl_PhongBan.ToList<tbl_PhongBan>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_PhongBan GetOneData(int id)
        {
            try
            {
                tbl_PhongBan data = db.tbl_PhongBan.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_PhongBan AddData(tbl_PhongBan data)
        {
            try
            {
                tbl_PhongBan d = db.tbl_PhongBan.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_PhongBan data)
        {
            try
            {
                var update = db.tbl_PhongBan.Find(data.PhongBanID);
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
                tbl_PhongBan tb = db.tbl_PhongBan.Find(id);
                db.tbl_PhongBan.Remove(tb);
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