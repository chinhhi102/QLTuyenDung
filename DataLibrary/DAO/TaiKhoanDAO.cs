using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class TaiKhoanDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private TaiKhoanDAO() { }
        private static TaiKhoanDAO instance;
        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
        }
        public List<tbl_TaiKhoan> GetAllData()
        {
            try
            {
                List<tbl_TaiKhoan> list = db.tbl_TaiKhoan.ToList<tbl_TaiKhoan>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TaiKhoan GetOneData(int id)
        {
            try
            {
                tbl_TaiKhoan data = db.tbl_TaiKhoan.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_TaiKhoan AddData(tbl_TaiKhoan data)
        {
            try
            {
                tbl_TaiKhoan d = db.tbl_TaiKhoan.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_TaiKhoan data)
        {
            try
            {
                var update = db.tbl_TaiKhoan.Find(data.TaiKhoanID);
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
                tbl_TaiKhoan tb = db.tbl_TaiKhoan.Find(id);
                db.tbl_TaiKhoan.Remove(tb);
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