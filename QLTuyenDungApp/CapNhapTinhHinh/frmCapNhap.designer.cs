namespace QLTuyenDungApp.CapNhapTinhHinh
{
    partial class frmCapNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhap));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tbl_TinhHinhThuViecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTinhHinhThuViecID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhaNangLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThaiDoLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKinhNghiemLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHieuQuaLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.txtTen = new DevExpress.XtraBars.BarStaticItem();
            this.bbiGT = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TinhHinhThuViecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tbl_TinhHinhThuViecBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 146);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(938, 440);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // tbl_TinhHinhThuViecBindingSource
            // 
            this.tbl_TinhHinhThuViecBindingSource.DataSource = typeof(DataLibrary.DTO.tbl_TinhHinhThuViec);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTinhHinhThuViecID,
            this.colKhaNangLamViec,
            this.colThaiDoLamViec,
            this.colKinhNghiemLamViec,
            this.colHieuQuaLamViec,
            this.colNgayCapNhap});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colTinhHinhThuViecID
            // 
            this.colTinhHinhThuViecID.Caption = "Mã tình hình thử việc";
            this.colTinhHinhThuViecID.FieldName = "TinhHinhThuViecID";
            this.colTinhHinhThuViecID.Name = "colTinhHinhThuViecID";
            this.colTinhHinhThuViecID.Visible = true;
            this.colTinhHinhThuViecID.VisibleIndex = 0;
            // 
            // colKhaNangLamViec
            // 
            this.colKhaNangLamViec.Caption = "Khả năng làm việc";
            this.colKhaNangLamViec.FieldName = "KhaNangLamViec";
            this.colKhaNangLamViec.Name = "colKhaNangLamViec";
            this.colKhaNangLamViec.Visible = true;
            this.colKhaNangLamViec.VisibleIndex = 1;
            // 
            // colThaiDoLamViec
            // 
            this.colThaiDoLamViec.Caption = "Thái độ làm việc";
            this.colThaiDoLamViec.FieldName = "ThaiDoLamViec";
            this.colThaiDoLamViec.Name = "colThaiDoLamViec";
            this.colThaiDoLamViec.Visible = true;
            this.colThaiDoLamViec.VisibleIndex = 2;
            // 
            // colKinhNghiemLamViec
            // 
            this.colKinhNghiemLamViec.Caption = "Kinh nghiệm làm việc";
            this.colKinhNghiemLamViec.FieldName = "KinhNghiemLamViec";
            this.colKinhNghiemLamViec.Name = "colKinhNghiemLamViec";
            this.colKinhNghiemLamViec.Visible = true;
            this.colKinhNghiemLamViec.VisibleIndex = 3;
            // 
            // colHieuQuaLamViec
            // 
            this.colHieuQuaLamViec.Caption = "Hiệu quả làm việc";
            this.colHieuQuaLamViec.FieldName = "HieuQuaLamViec";
            this.colHieuQuaLamViec.Name = "colHieuQuaLamViec";
            this.colHieuQuaLamViec.Visible = true;
            this.colHieuQuaLamViec.VisibleIndex = 4;
            // 
            // colNgayCapNhap
            // 
            this.colNgayCapNhap.Caption = "Ngày cập nhập";
            this.colNgayCapNhap.FieldName = "NgayCapNhap";
            this.colNgayCapNhap.Name = "colNgayCapNhap";
            this.colNgayCapNhap.Visible = true;
            this.colNgayCapNhap.VisibleIndex = 5;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.txtTen,
            this.bbiGT});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 25;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(938, 146);
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
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // txtTen
            // 
            this.txtTen.Caption = "Hello";
            this.txtTen.Id = 20;
            this.txtTen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtTen.ImageOptions.Image")));
            this.txtTen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("txtTen.ImageOptions.LargeImage")));
            this.txtTen.Name = "txtTen";
            this.txtTen.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.txtTen.Width = 150;
            // 
            // bbiGT
            // 
            this.bbiGT.Caption = "a";
            this.bbiGT.Id = 24;
            this.bbiGT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiGT.ImageOptions.Image")));
            this.bbiGT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiGT.ImageOptions.LargeImage")));
            this.bbiGT.Name = "bbiGT";
            this.bbiGT.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.txtTen);
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiGT);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Thông tin nhân viên";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 565);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(938, 21);
            // 
            // frmCapNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 586);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapNhap";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cập nhập hồ sơ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TinhHinhThuViecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhHinhThuViecID;
        private DevExpress.XtraGrid.Columns.GridColumn colKhaNangLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn colThaiDoLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn colKinhNghiemLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn colHieuQuaLamViec;
        private System.Windows.Forms.BindingSource tbl_TinhHinhThuViecBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhap;
        private DevExpress.XtraBars.BarStaticItem txtTen;
        private DevExpress.XtraBars.BarStaticItem bbiGT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}