﻿
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class Frm_DanhMucSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DanhMucSinhVien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThemMoiSinhVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiDanhSach = new DevExpress.XtraEditors.SimpleButton();
            this.grcDanhSachSinhVien = new DevExpress.XtraGrid.GridControl();
            this.grvDanhSachSinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnThemMoiSinhVien);
            this.layoutControl1.Controls.Add(this.btnTaiDanhSach);
            this.layoutControl1.Controls.Add(this.grcDanhSachSinhVien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 261, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1090, 511);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnThemMoiSinhVien
            // 
            this.btnThemMoiSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoiSinhVien.ImageOptions.Image")));
            this.btnThemMoiSinhVien.Location = new System.Drawing.Point(148, 2);
            this.btnThemMoiSinhVien.Name = "btnThemMoiSinhVien";
            this.btnThemMoiSinhVien.Size = new System.Drawing.Size(159, 22);
            this.btnThemMoiSinhVien.StyleController = this.layoutControl1;
            this.btnThemMoiSinhVien.TabIndex = 6;
            this.btnThemMoiSinhVien.Text = "Thêm mới sinh viên";
            this.btnThemMoiSinhVien.Click += new System.EventHandler(this.btnThemMoiSinhVien_Click);
            // 
            // btnTaiDanhSach
            // 
            this.btnTaiDanhSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaiDanhSach.ImageOptions.Image")));
            this.btnTaiDanhSach.Location = new System.Drawing.Point(2, 2);
            this.btnTaiDanhSach.Name = "btnTaiDanhSach";
            this.btnTaiDanhSach.Size = new System.Drawing.Size(142, 22);
            this.btnTaiDanhSach.StyleController = this.layoutControl1;
            this.btnTaiDanhSach.TabIndex = 5;
            this.btnTaiDanhSach.Text = "Tải danh sách";
            this.btnTaiDanhSach.Click += new System.EventHandler(this.btnTaiDanhSach_Click);
            // 
            // grcDanhSachSinhVien
            // 
            this.grcDanhSachSinhVien.Location = new System.Drawing.Point(2, 28);
            this.grcDanhSachSinhVien.MainView = this.grvDanhSachSinhVien;
            this.grcDanhSachSinhVien.Name = "grcDanhSachSinhVien";
            this.grcDanhSachSinhVien.Size = new System.Drawing.Size(1086, 481);
            this.grcDanhSachSinhVien.TabIndex = 4;
            this.grcDanhSachSinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDanhSachSinhVien});
            // 
            // grvDanhSachSinhVien
            // 
            this.grvDanhSachSinhVien.GridControl = this.grcDanhSachSinhVien;
            this.grvDanhSachSinhVien.Name = "grvDanhSachSinhVien";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(1090, 511);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcDanhSachSinhVien;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1090, 485);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnTaiDanhSach;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(146, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnThemMoiSinhVien;
            this.layoutControlItem3.Location = new System.Drawing.Point(146, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(163, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(309, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(781, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Frm_DanhMucSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 511);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Frm_DanhMucSinhVien";
            this.Text = "Danh mục sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDanhSachSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnThemMoiSinhVien;
        private DevExpress.XtraEditors.SimpleButton btnTaiDanhSach;
        private DevExpress.XtraGrid.GridControl grcDanhSachSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDanhSachSinhVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}