using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_Feedback : DevExpress.XtraEditors.XtraForm
    {
        public frm_Feedback()
        {
            InitializeComponent();
        }
        public frm_Feedback(string Text)
        {
            InitializeComponent();
            txtNoiDung.Text = Text;
        }
        private database.TV data = new database.TV();
        private async void btnFileAtt_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                string filePath = await commom.Common.GetInstance().open_dialogFile();
                if (!string.IsNullOrEmpty(filePath))
                {
                    btnFileAtt.EditValue = filePath;
                }


            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(SendEmail);
        }
        private async void SendEmail()
        {
            if (lupEmailto.EditValue != null)
            {
                var status = await commom.Common.GetInstance().SendEmail(lupEmailto.EditValue.ToString(), txtTieuDe.Text, txtNoiDung.HtmlText, btnFileAtt.Text);
                XtraMessageBox.Show(status.FirstOrDefault().messeger, "Thông báo", MessageBoxButtons.OK, status.FirstOrDefault().sendStatus == true ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                database.HomThu homThu = new database.HomThu();
                homThu.emailTo = lupEmailto.EditValue.ToString();
                homThu.title = txtTieuDe.Text;
                homThu.body = txtNoiDung.HtmlText;
                homThu.fileAtt = btnFileAtt.Text;
                homThu.EX = status.FirstOrDefault().messeger;
                homThu.status = status.FirstOrDefault().sendStatus;
                data.HomThus.Add(homThu);
                data.SaveChanges();
            }
            else
            {
                XtraMessageBox.Show("Chưa có thông tin email nhận");
            }
           
        }

        private async void frm_Feedback_Load(object sender, EventArgs e)
        {
        
            lupEmailto.Properties.DataSource = await  commom.Common.GetInstance().Email_Connecs();
            lupEmailto.Properties.ValueMember = "Email";
            lupEmailto.Properties.DisplayMember = "MoTa";
            
            
        }
    }
}