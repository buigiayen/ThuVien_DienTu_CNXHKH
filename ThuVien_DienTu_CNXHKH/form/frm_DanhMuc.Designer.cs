
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class frm_DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMuc));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grcBaiViet = new DevExpress.XtraGrid.GridControl();
            this.grvBaiViet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemMoiBaiViet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoiNhom = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.grcDanhMuc = new DevExpress.XtraGrid.GridControl();
            this.grvDanhMuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBaiViet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiViet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grcBaiViet);
            this.layoutControl1.Controls.Add(this.btnThemMoiBaiViet);
            this.layoutControl1.Controls.Add(this.btnThemMoiNhom);
            this.layoutControl1.Controls.Add(this.btnTaiDanhSach);
            this.layoutControl1.Controls.Add(this.grcDanhMuc);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 328, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1273, 582);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grcBaiViet
            // 
            this.grcBaiViet.Location = new System.Drawing.Point(529, 28);
            this.grcBaiViet.MainView = this.grvBaiViet;
            this.grcBaiViet.Name = "grcBaiViet";
            this.grcBaiViet.Size = new System.Drawing.Size(742, 552);
            this.grcBaiViet.TabIndex = 8;
            this.grcBaiViet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaiViet});
            // 
            // grvBaiViet
            // 
            this.grvBaiViet.GridControl = this.grcBaiViet;
            this.grvBaiViet.Name = "grvBaiViet";
            // 
            // btnThemMoiBaiViet
            // 
            this.btnThemMoiBaiViet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiBaiViet.ImageOptions.Image")));
            this.btnThemMoiBaiViet.Location = new System.Drawing.Point(529, 2);
            this.btnThemMoiBaiViet.Name = "btnThemMoiBaiViet";
            this.btnThemMoiBaiViet.Size = new System.Drawing.Size(113, 22);
            this.btnThemMoiBaiViet.StyleController = this.layoutControl1;
            this.btnThemMoiBaiViet.TabIndex = 7;
            this.btnThemMoiBaiViet.Text = "Thêm mới bài viết";
            this.btnThemMoiBaiViet.Click += new System.EventHandler(this.btnThemMoiBaiViet_Click);
            // 
            // btnThemMoiNhom
            // 
            this.btnThemMoiNhom.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiNhom.ImageOptions.Image")));
            this.btnThemMoiNhom.Location = new System.Drawing.Point(142, 2);
            this.btnThemMoiNhom.Name = "btnThemMoiNhom";
            this.btnThemMoiNhom.Size = new System.Drawing.Size(139, 22);
            this.btnThemMoiNhom.StyleController = this.layoutControl1;
            this.btnThemMoiNhom.TabIndex = 6;
            this.btnThemMoiNhom.Text = "Thêm mới nhóm";
            this.btnThemMoiNhom.Click += new System.EventHandler(this.btnThemMoiNhom_Click);
            // 
            // btnTaiDanhSach
            // 
            this.btnTaiDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiDanhSach.ImageOptions.Image")));
            this.btnTaiDanhSach.Location = new System.Drawing.Point(2, 2);
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            this.btnTaiDanhSach.Size = new System.Drawing.Size(136, 22);
            this.btnTaiDanhSach.StyleController = this.layoutControl1;
            this.btnTaiDanhSach.TabIndex = 5;
            this.btnTaiDanhSach.Text = "Tải danh sách";
            this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);
            // 
            // grcDanhMuc
            // 
            this.grcDanhMuc.Location = new System.Drawing.Point(2, 28);
            this.grcDanhMuc.MainView = this.grvDanhMuc;
            this.grcDanhMuc.Name = "grcDanhMuc";
            this.grcDanhMuc.Size = new System.Drawing.Size(523, 552);
            this.grcDanhMuc.TabIndex = 4;
            this.grcDanhMuc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhMuc});
            // 
            // grvDanhMuc
            // 
            this.grvDanhMuc.GridControl = this.grcDanhMuc;
            this.grvDanhMuc.Name = "grvDanhMuc";
            this.grvDanhMuc.OptionsView.ShowGroupPanel = false;
            this.grvDanhMuc.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvDanhMuc_CellValueChanging);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1273, 582);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcDanhMuc;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(527, 556);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnTaiDanhSach;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(140, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(644, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(629, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThemMoiNhom;
            this.layoutControlItem3.Location = new System.Drawing.Point(140, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(143, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThemMoiBaiViet;
            this.layoutControlItem4.Location = new System.Drawing.Point(527, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(117, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grcBaiViet;
            this.layoutControlItem5.Location = new System.Drawing.Point(527, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(746, 556);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(283, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(244, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 582);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_DanhMuc";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBaiViet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiViet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl grcDanhMuc;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhMuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnTaiDanhSach;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiNhom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiBaiViet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl grcBaiViet;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaiViet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}