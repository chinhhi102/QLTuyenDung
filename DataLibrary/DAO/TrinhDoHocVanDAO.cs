using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class TrinhDoHocVanDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private TrinhDoHocVanDAO() { }
        private static TrinhDoHocVanDAO instance;
        public static TrinhDoHocVanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TrinhDoHocVanDAO();
                }
                return instance;
            }
        }
        public List<tbl_TrinhDoHocVan> GetAllData()
        {
            try
            {
                List<tbl_TrinhDoHocVan> list = db.tbl_TrinhDoHocVan.ToList<tbl_TrinhDoHocVan>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TrinhDoHocVan GetOneData(int id)
        {
            try
            {
                tbl_TrinhDoHocVan data = db.tbl_TrinhDoHocVan.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TrinhDoHocVan AddData(tbl_TrinhDoHocVan data)
        {
            try
            {
                tbl_TrinhDoHocVan d = db.tbl_TrinhDoHocVan.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_TrinhDoHocVan data)
        {
            try
            {
                var update = db.tbl_TrinhDoHocVan.Find(data.TrinhDoHocVanID);
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
                tbl_TrinhDoHocVan tb = db.tbl_TrinhDoHocVan.Find(id);
                db.tbl_TrinhDoHocVan.Remove(tb);
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