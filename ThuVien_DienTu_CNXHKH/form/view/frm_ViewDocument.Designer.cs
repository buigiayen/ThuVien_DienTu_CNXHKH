
namespace ThuVien_DienTu_CNXHKH.form.view
{
    partial class frm_ViewDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ViewDocument));
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnLuuTaiLieu = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(1073, 789);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // btnLuuTaiLieu
            // 
            this.btnLuuTaiLieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnLuuTaiLieu.Location = new System.Drawing.Point(26, 12);
            this.btnLuuTaiLieu.Name = "btnLuuTaiLieu";
            this.btnLuuTaiLieu.Size = new System.Drawing.Size(97, 23);
            this.btnLuuTaiLieu.TabIndex = 1;
            this.btnLuuTaiLieu.Text = "Lưu tài liệu";
            this.btnLuuTaiLieu.Click += new System.EventHandler(this.btnLuuTaiLieu_Click);
            // 
            // frm_ViewDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 789);
            this.Controls.Add(this.btnLuuTaiLieu);
            this.Controls.Add(this.richEditControl1);
            this.Name = "frm_ViewDocument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư viện điện tử";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.SimpleButton btnLuuTaiLieu;
    }
}