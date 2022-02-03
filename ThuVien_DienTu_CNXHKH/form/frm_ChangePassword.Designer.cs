
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChangePassword));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtPassNew2 = new DevExpress.XtraEditors.TextEdit();
            this.txtPassNew = new DevExpress.XtraEditors.TextEdit();
            this.txtPasswordOld = new DevExpress.XtraEditors.TextEdit();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lPassold = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lPassnew2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnChangePassWord = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordOld.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassnew2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnChangePassWord);
            this.layoutControl1.Controls.Add(this.txtPassNew2);
            this.layoutControl1.Controls.Add(this.txtPassNew);
            this.layoutControl1.Controls.Add(this.txtPasswordOld);
            this.layoutControl1.Controls.Add(this.txtUsername);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(505, 190);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtPassNew2
            // 
            this.txtPassNew2.Location = new System.Drawing.Point(2, 138);
            this.txtPassNew2.Name = "txtPassNew2";
            this.txtPassNew2.Properties.UseSystemPasswordChar = true;
            this.txtPassNew2.Size = new System.Drawing.Size(501, 20);
            this.txtPassNew2.StyleController = this.layoutControl1;
            this.txtPassNew2.TabIndex = 7;
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(2, 98);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Properties.UseSystemPasswordChar = true;
            this.txtPassNew.Size = new System.Drawing.Size(501, 20);
            this.txtPassNew.StyleController = this.layoutControl1;
            this.txtPassNew.TabIndex = 6;
            // 
            // txtPasswordOld
            // 
            this.txtPasswordOld.Location = new System.Drawing.Point(2, 58);
            this.txtPasswordOld.Name = "txtPasswordOld";
            this.txtPasswordOld.Properties.UseSystemPasswordChar = true;
            this.txtPasswordOld.Size = new System.Drawing.Size(501, 20);
            this.txtPasswordOld.StyleController = this.layoutControl1;
            this.txtPasswordOld.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(2, 18);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(501, 20);
            this.txtUsername.StyleController = this.layoutControl1;
            this.txtUsername.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.lPassold,
            this.layoutControlItem3,
            this.lPassnew2,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(505, 190);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtUsername;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(505, 40);
            this.layoutControlItem1.Text = "User:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 160);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(367, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lPassold
            // 
            this.lPassold.Control = this.txtPasswordOld;
            this.lPassold.Location = new System.Drawing.Point(0, 40);
            this.lPassold.Name = "lPassold";
            this.lPassold.Size = new System.Drawing.Size(505, 40);
            this.lPassold.Text = "Mật khẩu cũ";
            this.lPassold.TextLocation = DevExpress.Utils.Locations.Top;
            this.lPassold.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPassNew;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(505, 40);
            this.layoutControlItem3.Text = "Mật khẩu mới:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 13);
            // 
            // lPassnew2
            // 
            this.lPassnew2.Control = this.txtPassNew2;
            this.lPassnew2.Location = new System.Drawing.Point(0, 120);
            this.lPassnew2.Name = "lPassnew2";
            this.lPassnew2.Size = new System.Drawing.Size(505, 40);
            this.lPassnew2.Text = "Xác nhận mật khẩu:";
            this.lPassnew2.TextLocation = DevExpress.Utils.Locations.Top;
            this.lPassnew2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // btnChangePassWord
            // 
            this.btnChangePassWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassWord.ImageOptions.Image")));
            this.btnChangePassWord.Location = new System.Drawing.Point(369, 162);
            this.btnChangePassWord.Name = "btnChangePassWord";
            this.btnChangePassWord.Size = new System.Drawing.Size(134, 22);
            this.btnChangePassWord.StyleController = this.layoutControl1;
            this.btnChangePassWord.TabIndex = 8;
            this.btnChangePassWord.Text = "Đổi mật khẩu";
            this.btnChangePassWord.Click += new System.EventHandler(this.btnChangePassWord_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnChangePassWord;
            this.layoutControlItem5.Location = new System.Drawing.Point(367, 160);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(138, 30);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 190);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ChangePassword";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordOld.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassnew2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnChangePassWord;
        private DevExpress.XtraEditors.TextEdit txtPassNew2;
        private DevExpress.XtraEditors.TextEdit txtPassNew;
        private DevExpress.XtraEditors.TextEdit txtPasswordOld;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lPassold;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem lPassnew2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}