namespace QLTuyenDungApp.CapNhapTinhHinh
{
    partial class frmTinhHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhHinh));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tbl_ThuViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colThuViecID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThuViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThucThuViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDatThoiGian = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCapNhap = new DevExpress.XtraBars.BarButtonItem();
            this.bbiChapNhan = new DevExpress.XtraBars.BarButtonItem();
            this.bbiKhongChapNhan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ThuViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tbl_ThuViecBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 146);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(790, 453);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tbl_ThuViecBindingSource
            // 
            this.tbl_ThuViecBindingSource.DataSource = typeof(DataLibrary.DTO.tbl_ThuViec);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colThuViecID,
            this.colNhanVienID,
            this.colNgayThuViec,
            this.colNgayKetThucThuViec});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colThuViecID
            // 
            this.colThuViecID.Caption = "Mã thử việc";
            this.colThuViecID.FieldName = "ThuViecID";
            this.colThuViecID.Name = "colThuViecID";
            this.colThuViecID.Visible = true;
            this.colThuViecID.VisibleIndex = 0;
            // 
            // colNhanVienID
            // 
            this.colNhanVienID.Caption = "Mã nhân viên";
            this.colNhanVienID.FieldName = "NhanVienID";
            this.colNhanVienID.Name = "colNhanVienID";
            this.colNhanVienID.Visible = true;
            this.colNhanVienID.VisibleIndex = 1;
            // 
            // colNgayThuViec
            // 
            this.colNgayThuViec.Caption = "Ngày thử việc";
            this.colNgayThuViec.FieldName = "NgayThuViec";
            this.colNgayThuViec.Name = "colNgayThuViec";
            this.colNgayThuViec.Visible = true;
            this.colNgayThuViec.VisibleIndex = 2;
            // 
            // colNgayKetThucThuViec
            // 
            this.colNgayKetThucThuViec.Caption = "Ngày kết thúc thử việc";
            this.colNgayKetThucThuViec.FieldName = "NgayKetThucThuViec";
            this.colNgayKetThucThuViec.Name = "colNgayKetThucThuViec";
            this.colNgayKetThucThuViec.Visible = true;
            this.colNgayKetThucThuViec.VisibleIndex = 3;
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
            this.bbiDatThoiGian,
            this.bbiCapNhap,
            this.bbiChapNhan,
            this.bbiKhongChapNhan});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 24;
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
            // bbiDatThoiGian
            // 
            this.bbiDatThoiGian.Caption = "Đặt thời gian thử việc";
            this.bbiDatThoiGian.Id = 20;
            this.bbiDatThoiGian.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiDatThoiGian.ImageOptions.Image")));
            this.bbiDatThoiGian.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiDatThoiGian.ImageOptions.LargeImage")));
            this.bbiDatThoiGian.Name = "bbiDatThoiGian";
            this.bbiDatThoiGian.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDatThoiGian_ItemClick);
            // 
            // bbiCapNhap
            // 
            this.bbiCapNhap.Caption = "Cập nhập tình hình thử việc";
            this.bbiCapNhap.Id = 21;
            this.bbiCapNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiCapNhap.ImageOptions.Image")));
            this.bbiCapNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiCapNhap.ImageOptions.LargeImage")));
            this.bbiCapNhap.Name = "bbiCapNhap";
            this.bbiCapNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCapNhap_ItemClick);
            // 
            // bbiChapNhan
            // 
            this.bbiChapNhan.Caption = "Chấp nhận";
            this.bbiChapNhan.Id = 22;
            this.bbiChapNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiChapNhan.ImageOptions.Image")));
            this.bbiChapNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiChapNhan.ImageOptions.LargeImage")));
            this.bbiChapNhan.Name = "bbiChapNhan";
            this.bbiChapNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiChapNhan_ItemClick);
            // 
            // bbiKhongChapNhan
            // 
            this.bbiKhongChapNhan.Caption = "Không chấp nhận";
            this.bbiKhongChapNhan.Id = 23;
            this.bbiKhongChapNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiKhongChapNhan.ImageOptions.Image")));
            this.bbiKhongChapNhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiKhongChapNhan.ImageOptions.LargeImage")));
            this.bbiKhongChapNhan.Name = "bbiKhongChapNhan";
            this.bbiKhongChapNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiKhongChapNhan_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDatThoiGian);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCapNhap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiChapNhan);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiKhongChapNhan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Quyết định tuyển dụng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 21);
            // 
            // frmTinhHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmTinhHinh";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cập nhập tình hình thử việc";
            this.Load += new System.EventHandler(this.frmTinhHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ThuViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.BindingSource tbl_ThuViecBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colThuViecID;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThuViec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThucThuViec;
        private DevExpress.XtraBars.BarButtonItem bbiDatThoiGian;
        private DevExpress.XtraBars.BarButtonItem bbiCapNhap;
        private DevExpress.XtraBars.BarButtonItem bbiChapNhan;
        private DevExpress.XtraBars.BarButtonItem bbiKhongChapNhan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}