using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;

namespace DataLibrary.DAO
{
    public class MauThongBaoDAO
    {
        TuyenDungModels db = new TuyenDungModels();
        private MauThongBaoDAO() { }
        private static MauThongBaoDAO instance;
        public static MauThongBaoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MauThongBaoDAO();
                }
                return instance;
            }
        }
        public List<tbl_MauThongBao> GetAllData()
        {
            try
            {
                List<tbl_MauThongBao> list = db.tbl_MauThongBao.ToList<tbl_MauThongBao>();
                return list;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_MauThongBao GetOneData(int id)
        {
            try
            {
                tbl_MauThongBao data = db.tbl_MauThongBao.Find(id);
                return data;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public tbl_MauThongBao AddData(tbl_MauThongBao data)
        {
            try
            {
                tbl_MauThongBao d = db.tbl_MauThongBao.Add(data);
                db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public int UpdateData(tbl_MauThongBao data)
        {
            try
            {
                var update = db.tbl_MauThongBao.Find(data.ThongBaoID);
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
                tbl_MauThongBao tb = db.tbl_MauThongBao.Find(id);
                db.tbl_MauThongBao.Remove(tb);
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