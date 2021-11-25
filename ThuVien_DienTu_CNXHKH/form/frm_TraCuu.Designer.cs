
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class frm_TraCuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TraCuu));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.grcTraCuuThuatNgu = new DevExpress.XtraGrid.GridControl();
            this.grvTraCuuThuatNgu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnReloadTraCuuThuatNgu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoiTraCuuThuatNgu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTraCuuThuatNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTraCuuThuatNgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1138, 777);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.layoutControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1136, 752);
            this.xtraTabPage1.Text = "Tra cứu thuật ngữ";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1136, 752);
            this.xtraTabPage2.Text = "Tra cứu kinh điển";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1138, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 777);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1138, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 777);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1138, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 777);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.stackPanel1);
            this.layoutControl1.Controls.Add(this.grcTraCuuThuatNgu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1136, 752);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.Root.Size = new System.Drawing.Size(1136, 752);
            this.Root.TextVisible = false;
            // 
            // grcTraCuuThuatNgu
            // 
            this.grcTraCuuThuatNgu.Location = new System.Drawing.Point(2, 35);
            this.grcTraCuuThuatNgu.MainView = this.grvTraCuuThuatNgu;
            this.grcTraCuuThuatNgu.Name = "grcTraCuuThuatNgu";
            this.grcTraCuuThuatNgu.Size = new System.Drawing.Size(1132, 715);
            this.grcTraCuuThuatNgu.TabIndex = 4;
            this.grcTraCuuThuatNgu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTraCuuThuatNgu});
            // 
            // grvTraCuuThuatNgu
            // 
            this.grvTraCuuThuatNgu.GridControl = this.grcTraCuuThuatNgu;
            this.grvTraCuuThuatNgu.Name = "grvTraCuuThuatNgu";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcTraCuuThuatNgu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 33);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1136, 719);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.btnReloadTraCuuThuatNgu);
            this.stackPanel1.Controls.Add(this.btnThemMoiTraCuuThuatNgu);
            this.stackPanel1.FireScrollEventOnMouseWheel = true;
            this.stackPanel1.Location = new System.Drawing.Point(2, 2);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(1132, 29);
            this.stackPanel1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.stackPanel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1136, 33);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // btnReloadTraCuuThuatNgu
            // 
            this.btnReloadTraCuuThuatNgu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnReloadTraCuuThuatNgu.Location = new System.Drawing.Point(3, 3);
            this.btnReloadTraCuuThuatNgu.Name = "btnReloadTraCuuThuatNgu";
            this.btnReloadTraCuuThuatNgu.Size = new System.Drawing.Size(129, 23);
            this.btnReloadTraCuuThuatNgu.TabIndex = 0;
            this.btnReloadTraCuuThuatNgu.Text = "Tải danh sách";
            this.btnReloadTraCuuThuatNgu.Click += new System.EventHandler(this.btnReloadTraCuuThuatNgu_Click);
            // 
            // btnThemMoiTraCuuThuatNgu
            // 
            this.btnThemMoiTraCuuThuatNgu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnThemMoiTraCuuThuatNgu.Location = new System.Drawing.Point(138, 3);
            this.btnThemMoiTraCuuThuatNgu.Name = "btnThemMoiTraCuuThuatNgu";
            this.btnThemMoiTraCuuThuatNgu.Size = new System.Drawing.Size(102, 23);
            this.btnThemMoiTraCuuThuatNgu.TabIndex = 1;
            this.btnThemMoiTraCuuThuatNgu.Text = "Thêm mới";
            this.btnThemMoiTraCuuThuatNgu.Click += new System.EventHandler(this.btnThemMoiTraCuuThuatNgu_Click);
            // 
            // frm_TraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 777);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_TraCuu";
            this.Text = "Tra cứu";
            this.Load += new System.EventHandler(this.frm_TraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTraCuuThuatNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTraCuuThuatNgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnReloadTraCuuThuatNgu;
        private DevExpress.XtraGrid.GridControl grcTraCuuThuatNgu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTraCuuThuatNgu;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiTraCuuThuatNgu;
    }
}