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

namespace QLTuyenDungApp.XuLyHoSo
{
    public partial class frmKQHoSoPV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _id = -1;
        List<tbl_PhongBan> listPhongBan = new List<tbl_PhongBan>();
        List<tbl_ChucVu> listChucVu = new List<tbl_ChucVu>();
        List<tbl_TrinhDoHocVan> listTrinhDoHocVan = new List<tbl_TrinhDoHocVan>();
        List<tbl_ChuyenMon> listChuyenMon = new List<tbl_ChuyenMon>();
        private tbl_NhanVien _hoSo = new tbl_NhanVien();
        private tbl_HoSoPV _pv = new tbl_HoSoPV();

        public frmKQHoSoPV()
        {
            InitializeComponent();
        }
        public frmKQHoSoPV(int id)
        {
            InitializeComponent();
            LoadData1(id);
            Init();
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
            _hoSo = NhanVienBUS.Instance.GetOneData(_pv.NhanVienID ?? default(int));
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
        private void LoadData1(int id)
        {
            _id = id;
            _pv = HoSoPVBUS.Instance.GetOneData(id);
            if (_pv.KetQuaPV == null)
            {
                bsiSTT.Caption = "Chưa phỏng vấn";
            }
            else if (_pv.KetQuaPV == 1)
            {
                bsiSTT.Caption = "Được nhận";
            }
            else if (_pv.KetQuaPV == 2)
            {
                bsiSTT.Caption = "Bị từ chối";
            }
        }
        private void LoadData()
        {
            if (_pv.KetQuaPV == null)
            {
                bsiSTT.Caption = "Chưa phỏng vấn";
            }
            else if (_pv.KetQuaPV == 1)
            {
                bsiSTT.Caption = "Được nhận";
            }
            else if (_pv.KetQuaPV == 2)
            {
                bsiSTT.Caption = "Bị từ chối";
            }
        }
        private void SaveData()
        {
            if (_pv.KetQuaPV == 1)
            {
                _hoSo.TrangThai = 3;
                tbl_ThuViec _tv = new tbl_ThuViec();
                _tv = ThuViecBUS.Instance.GetOneDataByNVID(_hoSo.NhanVienID);
                if (_tv == null)
                {
                    _tv = new tbl_ThuViec();
                    _tv.NhanVienID = _hoSo.NhanVienID;
                    ThuViecBUS.Instance.AddData(_tv);
                }
            }
            else if(_pv.KetQuaPV == 2)
            {
                _hoSo.TrangThai = -1;

            }
            NhanVienBUS.Instance.UpdateData(_hoSo);
            HoSoPVBUS.Instance.UpdateData(_pv);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData1(_pv.HoSoPVID);
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

        private void bbiAccept_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc chắn nhận tuyển sinh?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _pv.KetQuaPV = 1;
                LoadData();
            }
        }

        private void bbiDeny_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn loại tuyển sinh?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _pv.KetQuaPV = 2;
                LoadData();
            }
        }

        private void frmKQHoSoPV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc chán muốn thoát không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
