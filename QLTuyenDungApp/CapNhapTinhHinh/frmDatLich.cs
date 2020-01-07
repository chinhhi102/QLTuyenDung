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
using System.Diagnostics;

namespace QLTuyenDungApp.CapNhapTinhHinh
{
    public partial class frmDatLich : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _id = -1;
        List<tbl_PhongBan> listPhongBan = new List<tbl_PhongBan>();
        List<tbl_ChucVu> listChucVu = new List<tbl_ChucVu>();
        List<tbl_TrinhDoHocVan> listTrinhDoHocVan = new List<tbl_TrinhDoHocVan>();
        List<tbl_ChuyenMon> listChuyenMon = new List<tbl_ChuyenMon>();
        private tbl_NhanVien _hoSo = new tbl_NhanVien();
        private tbl_ThuViec _tv = new tbl_ThuViec();

        public frmDatLich()
        {
            InitializeComponent();
            Init();
        }
        public frmDatLich(int id)
        {
            InitializeComponent();
            Init();
            LoadData(id);
        }
        private void Init()
        {
            ideBatDau.MinValue = DateTime.Now;
            listPhongBan = PhongBanBUS.Instance.GetAllData();
            foreach (var t in listPhongBan)
            {
                cbbPhongBan.Properties.Items.Add(t.TenPhongBan);
            }
            listChucVu = ChucVuBUS.Instance.GetAllData();
            foreach (var t in listChucVu)
            {
                cbbViTri.Properties.Items.Add(t.TenChucVu);
            }
            listTrinhDoHocVan = TrinhDoHocVanBUS.Instance.GetAllData();
            foreach (var t in listTrinhDoHocVan)
            {
                cbbTDHV.Properties.Items.Add(t.TenTrinhDoHocVan);
            }
            listChuyenMon = ChuyenMonBUS.Instance.GetAllData();
            foreach (var t in listChuyenMon)
            {
                cbbCM.Properties.Items.Add(t.TenChuyenMon);
            }
        }
        private void LoadData(int id)
        {
            _id = id;
            _tv = ThuViecBUS.Instance.GetOneData(id);
            _hoSo = NhanVienBUS.Instance.GetOneData(_tv.NhanVienID ?? default(int));
            txtHoTen.Text = _hoSo.HoTen;
            dNgaySinh.EditValue = _hoSo.NgaySinh;
            txtBacLuong.Text = _hoSo.LuongYeuCau;
            txtDanToc.Text = _hoSo.DanToc;
            txtDiaChi.Text = _hoSo.DanToc;
            txtEmail.Text = _hoSo.Email;
            txtMoTa.Text = _hoSo.Mota;
            txtSDT.Text = _hoSo.SDT;
            radioGroup1.SelectedIndex = _hoSo.GioiTinh ?? default(bool) ? 0 : 1;
            for (int i = 0; i < listChuyenMon.Count; ++i)
            {
                if (listChuyenMon[i].ChuyenMonID == _hoSo.ChuyenMonID)
                {
                    cbbCM.SelectedIndex = i;
                }
            }
            for (int i = 0; i < listPhongBan.Count; ++i)
            {
                if (listPhongBan[i].PhongBanID == _hoSo.PhongBanID)
                {
                    cbbPhongBan.SelectedIndex = i;
                }
            }
            for (int i = 0; i < listChucVu.Count; ++i)
            {
                if (listChucVu[i].ChucVuID == _hoSo.ChucVuID)
                {
                    cbbViTri.SelectedIndex = i;
                }
            }
            for (int i = 0; i < listTrinhDoHocVan.Count; ++i)
            {
                if (listTrinhDoHocVan[i].TrinhDoHocVanID == _hoSo.TDHVID)
                {
                    cbbTDHV.SelectedIndex = i;
                }
            }
        }
        private void SaveData()
        {
            if(beiBatDau.EditValue == null || beiThoiGian.EditValue == null)
            {
                XtraMessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _tv.NgayThuViec = (DateTime)beiBatDau.EditValue;
            _tv.NgayKetThucThuViec = _tv.NgayThuViec.Value.AddDays(Convert.ToDouble(beiThoiGian.EditValue));
            _hoSo.TrangThai = 4;
            int sts = ThuViecBUS.Instance.UpdateData(_tv);
            int sts2 = NhanVienBUS.Instance.UpdateData(_hoSo);
            if (sts == -1 || sts2 == -1)
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            this.Close();
        }
        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }
        private void frmHoSoDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void bbiMail_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            Process.Start("mailto:" + txtEmail);
        }

        private void bbiMail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Process.Start("mailto:" + txtEmail.Text);
        }
    }
}
