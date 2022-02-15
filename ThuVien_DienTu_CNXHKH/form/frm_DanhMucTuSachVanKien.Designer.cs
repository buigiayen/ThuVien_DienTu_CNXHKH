
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class frm_DanhMucTuSachVanKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DanhMucTuSachVanKien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grcBaiViet = new DevExpress.XtraGrid.GridControl();
            this.grvBaiViet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemMoiBaiViet = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnTaiDanhSach = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBaiViet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiViet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grcBaiViet);
            this.layoutControl1.Controls.Add(this.btnThemMoiBaiViet);
            this.layoutControl1.Controls.Add(this.btnTaiDanhSach);
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
            this.grcBaiViet.Location = new System.Drawing.Point(2, 28);
            this.grcBaiViet.MainView = this.grvBaiViet;
            this.grcBaiViet.Name = "grcBaiViet";
            this.grcBaiViet.Size = new System.Drawing.Size(1269, 552);
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
            this.btnThemMoiBaiViet.Location = new System.Drawing.Point(142, 2);
            this.btnThemMoiBaiViet.Name = "btnThemMoiBaiViet";
            this.btnThemMoiBaiViet.Size = new System.Drawing.Size(152, 22);
            this.btnThemMoiBaiViet.StyleController = this.layoutControl1;
            this.btnThemMoiBaiViet.TabIndex = 7;
            this.btnThemMoiBaiViet.Text = "Thêm mới bài viết";
            this.btnThemMoiBaiViet.Click += new System.EventHandler(this.btnThemMoiBaiViet_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1273, 582);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(296, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(977, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThemMoiBaiViet;
            this.layoutControlItem4.Location = new System.Drawing.Point(140, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(156, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.grcBaiViet;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1273, 556);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
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
            // frm_DanhMucTuSachVanKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 582);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_DanhMucTuSachVanKien";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBaiViet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiViet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiBaiViet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl grcBaiViet;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaiViet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnTaiDanhSach;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}