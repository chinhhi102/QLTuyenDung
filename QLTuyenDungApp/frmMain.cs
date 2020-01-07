using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTuyenDungApp.ThongBao;
using QLTuyenDungApp.ThuNhanVaChonLoc;
using QLTuyenDungApp.XuLyHoSo;
using QLTuyenDungApp.CapNhapTinhHinh;
using QLTuyenDungApp.BaoCao;
using DevExpress.XtraEditors;

namespace QLTuyenDungApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void bntDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void ThongBaobnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongBao frm = new frmThongBao();
            frm.MdiParent = this;
            frm.Show();
        }
        private void ChonLocbnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHoSo frm = new frmHoSo();
            frm.MdiParent = this;
            frm.Show();
        }
        private void Xulybnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhapKQPV frm = new frmCapNhapKQPV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void CapNhapbnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTinhHinh frm = new frmTinhHinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BaoCaobnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
