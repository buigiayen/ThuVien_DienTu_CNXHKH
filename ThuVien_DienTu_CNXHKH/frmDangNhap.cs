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
using ThuVien_DienTu_CNXHKH.common;

namespace ThuVien_DienTu_CNXHKH
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        database.TV data = new database.TV();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                string username = txtUsername.Text;
                string passWord = commom.Common.GetInstance().Md5(txtPassword.Text);
                var login = data.UserLogins.Where(p => p.Username == username && p.Password == passWord && p.status == true).ToList();
                if (login.Count() >0 && login != null)
                {
                    Notification.GetInstance().ShowInformationToast("Đăng nhập thành công!");
                    commom.Commom_static.IDUser = login.FirstOrDefault().id;
                    commom.Commom_static.InfoUser = (login.FirstOrDefault().isAdmin ? "Quản trị viên: " : "Người dùng: ") + login.FirstOrDefault().Username + " - " + login.FirstOrDefault().TenSinhVien;
                    commom.Commom_static.isAdmin = login.FirstOrDefault().isAdmin;
                    frm_main frm = new frm_main(true);
                    this.Hide();
                }
                else
                {
                    Notification.GetInstance().ShowInformationToast("Tài khoản hoặc mật khẩu đúng!");
                }
                        
            }
            else
            {
                XtraMessageBox.Show("Tài khoản hoặc mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}