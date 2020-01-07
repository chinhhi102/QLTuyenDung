using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class ChuyenMonDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private ChuyenMonDAO() { }
        private static ChuyenMonDAO instance;
        public static ChuyenMonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenMonDAO();
                }
                return instance;
            }
        }
        public List<tbl_ChuyenMon> GetAllData()
        {
            try
            {
                List<tbl_ChuyenMon> list = db.tbl_ChuyenMon.ToList<tbl_ChuyenMon>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ChuyenMon GetOneData(int id)
        {
            try
            {
                tbl_ChuyenMon data = db.tbl_ChuyenMon.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_ChuyenMon AddData(tbl_ChuyenMon data)
        {
            try
            {
                tbl_ChuyenMon d = db.tbl_ChuyenMon.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_ChuyenMon data)
        {
            try
            {
                var update = db.tbl_ChuyenMon.Find(data.ChuyenMonID);
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
                tbl_ChuyenMon tb = db.tbl_ChuyenMon.Find(id);
                db.tbl_ChuyenMon.Remove(tb);
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