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
                string passWord = commom.Commom.ThuchiencongViec.Md5(txtPassword.Text);
                var login = data.UserLogins.Where(p => p.Username == username && p.Password == passWord && p.status == true).ToList();
                if (login.Count() >0 && login != null)
                {
                    commom.Commom_static.isAdmin = login.FirstOrDefault().isAdmin;
                    frm_main frm = new frm_main();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Tài khoản hoặc mật khẩu đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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