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
    public partial class frmDangKiTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        database.TV data = new database.TV();
        public frmDangKiTaiKhoan()
        {
            InitializeComponent();
        }
        private async Task<bool> CheckVaild()
        {
            bool Result = true;
            string messenger = "Cảnh báo các trường sau:";
            if (string.IsNullOrEmpty(lblHoTen.Text.Trim()))
            {
                messenger += Environment.NewLine + "Họ tên không được để trống!";
            }
            if (string.IsNullOrEmpty(lblEmail.Text.Trim()))
            {
                messenger += Environment.NewLine + "Email không được để trống!";
            }
            if (string.IsNullOrEmpty(lblTaiKhoan.Text.Trim()))
            {
                messenger += Environment.NewLine + "Tài khoản không được để trống!";
            }
            if (!lblMatKhau.Text.Equals(lblXacNhanMatKhau.Text))
            {
                messenger += Environment.NewLine + "Mật khẩu không khớp!";
            }
          
           
            if (Result == false)
            {
                XtraMessageBox.Show(messenger, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return Result;

        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (CheckVaild().Result)
            {
                try
                {
                    database.UserLogin userLogin = new database.UserLogin();
                    userLogin.isAdmin = false;
                    userLogin.status = true;
                    userLogin.Username = lblHoTen.Text.Trim();
                    userLogin.Email = lblHoTen.Text.Trim();
                    userLogin.Password = commom.Common.GetInstance().Md5(lblXacNhanMatKhau.Text);
                    data.UserLogins.Add(userLogin);
                    if (data.SaveChanges() > 0)
                    {
                        XtraMessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi đăng kí: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
               
            }
        }
    }
}