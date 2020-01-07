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
using DataLibrary.DTO;
using DataLibrary.BUS;

namespace QLTuyenDungApp.ThuNhanVaChonLoc
{
    public partial class frmHoSoDetail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _id = -1;
        List<tbl_PhongBan> listPhongBan = new List<tbl_PhongBan>();
        List<tbl_ChucVu> listChucVu = new List<tbl_ChucVu>();
        List<tbl_TrinhDoHocVan> listTrinhDoHocVan = new List<tbl_TrinhDoHocVan>();
        List<tbl_ChuyenMon> listChuyenMon = new List<tbl_ChuyenMon>();
        private tbl_NhanVien _hoSo = new tbl_NhanVien();

        public frmHoSoDetail()
        {
            InitializeComponent();
            Init();
        }
        public frmHoSoDetail(int id)
        {
            InitializeComponent();
            Init();
            LoadData(id);
        }
        private void Init()
        {
            dNgaySinh.Properties.MaxValue = DateTime.Now;
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
            _hoSo = NhanVienBUS.Instance.GetOneData(id);
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
        private void ResetData()
        {
            txtBacLuong.Text = txtDanToc.Text = txtDiaChi.Text = txtEmail.Text = txtHoTen.Text = txtMoTa.Text = txtSDT.Text = string.Empty;
        }
        private void SaveData()
        {
            if (cbbCM.Text == "" || cbbPhongBan.Text == "" || cbbTDHV.Text == "" || cbbViTri.Text == "" || txtBacLuong.Text == "" || txtDanToc.Text == "" || txtDiaChi.Text == "" || txtEmail.Text == "" || txtHoTen.Text == "" || txtMoTa.Text == "" || txtSDT.Text == "")
            {
                XtraMessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_id == -1)
            {
                int phongBanID = listPhongBan[cbbPhongBan.SelectedIndex ].PhongBanID;
                int chucVuID = listChucVu[cbbViTri.SelectedIndex].ChucVuID;
                int trinhdoID = listTrinhDoHocVan[cbbTDHV.SelectedIndex].TrinhDoHocVanID;
                int chuyenMonID = listChuyenMon[cbbCM.SelectedIndex].ChuyenMonID;
                tbl_NhanVien t = new tbl_NhanVien();
                t.HoTen = txtHoTen.Text;
                t.NgaySinh = Convert.ToDateTime(dNgaySinh.Text);
                t.QueQuan = txtDiaChi.Text;
                t.GioiTinh = (radioGroup1.SelectedIndex == 0);
                t.DanToc = txtDanToc.Text;
                t.SDT = txtSDT.Text;
                t.Email = txtEmail.Text;
                t.PhongBanID = phongBanID;
                t.ChucVuID = chucVuID;
                t.TDHVID = trinhdoID;
                t.LuongYeuCau = txtBacLuong.Text;
                t.TrangThai = 1;
                t.ChuyenMonID = chuyenMonID;
                _hoSo = NhanVienBUS.Instance.AddData(t);

                tbl_HoSoPV h = new tbl_HoSoPV();
                h.NhanVienID = _hoSo.NhanVienID;
                h = HoSoPVBUS.Instance.AddData(h);

                _hoSo.HoSoPVID = h.HoSoPVID;
                NhanVienBUS.Instance.UpdateData(_hoSo);
            }
            else
            {
                int phongBanID = listPhongBan[cbbPhongBan.SelectedIndex].PhongBanID;
                int chucVuID = listChucVu[cbbViTri.SelectedIndex].ChucVuID;
                int trinhdoID = listTrinhDoHocVan[cbbTDHV.SelectedIndex].TrinhDoHocVanID;
                int chuyenMonID = listChuyenMon[cbbCM.SelectedIndex].ChuyenMonID;
                tbl_NhanVien t = new tbl_NhanVien();
                t.NhanVienID = _hoSo.NhanVienID;
                t.HoTen = txtHoTen.Text;
                t.NgaySinh = Convert.ToDateTime(dNgaySinh.Text);
                t.QueQuan = txtDiaChi.Text;
                t.GioiTinh = (radioGroup1.SelectedIndex == 0);
                t.DanToc = txtDanToc.Text;
                t.SDT = txtSDT.Text;
                t.Email = txtEmail.Text;
                t.PhongBanID = phongBanID;
                t.ChucVuID = chucVuID;
                t.TDHVID = trinhdoID;
                t.LuongYeuCau = txtBacLuong.Text;
                t.TrangThai = 1;
                t.ChuyenMonID = chuyenMonID;
                t.HoSoPVID = _hoSo.HoSoPVID;

                NhanVienBUS.Instance.UpdateData(t);
                _hoSo = t;
            }
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if(_id != -1)
                {
                    int i = _hoSo.HoSoPVID ?? default(int);
                    HoSoPVBUS.Instance.DeleteData(i);
                    NhanVienBUS.Instance.DeleteData(_id);
                }
                ResetData();
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
        }

        private void bbiSaveAndNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            ResetData();
            _id = -1;
            _hoSo = new tbl_NhanVien();
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa trắng không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ResetData();
            }
        }

        private void frmHoSoDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
