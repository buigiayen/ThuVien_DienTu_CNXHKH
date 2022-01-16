
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class Frm_NhomSachKinhDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhomSachKinhDien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEditGroupBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.grcSachKinhDien = new DevExpress.XtraGrid.GridControl();
            this.grvSachKinhDien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnTaiDanhSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.grcNhomSachKinhDien = new DevExpress.XtraGrid.GridControl();
            this.grvNhomSachKinhDien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcSachKinhDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSachKinhDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomSachKinhDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomSachKinhDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditGroupBook);
            this.layoutControl1.Controls.Add(this.btnReload);
            this.layoutControl1.Controls.Add(this.grcSachKinhDien);
            this.layoutControl1.Controls.Add(this.grcNhomSachKinhDien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 306, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1006, 566);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEditGroupBook
            // 
            this.btnEditGroupBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditGroupBook.ImageOptions.Image")));
            this.btnEditGroupBook.Location = new System.Drawing.Point(121, 2);
            this.btnEditGroupBook.Name = "btnEditGroupBook";
            this.btnEditGroupBook.Size = new System.Drawing.Size(148, 22);
            this.btnEditGroupBook.StyleController = this.layoutControl1;
            this.btnEditGroupBook.TabIndex = 8;
            this.btnEditGroupBook.Text = "Sửa";
            this.btnEditGroupBook.Click += new System.EventHandler(this.btnEditGroupBook_Click);
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(2, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(115, 22);
            this.btnReload.StyleController = this.layoutControl1;
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Tải danh sách";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // grcSachKinhDien
            // 
            this.grcSachKinhDien.Location = new System.Drawing.Point(273, 28);
            this.grcSachKinhDien.MainView = this.grvSachKinhDien;
            this.grcSachKinhDien.MenuManager = this.barManager1;
            this.grcSachKinhDien.Name = "grcSachKinhDien";
            this.grcSachKinhDien.Size = new System.Drawing.Size(731, 536);
            this.grcSachKinhDien.TabIndex = 5;
            this.grcSachKinhDien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvSachKinhDien});
            // 
            // grvSachKinhDien
            // 
            this.grvSachKinhDien.GridControl = this.grcSachKinhDien;
            this.grvSachKinhDien.Name = "grvSachKinhDien";
            this.grvSachKinhDien.OptionsView.ShowGroupPanel = false;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTaiDanhSach,
            this.btnThemMoi,
            this.btnSua,
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1006, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 566);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1006, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 566);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1006, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 566);
            // 
            // btnTaiDanhSach
            // 
            this.btnTaiDanhSach.Caption = "Tải danh sách";
            this.btnTaiDanhSach.Id = 0;
            this.btnTaiDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiDanhSach.ImageOptions.Image")));
            this.btnTaiDanhSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaiDanhSach.ImageOptions.LargeImage")));
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Caption = "Thêm mới";
            this.btnThemMoi.Id = 1;
            this.btnThemMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.ImageOptions.Image")));
            this.btnThemMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.ImageOptions.LargeImage")));
            this.btnThemMoi.Name = "btnThemMoi";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "ll";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // grcNhomSachKinhDien
            // 
            this.grcNhomSachKinhDien.Location = new System.Drawing.Point(2, 28);
            this.grcNhomSachKinhDien.MainView = this.grvNhomSachKinhDien;
            this.grcNhomSachKinhDien.MenuManager = this.barManager1;
            this.grcNhomSachKinhDien.Name = "grcNhomSachKinhDien";
            this.grcNhomSachKinhDien.Size = new System.Drawing.Size(267, 536);
            this.grcNhomSachKinhDien.TabIndex = 4;
            this.grcNhomSachKinhDien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhomSachKinhDien});
            // 
            // grvNhomSachKinhDien
            // 
            this.grvNhomSachKinhDien.GridControl = this.grcNhomSachKinhDien;
            this.grvNhomSachKinhDien.Name = "grvNhomSachKinhDien";
            this.grvNhomSachKinhDien.OptionsView.ShowGroupPanel = false;
            this.grvNhomSachKinhDien.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvList_CellValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1006, 566);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcNhomSachKinhDien;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(271, 540);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grcSachKinhDien;
            this.layoutControlItem2.Location = new System.Drawing.Point(271, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(735, 540);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnReload;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(119, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEditGroupBook;
            this.layoutControlItem5.Location = new System.Drawing.Point(119, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(152, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(271, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(735, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Frm_NhomSachKinhDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 566);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_NhomSachKinhDien";
            this.Text = "Nhóm sách kinh điển";
            this.Load += new System.EventHandler(this.Frm_NhomSachKinhDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcSachKinhDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSachKinhDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomSachKinhDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomSachKinhDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grcNhomSachKinhDien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhomSachKinhDien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnTaiDanhSach;
        private DevExpress.XtraBars.BarButtonItem btnThemMoi;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl grcSachKinhDien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvSachKinhDien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.SimpleButton btnEditGroupBook;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}