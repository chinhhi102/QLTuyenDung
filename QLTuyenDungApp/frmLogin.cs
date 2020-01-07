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

namespace QLTuyenDungApp
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private List<tbl_TaiKhoan> list = new List<tbl_TaiKhoan>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            foreach(tbl_TaiKhoan tk in list)
            {
                if(tk.TenTaiKhoan == txtuser.Text && tk.MatKhau == txtMK.Text)
                {
                    XtraMessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    return;
                }
            }
            XtraMessageBox.Show("Sai tên đăng nhập hoặc tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            list = TaiKhoanBUS.Instance.GetAllData();
        }
    }
}