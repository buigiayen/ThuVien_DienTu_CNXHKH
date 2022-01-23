
namespace ThuVien_DienTu_CNXHKH.form
{
    partial class ViewText
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
            this.mmTextView = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.mmTextView.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mmTextView
            // 
            this.mmTextView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmTextView.Location = new System.Drawing.Point(0, 0);
            this.mmTextView.Name = "mmTextView";
            this.mmTextView.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmTextView.Properties.Appearance.Options.UseFont = true;
            this.mmTextView.Properties.ReadOnly = true;
            this.mmTextView.Size = new System.Drawing.Size(1219, 636);
            this.mmTextView.TabIndex = 0;
            // 
            // ViewText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 636);
            this.Controls.Add(this.mmTextView);
            this.Name = "ViewText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư viện điện tử";
            ((System.ComponentModel.ISupportInitialize)(this.mmTextView.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit mmTextView;
    }
}