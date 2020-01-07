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

namespace QLTuyenDungApp.CapNhapTinhHinh
{
    public partial class frmThemTinhHinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _id = -1;
        private int id = -1;
        List<tbl_PhongBan> listPhongBan = new List<tbl_PhongBan>();
        List<tbl_ChucVu> listChucVu = new List<tbl_ChucVu>();
        List<tbl_TrinhDoHocVan> listTrinhDoHocVan = new List<tbl_TrinhDoHocVan>();
        List<tbl_ChuyenMon> listChuyenMon = new List<tbl_ChuyenMon>();
        private tbl_NhanVien _hoSo = new tbl_NhanVien();
        private tbl_ThuViec _tv = new tbl_ThuViec();
        private tbl_TinhHinhThuViec _thtv = new tbl_TinhHinhThuViec();

        public frmThemTinhHinh()
        {
            InitializeComponent();
        }
        public frmThemTinhHinh(int mid)
        {
            InitializeComponent();
            _id = mid;
            Init();
            LoadData();
        }
        public frmThemTinhHinh(int mid, int kid)
        {
            InitializeComponent();
            _id = mid;
            id = kid;
            Init();
            LoadData();
        }
        private void Init()
        {
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

            _tv = ThuViecBUS.Instance.GetOneData(_id);
            _hoSo = NhanVienBUS.Instance.GetOneData(_tv.NhanVienID ?? default(int));

            txtHoTen.Text = _hoSo.HoTen;
            dNgaySinh.EditValue = _hoSo.NgaySinh;
            txtBacLuong.Text = _hoSo.LuongYeuCau;
            txtDanToc.Text = _hoSo.DanToc;
            txtDiaChi.Text = _hoSo.DanToc;
            txtEmail.Text = _hoSo.Email;
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
        private void LoadData()
        {
            if (id != -1)
            {
                _thtv = TinhHinhThuViecBUS.Instance.GetOneData(id);
                txtHieuQua.Text = _thtv.HieuQuaLamViec;
                txtKhaNang.Text = _thtv.KhaNangLamViec;
                txtKinhNghiem.Text = _thtv.KinhNghiemLamViec;
                txtThaiDo.Text = _thtv.ThaiDoLamViec;
            }
        }
        private void SaveData()
        {
            if(txtThaiDo.Text == "" || txtKinhNghiem.Text == "" || txtKhaNang.Text == "" || txtKinhNghiem.Text == "")
            {
                XtraMessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _thtv.HieuQuaLamViec = txtThaiDo.Text;
            _thtv.KhaNangLamViec = txtKhaNang.Text;
            _thtv.KinhNghiemLamViec = txtKinhNghiem.Text;
            _thtv.ThaiDoLamViec = txtThaiDo.Text;
            _thtv.ThuViecID = _tv.ThuViecID;
            _thtv.NgayCapNhap = DateTime.Now;
            if (id == -1)
            {
                _thtv = TinhHinhThuViecBUS.Instance.AddData(_thtv);
                id = _thtv.TinhHinhThuViecID;
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TinhHinhThuViecBUS.Instance.UpdateData(_thtv);
                XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmThemTinhHinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (id == -1)
            {
                XtraMessageBox.Show("Không có gì để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int kq = TinhHinhThuViecBUS.Instance.DeleteData(id);
                if (kq == -1)
                {
                    XtraMessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _thtv = new tbl_TinhHinhThuViec();
                id = -1;
                ResetData();
            }
        }
        private void ResetData()
        {
            txtThaiDo.Text = txtKinhNghiem.Text = txtKhaNang.Text = txtHieuQua.Text = string.Empty;
        }
        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn làm trắng không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetData();
            }
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            ResetData();
            id = -1;
            _thtv = new tbl_TinhHinhThuViec();
        }
    }
}