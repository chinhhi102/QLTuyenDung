namespace QLTuyenDungApp.BaoCao
{
    partial class frmBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiViTri = new DevExpress.XtraBars.BarButtonItem();
            this.bbiPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCM = new DevExpress.XtraBars.BarButtonItem();
            this.bbKhaNang = new DevExpress.XtraBars.BarButtonItem();
            this.bbiHoSo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tbl_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanToc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTDHVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuongYeuCau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenMonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoSoPVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_NhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tbl_NhanVienBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 146);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(790, 453);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNhanVienID,
            this.colHoTen,
            this.colNgaySinh,
            this.colQueQuan,
            this.colGioiTinh,
            this.colDanToc,
            this.colSDT,
            this.colEmail,
            this.colPhongBanID,
            this.colChucVuID,
            this.colTDHVID,
            this.colLuongYeuCau,
            this.colTrangThai,
            this.colChuyenMonID,
            this.colHoSoPVID,
            this.colMota});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiRefresh,
            this.bbiViTri,
            this.bbiPhongBan,
            this.bbiCM,
            this.bbKhaNang,
            this.bbiHoSo});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 25;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 146);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiViTri
            // 
            this.bbiViTri.Caption = "Báo cáo theo vị trí";
            this.bbiViTri.Id = 20;
            this.bbiViTri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiViTri.ImageOptions.Image")));
            this.bbiViTri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiViTri.ImageOptions.LargeImage")));
            this.bbiViTri.Name = "bbiViTri";
            this.bbiViTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiViTri_ItemClick);
            // 
            // bbiPhongBan
            // 
            this.bbiPhongBan.Caption = "Báo cáo theo phòng ban";
            this.bbiPhongBan.Id = 21;
            this.bbiPhongBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiPhongBan.ImageOptions.Image")));
            this.bbiPhongBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiPhongBan.ImageOptions.LargeImage")));
            this.bbiPhongBan.Name = "bbiPhongBan";
            this.bbiPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPhongBan_ItemClick);
            // 
            // bbiCM
            // 
            this.bbiCM.Caption = "Báo cáo theo chuyên môn";
            this.bbiCM.Id = 22;
            this.bbiCM.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCM.ImageOptions.Image")));
            this.bbiCM.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCM.ImageOptions.LargeImage")));
            this.bbiCM.Name = "bbiCM";
            this.bbiCM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCM_ItemClick);
            // 
            // bbKhaNang
            // 
            this.bbKhaNang.Caption = "Báo cáo theo khả năng làm việc";
            this.bbKhaNang.Id = 23;
            this.bbKhaNang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbKhaNang.ImageOptions.Image")));
            this.bbKhaNang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbKhaNang.ImageOptions.LargeImage")));
            this.bbKhaNang.Name = "bbKhaNang";
            this.bbKhaNang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbKhaNang_ItemClick);
            // 
            // bbiHoSo
            // 
            this.bbiHoSo.Caption = "Báo cáo theo hồ sơ nhận";
            this.bbiHoSo.Id = 24;
            this.bbiHoSo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiHoSo.ImageOptions.Image")));
            this.bbiHoSo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiHoSo.ImageOptions.LargeImage")));
            this.bbiHoSo.Name = "bbiHoSo";
            this.bbiHoSo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiHoSo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiViTri);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiPhongBan);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiCM);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbKhaNang);
            this.ribbonPageGroup3.ItemLinks.Add(this.bbiHoSo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Categories";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 21);
            // 
            // tbl_NhanVienBindingSource
            // 
            this.tbl_NhanVienBindingSource.DataSource = typeof(DataLibrary.DTO.tbl_NhanVien);
            // 
            // colNhanVienID
            // 
            this.colNhanVienID.FieldName = "NhanVienID";
            this.colNhanVienID.Name = "colNhanVienID";
            this.colNhanVienID.Visible = true;
            this.colNhanVienID.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colQueQuan
            // 
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 3;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            // 
            // colDanToc
            // 
            this.colDanToc.FieldName = "DanToc";
            this.colDanToc.Name = "colDanToc";
            this.colDanToc.Visible = true;
            this.colDanToc.VisibleIndex = 5;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // colPhongBanID
            // 
            this.colPhongBanID.FieldName = "PhongBanID";
            this.colPhongBanID.Name = "colPhongBanID";
            this.colPhongBanID.Visible = true;
            this.colPhongBanID.VisibleIndex = 8;
            // 
            // colChucVuID
            // 
            this.colChucVuID.FieldName = "ChucVuID";
            this.colChucVuID.Name = "colChucVuID";
            this.colChucVuID.Visible = true;
            this.colChucVuID.VisibleIndex = 9;
            // 
            // colTDHVID
            // 
            this.colTDHVID.FieldName = "TDHVID";
            this.colTDHVID.Name = "colTDHVID";
            this.colTDHVID.Visible = true;
            this.colTDHVID.VisibleIndex = 10;
            // 
            // colLuongYeuCau
            // 
            this.colLuongYeuCau.FieldName = "LuongYeuCau";
            this.colLuongYeuCau.Name = "colLuongYeuCau";
            this.colLuongYeuCau.Visible = true;
            this.colLuongYeuCau.VisibleIndex = 11;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 12;
            // 
            // colChuyenMonID
            // 
            this.colChuyenMonID.FieldName = "ChuyenMonID";
            this.colChuyenMonID.Name = "colChuyenMonID";
            this.colChuyenMonID.Visible = true;
            this.colChuyenMonID.VisibleIndex = 13;
            // 
            // colHoSoPVID
            // 
            this.colHoSoPVID.FieldName = "HoSoPVID";
            this.colHoSoPVID.Name = "colHoSoPVID";
            this.colHoSoPVID.Visible = true;
            this.colHoSoPVID.VisibleIndex = 14;
            // 
            // colMota
            // 
            this.colMota.FieldName = "Mota";
            this.colMota.Name = "colMota";
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 15;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmBaoCao";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_NhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiViTri;
        private DevExpress.XtraBars.BarButtonItem bbiPhongBan;
        private DevExpress.XtraBars.BarButtonItem bbiCM;
        private DevExpress.XtraBars.BarButtonItem bbKhaNang;
        private DevExpress.XtraBars.BarButtonItem bbiHoSo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.BindingSource tbl_NhanVienBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDanToc;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBanID;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVuID;
        private DevExpress.XtraGrid.Columns.GridColumn colTDHVID;
        private DevExpress.XtraGrid.Columns.GridColumn colLuongYeuCau;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenMonID;
        private DevExpress.XtraGrid.Columns.GridColumn colHoSoPVID;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
    }
}