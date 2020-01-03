using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataLibrary.BUS;
using DataLibrary.DTO;

namespace QLTuyenDungApp.ThongBao
{
    public partial class frmThongBao : DevExpress.XtraEditors.XtraForm
    {
        public frmThongBao()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            List<MauThongBaoDTO> list = MauThongBaoBUS.Instance.GetAllData();
            var bindingList = new BindingList<MauThongBaoDTO>(list);
            var source = new BindingSource(bindingList, null);
            mauThongBaoDTOBindingSource.DataSource = source;
        }
        private void frmThongBao_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            var list = mauThongBaoDTOBindingSource.List.Cast<MauThongBaoDTO>().ToList<MauThongBaoDTO>();

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            int SL = (txtSL.Text == string.Empty) ? 0 : Convert.ToInt32(txtSL.Text);
            int from = (txtTuoiTu.Text == string.Empty) ? 0 : Convert.ToInt32(txtTuoiTu.Text);
            int to = (txtTuoiDen.Text == string.Empty) ? 0 : Convert.ToInt32(txtTuoiDen.Text);
            MauThongBaoDTO newMau = new MauThongBaoDTO(txtNoiLamViec.Text, txtYeuCauKiThuat.Text, SL, txtViTri.Text, txtYeuCauKhac.Text, txtYeuCauNgoaiNgu.Text, from, to , txtMucLuong.Text, txtThoiGianLamViec.Text, txtTinhTrangHonNhan.Text, txtHinhThucTuyen.Text, DateTime.Now);
            MauThongBaoBUS.Instance.AddData(newMau);
            LoadData();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {

        }

        private void bntXoaTrang_Click(object sender, EventArgs e)
        {
            txtHinhThucTuyen.Text = txtMaThongBao.Text = txtMucLuong.Text = txtNoiLamViec.Text = txtSL.Text = txtThoiGianLamViec.Text = txtTinhTrangHonNhan.Text = txtTuoiDen.Text = txtTuoiTu.Text = txtViTri.Text = txtYeuCauKhac.Text = txtYeuCauKiThuat.Text = txtYeuCauNgoaiNgu.Text = string.Empty;
        }
    }
}