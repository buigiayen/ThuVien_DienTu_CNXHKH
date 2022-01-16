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
    public partial class frm_ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        private int UserID { get; set; }
        public frm_ChangePassword(int IDUser, string UserName)
        {
            InitializeComponent();
            txtUsername.Text = UserName;
            CheckIsAdmin();
        }
        private async void CheckIsAdmin()
        {
            if (commom.Commom_static.isAdmin)
            {
                btnChangePassWord.Text = "Tạo lại mật khẩu";
                lPassold.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lPassnew2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private async void btnChangePassWord_Click(object sender, EventArgs e)
        {
            if (await CheckCondition())
            {
                string PassOld = txtPasswordOld.Text.Trim();
                string passNew = txtPassNew2.Text.Trim();
                string mess = await commom.Function.Instance.ChangePassword(UserID, PassOld, passNew);
                XtraMessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> CheckCondition()
        {
            bool valid = true;
            string messenger = string.Empty;
            if (!commom.Commom_static.isAdmin)
            {
                {
                    if (string.IsNullOrEmpty(txtPasswordOld.Text))
                    {
                        valid = false;
                        messenger += "Mật khẩu mới không thể để null. ";
                    }
                }
                {
                    if (txtPassNew2.Text.Equals(txtPassNew.Text))
                    {
                        valid = false;
                        messenger += "Mật khẩu xác nhận chưa chính xác";
                    }
                    if (txtPassNew2.Text.Length < 6)
                    {
                        valid = false;
                        messenger += "Mật khẩu mới chưa đủ 6 kí tự! ";
                    }
                    if (string.IsNullOrEmpty(txtPassNew2.Text))
                    {
                        valid = false;
                        messenger += "Mật khẩu mới không thể để null ";
                    }
                }

            }
            if (txtPassNew.Text.Length < 6)
            {
                valid = false;
                messenger += "Mật khẩu mới chưa đủ 6 kí tự! ";
            }
            if (string.IsNullOrEmpty(txtPassNew.Text))
            {
                valid = false;
                messenger += "Mật khẩu mới không thể để null ";
            }
            return valid;
        }


    }
}