namespace QLTuyenDungApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ThongBaobnt = new DevExpress.XtraBars.BarButtonItem();
            this.ChonLocbnt = new DevExpress.XtraBars.BarButtonItem();
            this.CapNhapbnt = new DevExpress.XtraBars.BarButtonItem();
            this.Xulybnt = new DevExpress.XtraBars.BarButtonItem();
            this.BaoCaobnt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bntDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.ThongBaobnt,
            this.ChonLocbnt,
            this.CapNhapbnt,
            this.Xulybnt,
            this.BaoCaobnt,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem1,
            this.bntDangXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(955, 165);
            // 
            // ThongBaobnt
            // 
            this.ThongBaobnt.Caption = "In thông báo";
            this.ThongBaobnt.Id = 1;
            this.ThongBaobnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ThongBaobnt.ImageOptions.Image")));
            this.ThongBaobnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ThongBaobnt.ImageOptions.LargeImage")));
            this.ThongBaobnt.LargeWidth = 100;
            this.ThongBaobnt.Name = "ThongBaobnt";
            this.ThongBaobnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ThongBaobnt_ItemClick);
            // 
            // ChonLocbnt
            // 
            this.ChonLocbnt.Caption = "Thu nhận và chọn lọc hồ sơ";
            this.ChonLocbnt.Id = 7;
            this.ChonLocbnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ChonLocbnt.ImageOptions.Image")));
            this.ChonLocbnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ChonLocbnt.ImageOptions.LargeImage")));
            this.ChonLocbnt.LargeWidth = 100;
            this.ChonLocbnt.Name = "ChonLocbnt";
            this.ChonLocbnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChonLocbnt_ItemClick);
            // 
            // CapNhapbnt
            // 
            this.CapNhapbnt.Caption = "Cập nhập tình hình thử việc";
            this.CapNhapbnt.Id = 8;
            this.CapNhapbnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CapNhapbnt.ImageOptions.Image")));
            this.CapNhapbnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CapNhapbnt.ImageOptions.LargeImage")));
            this.CapNhapbnt.LargeWidth = 100;
            this.CapNhapbnt.Name = "CapNhapbnt";
            this.CapNhapbnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CapNhapbnt_ItemClick);
            // 
            // Xulybnt
            // 
            this.Xulybnt.Caption = "Xử lý hồ sơ phỏng vấn";
            this.Xulybnt.Id = 9;
            this.Xulybnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Xulybnt.ImageOptions.Image")));
            this.Xulybnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Xulybnt.ImageOptions.LargeImage")));
            this.Xulybnt.LargeWidth = 100;
            this.Xulybnt.Name = "Xulybnt";
            this.Xulybnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Xulybnt_ItemClick);
            // 
            // BaoCaobnt
            // 
            this.BaoCaobnt.Caption = "Báo cáo";
            this.BaoCaobnt.Id = 10;
            this.BaoCaobnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BaoCaobnt.ImageOptions.Image")));
            this.BaoCaobnt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BaoCaobnt.ImageOptions.LargeImage")));
            this.BaoCaobnt.LargeWidth = 100;
            this.BaoCaobnt.Name = "BaoCaobnt";
            this.BaoCaobnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BaoCaobnt_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "Đăng xuất";
            this.barButtonItem1.DropDownControl = this.galleryDropDown1;
            this.barButtonItem1.Id = 11;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            toolTipTitleItem1.Text = "User";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.barButtonItem1.SuperTip = superToolTip1;
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonControl1;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "User";
            this.barSubItem1.Id = 13;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bntDangXuat)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bntDangXuat
            // 
            this.bntDangXuat.Caption = "Đăng xuất";
            this.bntDangXuat.Id = 14;
            this.bntDangXuat.Name = "bntDangXuat";
            this.bntDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntDangXuat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.ThongBaobnt);
            this.ribbonPageGroup1.ItemLinks.Add(this.ChonLocbnt);
            this.ribbonPageGroup1.ItemLinks.Add(this.Xulybnt);
            this.ribbonPageGroup1.ItemLinks.Add(this.CapNhapbnt);
            this.ribbonPageGroup1.ItemLinks.Add(this.BaoCaobnt);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 507);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ TUYỂN DỤNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem ThongBaobnt;
        private DevExpress.XtraBars.BarButtonItem ChonLocbnt;
        private DevExpress.XtraBars.BarButtonItem CapNhapbnt;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem Xulybnt;
        private DevExpress.XtraBars.BarButtonItem BaoCaobnt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bntDangXuat;
    }
}

