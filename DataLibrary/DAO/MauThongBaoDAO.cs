using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DTO;
using DataLibrary.DAL;

namespace DataLibrary.DAO
{
    class MauThongBaoDAO
    {
        private MauThongBaoDAO() { }
        private static MauThongBaoDAO instance;
        public static MauThongBaoDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new MauThongBaoDAO();
                }
                return instance;
            }
        }
        public List<MauThongBaoDTO> GetAllMauThongBao() {
            List<MauThongBaoDTO> listMauThongBao = new List<MauThongBaoDTO>();
            try
            {
                string sql = String.Format("SELECT * FROM dbo.tbl_MauThongBao");
                DataTable data = SqlServerHelper.ExecuteDataTable(sql, CommandType.Text);

                foreach (DataRow dr in data.Rows)
                {
                    int mauThongBaoID = Convert.ToInt32(dr[0].ToString());
                    string noiLamViec = dr[1].ToString();
                    string yeuCauKyThuat = dr[2].ToString();
                    int sL = (dr[3].ToString() == string.Empty) ? -1 : Convert.ToInt32(dr[3].ToString());
                    string chucVu = dr[4].ToString();
                    string yeuCauKhac = dr[5].ToString();
                    string yeuCauNgoaiNgu = dr[6].ToString();
                    int tuoiTu = (dr[7].ToString() == string.Empty) ? -1 : Convert.ToInt32(dr[7].ToString());
                    int tuoiDen = (dr[8].ToString() == string.Empty) ? -1 : Convert.ToInt32(dr[8].ToString());
                    string mucLuong = dr[9].ToString();
                    string thoiGianLamViec = dr[10].ToString();
                    string tinhTrangHonNhan = dr[11].ToString();
                    string hinhThucTuyen = dr[12].ToString();
                    DateTime ngayTaoMau = DateTime.Parse(dr[13].ToString());

                    MauThongBaoDTO mau = new MauThongBaoDTO(mauThongBaoID, noiLamViec, yeuCauKyThuat, sL, chucVu, yeuCauKhac, yeuCauNgoaiNgu, tuoiTu, tuoiDen, mucLuong, thoiGianLamViec, tinhTrangHonNhan, hinhThucTuyen, ngayTaoMau);

                    listMauThongBao.Add(mau);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
            return listMauThongBao;
        }
        public int AddData(MauThongBaoDTO mauThongBao)
        {
            try
            {
                string sql = String.Format("INSERT INTO dbo.tbl_MauThongBao VALUES(@NoiLamViec, @YeuCauKyThuat, @SL, " +
                    "@ChucVuID, @YeuCauKhac, @YeuCauNgoaiNgu, @TuoiTu, @TuoiDen, @MucLuong, @ThoiGianLamViec, @TinhTrangHonNhan, " +
                    "@HinhThucTuyen, @NgayTaoMau)");

                SqlServerHelper.ExecuteNonQuery(sql, CommandType.Text,
                    "@NoiLamViec", SqlDbType.NVarChar, mauThongBao.NoiLamViec,
                    "@YeuCauKyThuat", SqlDbType.NVarChar, mauThongBao.YeuCauKyThuat,
                    "@SL", SqlDbType.Int, mauThongBao.SL,
                    "@ChucVuID", SqlDbType.Int, mauThongBao.ChucVu,
                    "@YeuCauKhac", SqlDbType.NVarChar, mauThongBao.YeuCauKhac,
                    "@YeuCauNgoaiNgu", SqlDbType.NVarChar, mauThongBao.YeuCauNgoaiNgu,
                    "@TuoiTu", SqlDbType.Int, mauThongBao.TuoiTu,
                    "@TuoiDen", SqlDbType.Int, mauThongBao.TuoiDen,
                    "@MucLuong", SqlDbType.NVarChar, mauThongBao.MucLuong,
                    "@ThoiGianLamViec", SqlDbType.NVarChar, mauThongBao.ThoiGianLamViec,
                    "@TinhTrangHonNhan", SqlDbType.NVarChar, mauThongBao.TinhTrangHonNhan,
                    "@HinhThucTuyen", SqlDbType.NVarChar, mauThongBao.HinhThucTuyen,
                    "@NgayTaoMau", SqlDbType.Date, mauThongBao.NgayTaoMau
                    );
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return 0;
            }
            return 1;
        }
    }
}
