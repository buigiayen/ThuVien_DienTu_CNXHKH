
namespace ThuVien_DienTu_CNXHKH.from
{
    partial class frm_LyThuyet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LyThuyet));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnTaiLaiDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.grcNhomLyThuyet = new DevExpress.XtraGrid.GridControl();
            this.grvNhomLyThuyet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.grcDanhSachLyThuyet = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSachLyThuyet = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachLyThuyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachLyThuyet)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("130b09d8-9e08-4f81-aee9-284918a942fe");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(337, 200);
            this.dockPanel1.Size = new System.Drawing.Size(337, 592);
            this.dockPanel1.Text = "Tùy chọn";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(330, 563);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnTaiLaiDanhSach);
            this.layoutControl1.Controls.Add(this.grcNhomLyThuyet);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(330, 563);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnTaiLaiDanhSach
            // 
            this.btnTaiLaiDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiLaiDanhSach.ImageOptions.Image")));
            this.btnTaiLaiDanhSach.Location = new System.Drawing.Point(2, 2);
            this.btnTaiLaiDanhSach.Name = "btnTaiLaiDanhSach";
            this.btnTaiLaiDanhSach.Size = new System.Drawing.Size(326, 36);
            this.btnTaiLaiDanhSach.StyleController = this.layoutControl1;
            this.btnTaiLaiDanhSach.TabIndex = 4;
            this.btnTaiLaiDanhSach.Text = "Tải lại danh sách";
            this.btnTaiLaiDanhSach.Click += new System.EventHandler(this.btnTaiLaiDanhSach_Click);
            // 
            // grcNhomLyThuyet
            // 
            this.grcNhomLyThuyet.Location = new System.Drawing.Point(2, 42);
            this.grcNhomLyThuyet.MainView = this.grvNhomLyThuyet;
            this.grcNhomLyThuyet.Name = "grcNhomLyThuyet";
            this.grcNhomLyThuyet.Size = new System.Drawing.Size(326, 519);
            this.grcNhomLyThuyet.TabIndex = 0;
            this.grcNhomLyThuyet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvNhomLyThuyet});
            // 
            // grvNhomLyThuyet
            // 
            this.grvNhomLyThuyet.GridControl = this.grcNhomLyThuyet;
            this.grvNhomLyThuyet.Name = "grvNhomLyThuyet";
            this.grvNhomLyThuyet.OptionsBehavior.ReadOnly = true;
            this.grvNhomLyThuyet.OptionsView.ShowGroupPanel = false;
            this.grvNhomLyThuyet.OptionsView.ShowViewCaption = true;
            this.grvNhomLyThuyet.ViewCaption = "Danh sách lý thuyết";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(330, 563);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcNhomLyThuyet;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(330, 523);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnTaiLaiDanhSach;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(330, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // grcDanhSachLyThuyet
            // 
            this.grcDanhSachLyThuyet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDanhSachLyThuyet.Location = new System.Drawing.Point(337, 0);
            this.grcDanhSachLyThuyet.MainView = this.grvDanhSachLyThuyet;
            this.grcDanhSachLyThuyet.Name = "grcDanhSachLyThuyet";
            this.grcDanhSachLyThuyet.Size = new System.Drawing.Size(820, 592);
            this.grcDanhSachLyThuyet.TabIndex = 1;
            this.grcDanhSachLyThuyet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSachLyThuyet});
            // 
            // grvDanhSachLyThuyet
            // 
            this.grvDanhSachLyThuyet.GridControl = this.grcDanhSachLyThuyet;
            this.grvDanhSachLyThuyet.Name = "grvDanhSachLyThuyet";
            this.grvDanhSachLyThuyet.OptionsBehavior.ReadOnly = true;
            this.grvDanhSachLyThuyet.OptionsView.ShowGroupPanel = false;
            this.grvDanhSachLyThuyet.OptionsView.ShowViewCaption = true;
            this.grvDanhSachLyThuyet.ViewCaption = "Danh sách bài viết";
            // 
            // frm_LyThuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 592);
            this.Controls.Add(this.grcDanhSachLyThuyet);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frm_LyThuyet";
            this.Text = "Lý thuyết";
            this.Load += new System.EventHandler(this.frm_LyThuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvNhomLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachLyThuyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachLyThuyet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl grcDanhSachLyThuyet;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSachLyThuyet;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnTaiLaiDanhSach;
        private DevExpress.XtraGrid.GridControl grcNhomLyThuyet;
        private DevExpress.XtraGrid.Views.Grid.GridView grvNhomLyThuyet;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}