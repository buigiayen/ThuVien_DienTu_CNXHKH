
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class frm_TaiLieuThamKhao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaiLieuThamKhao));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.grcList = new DevExpress.XtraGrid.GridControl();
            this.grvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colShowFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnShowFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.stackPanel1);
            this.layoutControl1.Controls.Add(this.grcList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(941, 594);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.btnReload);
            this.stackPanel1.Controls.Add(this.btnThemMoi);
            this.stackPanel1.Location = new System.Drawing.Point(2, 2);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(937, 36);
            this.stackPanel1.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(3, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(113, 23);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Tải danh sách";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.ImageOptions.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(122, 6);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // grcList
            // 
            this.grcList.Location = new System.Drawing.Point(2, 42);
            this.grcList.MainView = this.grvList;
            this.grcList.Name = "grcList";
            this.grcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnShowFile});
            this.grcList.Size = new System.Drawing.Size(937, 550);
            this.grcList.TabIndex = 4;
            this.grcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvList});
            // 
            // grvList
            // 
            this.grvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colShowFile});
            this.grvList.GridControl = this.grcList;
            this.grvList.Name = "grvList";
            // 
            // colShowFile
            // 
            this.colShowFile.Caption = "Xem file";
            this.colShowFile.ColumnEdit = this.btnShowFile;
            this.colShowFile.Name = "colShowFile";
            this.colShowFile.Visible = true;
            this.colShowFile.VisibleIndex = 0;
            // 
            // btnShowFile
            // 
            this.btnShowFile.AutoHeight = false;
            this.btnShowFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
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
            this.Root.Size = new System.Drawing.Size(941, 594);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(941, 554);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.stackPanel1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(941, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frm_TaiLieuThamKhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 594);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frm_TaiLieuThamKhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài liệu tham khảo";
            this.Load += new System.EventHandler(this.frm_TaiLieuThamKhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraGrid.GridControl grcList;
        private DevExpress.XtraGrid.Views.Grid.GridView grvList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colShowFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnShowFile;
    }
}