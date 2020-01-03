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
        public List<MauThongBaoDTO> GetAllData()
        {
            return MauThongBaoDAO.Instance.GetAllMauThongBao();
        }
        public int AddData(MauThongBaoDTO mauThongBao)
        {
            return MauThongBaoDAO.Instance.AddData(mauThongBao);
        }
    }
}
