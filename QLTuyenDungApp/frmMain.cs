using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLTuyenDungApp.ThongBao;

namespace QLTuyenDungApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ThongBaobnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongBao frm = new frmThongBao();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bntDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
