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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using DataLibrary.BUS;
using DataLibrary.DTO;
using System.Drawing.Printing;

namespace QLTuyenDungApp.ThongBao
{
    public partial class frmChiTietMauBaoCao : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private tbl_MauThongBao mau = new tbl_MauThongBao();
        private int _id = -1;
        public frmChiTietMauBaoCao()
        {
            InitializeComponent();
        }
        public frmChiTietMauBaoCao(int id)
        {
            InitializeComponent();
            LoadData(id);
        }
        private void LoadData(int id)
        {
            _id = id;
            this.mau = MauThongBaoBUS.Instance.GetOneData(id);
            txtMaThongBao.Text = this.mau.ThongBaoID.ToString();
            txtNoiLamViec.Text = this.mau.NoiLamViec;
            txtYeuCauKiThuat.Text = this.mau.YeuCauKyThuat;
            txtSL.Text = this.mau.SL.ToString();
            txtViTri.Text = this.mau.ChucVu;
            txtYeuCauKhac.Text = this.mau.YeuCauKhac;
            txtYeuCauNgoaiNgu.Text = this.mau.YeuCauNgoaiNgu;
            txtTuoiTu.Text = this.mau.TuoiTu.ToString();
            txtTuoiDen.Text = this.mau.TuoiDen.ToString();
            txtMucLuong.Text = this.mau.MucLuong;
            txtThoiGianLamViec.Text = this.mau.ThoiGianLamViec;
            txtTinhTrangHonNhan.Text = this.mau.TinhTrangHonNhan;
            txtHinhThucTuyen.Text = this.mau.HinhThucTuyen;
            txtNgayTaoMau.Text = this.mau.NgayTaoMau.ToString("dd/MM/yyyy");
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmChiTietMauBaoCao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void SaveData()
        {
            if(txtHinhThucTuyen.Text == "" || txtMucLuong.Text == "" || txtNoiLamViec.Text == "" || txtSL.Text == "" || txtThoiGianLamViec.Text == "" || txtTinhTrangHonNhan.Text == "" || txtTuoiDen.Text == "" || txtTuoiTu.Text == "" || txtViTri.Text == "")
            {
                XtraMessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_id == -1)
            {
                int sl = Convert.ToInt32(txtSL.Text);
                int to = Convert.ToInt32(txtTuoiTu.Text);
                int from = Convert.ToInt32(txtTuoiDen.Text);
                mau = new tbl_MauThongBao();
                mau.NoiLamViec = txtNoiLamViec.Text;
                mau.YeuCauKyThuat = txtYeuCauKiThuat.Text;
                mau.SL = sl;
                mau.NoiLamViec = txtViTri.Text;
                mau.YeuCauKhac = txtYeuCauKhac.Text;
                mau.YeuCauNgoaiNgu = txtYeuCauNgoaiNgu.Text;
                mau.TuoiTu = to;
                mau.TuoiDen = from;
                mau.MucLuong = txtMucLuong.Text;
                mau.ThoiGianLamViec = txtThoiGianLamViec.Text;
                mau.TinhTrangHonNhan = txtTinhTrangHonNhan.Text;
                mau.HinhThucTuyen = txtHinhThucTuyen.Text;
                mau.NgayTaoMau = DateTime.Now;
                tbl_MauThongBao tb = MauThongBaoBUS.Instance.AddData(mau);
                _id = tb.ThongBaoID;
            }
            else
            {
                int sl = Convert.ToInt32(txtSL.Text);
                int to = Convert.ToInt32(txtTuoiTu.Text);
                int from = Convert.ToInt32(txtTuoiDen.Text);
                mau = new tbl_MauThongBao();
                mau.ChucVu = txtViTri.Text;
                mau.YeuCauKyThuat = txtYeuCauKiThuat.Text;
                mau.SL = sl;
                mau.NoiLamViec = txtNoiLamViec.Text;
                mau.YeuCauKhac = txtYeuCauKhac.Text;
                mau.YeuCauNgoaiNgu = txtYeuCauNgoaiNgu.Text;
                mau.TuoiTu = to;
                mau.TuoiDen = from;
                mau.MucLuong = txtMucLuong.Text;
                mau.ThoiGianLamViec = txtThoiGianLamViec.Text;
                mau.TinhTrangHonNhan = txtTinhTrangHonNhan.Text;
                mau.HinhThucTuyen = txtHinhThucTuyen.Text;
                mau.NgayTaoMau = DateTime.Now;
                MauThongBaoBUS.Instance.UpdateData(mau);
            }
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            this.Close();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn reset lại không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetData();
            }
        }
        private void ResetData()
        {
            txtHinhThucTuyen.Text = txtMaThongBao.Text = txtMucLuong.Text = txtNgayTaoMau.Text = txtNoiLamViec.Text = txtSL.Text = txtThoiGianLamViec.Text = txtTinhTrangHonNhan.Text = txtTuoiDen.Text = txtTuoiTu.Text = txtViTri.Text = txtYeuCauKhac.Text = txtYeuCauKiThuat.Text = txtYeuCauNgoaiNgu.Text = string.Empty;
        }
        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            _id = -1;
            ResetData();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MauThongBaoBUS.Instance.DeleteData(_id);
                _id = -1;
                ResetData();
            }
        }

        private void bbiPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Single yPos = 0;
            Single leftMargin = e.MarginBounds.Left;
            Single topMargin = e.MarginBounds.Top;
            Image img = Image.FromFile("logo.bmp");
            Rectangle logo = new Rectangle(40, 40, 50, 50);
            using (Font printFont = new Font("Arial", 20.0f))
            {
                e.Graphics.DrawImage(img, logo);
                e.Graphics.DrawString("Header", printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
            }
            using (SolidBrush blueBrush = new SolidBrush(Color.Black))
            {
                Rectangle rect = new Rectangle(100, 100, 500, 120);
                e.Graphics.FillRectangle(blueBrush, rect);
            }
        }
    }
}
