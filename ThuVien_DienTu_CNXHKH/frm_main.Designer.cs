
namespace ThuVien_DienTu_CNXHKH
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucLyThuyet = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNhomSachKinhDien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachKinhDien = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLyThuyet = new DevExpress.XtraBars.BarButtonItem();
            this.btnTuSach = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTuSachKinhDien = new DevExpress.XtraBars.BarButtonItem();
            this.btnLienKetTrangWeb = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnEmailPhanHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPhanHoi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.ImageOptions.Image")));
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhMucLyThuyet);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách sinh viên";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDanhMucLyThuyet
            // 
            this.btnDanhMucLyThuyet.Caption = "Lý thuyết";
            this.btnDanhMucLyThuyet.Id = 5;
            this.btnDanhMucLyThuyet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhMucLyThuyet.ImageOptions.Image")));
            this.btnDanhMucLyThuyet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDanhMucLyThuyet.ImageOptions.LargeImage")));
            this.btnDanhMucLyThuyet.Name = "btnDanhMucLyThuyet";
            this.btnDanhMucLyThuyet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhMucLyThuyet_ItemClick);
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Hòm thư phản hồi";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhomSachKinhDien);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSachKinhDien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tủ sách kinh điển";
            // 
            // btnNhomSachKinhDien
            // 
            this.btnNhomSachKinhDien.Caption = "Nhóm sách kinh điển";
            this.btnNhomSachKinhDien.Id = 14;
            this.btnNhomSachKinhDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhomSachKinhDien.ImageOptions.Image")));
            this.btnNhomSachKinhDien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhomSachKinhDien.ImageOptions.LargeImage")));
            this.btnNhomSachKinhDien.Name = "btnNhomSachKinhDien";
            this.btnNhomSachKinhDien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhomSachKinhDien_ItemClick);
            // 
            // btnSachKinhDien
            // 
            this.btnSachKinhDien.Caption = "Sách kinh điển";
            this.btnSachKinhDien.Id = 15;
            this.btnSachKinhDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachKinhDien.ImageOptions.Image")));
            this.btnSachKinhDien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachKinhDien.ImageOptions.LargeImage")));
            this.btnSachKinhDien.Name = "btnSachKinhDien";
            this.btnSachKinhDien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachKinhDien_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLyThuyet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTuSach);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTuSachKinhDien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLienKetTrangWeb);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnLyThuyet
            // 
            this.btnLyThuyet.Caption = "Lý thuyết";
            this.btnLyThuyet.Id = 1;
            this.btnLyThuyet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLyThuyet.ImageOptions.Image")));
            this.btnLyThuyet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLyThuyet.ImageOptions.LargeImage")));
            this.btnLyThuyet.Name = "btnLyThuyet";
            this.btnLyThuyet.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLyThuyet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLyThuyet_ItemClick);
            // 
            // btnTuSach
            // 
            this.btnTuSach.Caption = "Tủ sách";
            this.btnTuSach.Id = 2;
            this.btnTuSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTuSach.ImageOptions.Image")));
            this.btnTuSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTuSach.ImageOptions.LargeImage")));
            this.btnTuSach.Name = "btnTuSach";
            this.btnTuSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTuSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTuSach_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tra cứu";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnTuSachKinhDien
            // 
            this.btnTuSachKinhDien.Caption = "Tủ sách kinh điển";
            this.btnTuSachKinhDien.Id = 13;
            this.btnTuSachKinhDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTuSachKinhDien.ImageOptions.Image")));
            this.btnTuSachKinhDien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTuSachKinhDien.ImageOptions.LargeImage")));
            this.btnTuSachKinhDien.Name = "btnTuSachKinhDien";
            this.btnTuSachKinhDien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTuSachKinhDien_ItemClick);
            // 
            // btnLienKetTrangWeb
            // 
            this.btnLienKetTrangWeb.Caption = "Liên kết trang web";
            this.btnLienKetTrangWeb.Id = 7;
            this.btnLienKetTrangWeb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLienKetTrangWeb.ImageOptions.Image")));
            this.btnLienKetTrangWeb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLienKetTrangWeb.ImageOptions.LargeImage")));
            this.btnLienKetTrangWeb.Name = "btnLienKetTrangWeb";
            this.btnLienKetTrangWeb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLienKetTrangWeb_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEmailPhanHoi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btnEmailPhanHoi
            // 
            this.btnEmailPhanHoi.Caption = "Phản hồi";
            this.btnEmailPhanHoi.Id = 12;
            this.btnEmailPhanHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmailPhanHoi.ImageOptions.Image")));
            this.btnEmailPhanHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmailPhanHoi.ImageOptions.LargeImage")));
            this.btnEmailPhanHoi.Name = "btnEmailPhanHoi";
            this.btnEmailPhanHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmailPhanHoi_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnPhanHoi,
            this.btnLyThuyet,
            this.btnTuSach,
            this.barButtonItem3,
            this.barButtonItem1,
            this.btnDanhMucLyThuyet,
            this.barButtonItem5,
            this.btnLienKetTrangWeb,
            this.barButtonItem2,
            this.barButtonItem4,
            this.barButtonItem6,
            this.btnEmailPhanHoi,
            this.btnTuSachKinhDien,
            this.btnNhomSachKinhDien,
            this.btnSachKinhDien});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1020, 158);
            // 
            // btnPhanHoi
            // 
            this.btnPhanHoi.Caption = "Phản hồi";
            this.btnPhanHoi.Description = "Phản hồi";
            this.btnPhanHoi.Id = 11;
            this.btnPhanHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanHoi.ImageOptions.Image")));
            this.btnPhanHoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhanHoi.ImageOptions.LargeImage")));
            this.btnPhanHoi.Name = "btnPhanHoi";
            this.btnPhanHoi.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 10;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 625);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frm_main";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư viện điện tử";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_main_FormClosed);
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnPhanHoi;
        private DevExpress.XtraBars.BarButtonItem btnLyThuyet;
        private DevExpress.XtraBars.BarButtonItem btnTuSach;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucLyThuyet;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnLienKetTrangWeb;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnEmailPhanHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnTuSachKinhDien;
        private DevExpress.XtraBars.BarButtonItem btnNhomSachKinhDien;
        private DevExpress.XtraBars.BarButtonItem btnSachKinhDien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

