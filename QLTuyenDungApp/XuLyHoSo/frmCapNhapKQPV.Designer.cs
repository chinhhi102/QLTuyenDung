namespace QLTuyenDungApp.XuLyHoSo
{
    partial class frmCapNhapKQPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapNhapKQPV));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.tbl_HoSoPVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHoSoPVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayPV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQuaPV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSetDate = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResult = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_HoSoPVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.tbl_HoSoPVBindingSource;
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
            // tbl_HoSoPVBindingSource
            // 
            this.tbl_HoSoPVBindingSource.DataSource = typeof(DataLibrary.DTO.tbl_HoSoPV);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHoSoPVID,
            this.colNgayPV,
            this.colKetQuaPV,
            this.colNhanVienID});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colHoSoPVID
            // 
            this.colHoSoPVID.Caption = "Mã hồ sơ phỏng vấn";
            this.colHoSoPVID.FieldName = "HoSoPVID";
            this.colHoSoPVID.Name = "colHoSoPVID";
            this.colHoSoPVID.Visible = true;
            this.colHoSoPVID.VisibleIndex = 0;
            // 
            // colNgayPV
            // 
            this.colNgayPV.Caption = "Ngày phỏng vấn";
            this.colNgayPV.FieldName = "NgayPV";
            this.colNgayPV.Name = "colNgayPV";
            this.colNgayPV.Visible = true;
            this.colNgayPV.VisibleIndex = 1;
            // 
            // colKetQuaPV
            // 
            this.colKetQuaPV.Caption = "Kết quả phỏng vấn";
            this.colKetQuaPV.FieldName = "KetQuaPV";
            this.colKetQuaPV.Name = "colKetQuaPV";
            this.colKetQuaPV.Visible = true;
            this.colKetQuaPV.VisibleIndex = 2;
            // 
            // colNhanVienID
            // 
            this.colNhanVienID.Caption = "Mã tuyển sinh";
            this.colNhanVienID.FieldName = "NhanVienID";
            this.colNhanVienID.Name = "colNhanVienID";
            this.colNhanVienID.Visible = true;
            this.colNhanVienID.VisibleIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bsiRecordsCount,
            this.bbiRefresh,
            this.bbiSetDate,
            this.bbiResult});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 146);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
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
            // bbiSetDate
            // 
            this.bbiSetDate.Caption = "Set Date";
            this.bbiSetDate.Id = 20;
            this.bbiSetDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiSetDate.ImageOptions.Image")));
            this.bbiSetDate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiSetDate.ImageOptions.LargeImage")));
            this.bbiSetDate.Name = "bbiSetDate";
            this.bbiSetDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSetDate_ItemClick);
            // 
            // bbiResult
            // 
            this.bbiResult.Caption = "Result";
            this.bbiResult.Id = 21;
            this.bbiResult.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbiResult.ImageOptions.Image")));
            this.bbiResult.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbiResult.ImageOptions.LargeImage")));
            this.bbiResult.Name = "bbiResult";
            this.bbiResult.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiResult_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSetDate);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiResult);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 578);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 21);
            // 
            // frmCapNhapKQPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "frmCapNhapKQPV";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Xử lý hồ sơ phỏng vấn";
            this.Load += new System.EventHandler(this.frmCapNhapKQPV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_HoSoPVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.BindingSource tbl_HoSoPVBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoSoPVID;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayPV;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQuaPV;
        private DevExpress.XtraGrid.Columns.GridColumn colNhanVienID;
        private DevExpress.XtraBars.BarButtonItem bbiSetDate;
        private DevExpress.XtraBars.BarButtonItem bbiResult;
    }
}