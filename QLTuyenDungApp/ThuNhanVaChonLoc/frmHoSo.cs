﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using DataLibrary.DTO;
using DataLibrary.BUS;
using QLTuyenDungApp.ThuNhanVaChonLoc;
using System.Data.Entity;

namespace QLTuyenDungApp.ThuNhanVaChonLoc
{
    public partial class frmHoSo : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<tbl_NhanVien> list = new List<tbl_NhanVien>();
        TuyenDungModels db = new TuyenDungModels();
        public frmHoSo()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            DataLibrary.DTO.TuyenDungModels dbContext = new DataLibrary.DTO.TuyenDungModels();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.tbl_NhanVien.Load();
            // This line of code is generated by Data Source Configuration Wizard
            tbl_NhanVienBindingSource.DataSource = dbContext.tbl_NhanVien.Local.ToBindingList();
        }
        private void LoadData()
        {
            this.list = NhanVienBUS.Instance.GetAllData();
            var bindingList = new BindingList<tbl_NhanVien>(list);
            var source = new BindingSource(bindingList, null);
            tbl_NhanVienBindingSource.DataSource = source;
        }
        private void frmHoSo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            frmHoSoDetail frm = new frmHoSoDetail();
            frm.ShowDialog();
            LoadData();
        }
        private void bntChiTiet_Click(object sender, EventArgs e)
        {
            frmHoSoDetail frm = new frmHoSoDetail(list[gridView1.GetSelectedRows()[0]].NhanVienID);
            frm.ShowDialog();
            LoadData();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmHoSoDetail frm = new frmHoSoDetail(list[gridView1.GetSelectedRows()[0]].NhanVienID);
            frm.ShowDialog();
            LoadData();
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                NhanVienBUS.Instance.DeleteData(list[gridView1.GetSelectedRows()[0]].NhanVienID);
            LoadData();
        }
    }
}