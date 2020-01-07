using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class HoSoPVDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private HoSoPVDAO() { }
        private static HoSoPVDAO instance;
        public static HoSoPVDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoSoPVDAO();
                }
                return instance;
            }
        }
        public List<tbl_HoSoPV> GetAllData()
        {
            try
            {
                List<tbl_HoSoPV> list = db.tbl_HoSoPV.ToList<tbl_HoSoPV>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_HoSoPV GetOneData(int id)
        {
            try
            {
                tbl_HoSoPV data = db.tbl_HoSoPV.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_HoSoPV AddData(tbl_HoSoPV data)
        {
            try
            {
                tbl_HoSoPV d = db.tbl_HoSoPV.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_HoSoPV data)
        {
            try
            {
                var update = db.tbl_HoSoPV.Find(data.HoSoPVID);
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
                tbl_HoSoPV tb = db.tbl_HoSoPV.Find(id);
                db.tbl_HoSoPV.Remove(tb);
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