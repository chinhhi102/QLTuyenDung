using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DAO;
using DataLibrary.DTO;

namespace DataLibrary.BUS
{
    public class MauThongBaoBUS
    {
        private static MauThongBaoBUS instance;
        public static MauThongBaoBUS Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MauThongBaoBUS();
                }
                return instance;
            }
        }
        private MauThongBaoBUS() { }
        public List<tbl_MauThongBao> GetAllData()
        {
            return MauThongBaoDAO.Instance.GetAllData();
        }
        public tbl_MauThongBao GetOneData(int id)
        {
            return MauThongBaoDAO.Instance.GetOneData(id);
        }
        public int DeleteData(int id)
        {
            return MauThongBaoDAO.Instance.DeleteData(id);
        }
        public tbl_MauThongBao AddData(tbl_MauThongBao data)
        {
            return MauThongBaoDAO.Instance.AddData(data);
        }
        public int UpdateData(tbl_MauThongBao data)
        {
            return MauThongBaoDAO.Instance.UpdateData(data);
        }
    }
}
