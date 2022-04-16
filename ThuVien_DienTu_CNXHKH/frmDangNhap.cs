using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            CheckApplication();
        }
        database.TV data = new database.TV();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) || !string.IsNullOrEmpty(txtPassword.Text))
            {
                string username = txtUsername.Text;
                string passWord = commom.Common.GetInstance().Md5(txtPassword.Text);
                var login = data.UserLogins.Where(p => p.Username == username && p.Password == passWord && p.status == true).ToList();
                if (login.Count() > 0 && login != null)
                {
                    Notification.GetInstance().ShowInformationToast("Đăng nhập thành công!");
                    commom.Commom_static.IDUser = login.FirstOrDefault().id;
                    commom.Commom_static.TenNguoiDung = login.FirstOrDefault().TenSinhVien;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UpdateApplication();
        }
        private async Task UpdateApplication()
        {
            try
            {
                string versionSoftware = Application.ProductVersion;
                // Check version
                var data = await commom.Function.Instance.InfoUnits(commom.Commom_static.APPID);
                if (!data.FirstOrDefault().Version.Equals(versionSoftware))
                {
                    // Update
                    System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
                    processStartInfo.Verb = "runas";
                    processStartInfo.FileName = commom.Commom_static.APPRUN;
                    Thread.Sleep(3000);
                    System.Diagnostics.Process.Start(processStartInfo);
                    Application.Exit();
                }
                else
                {
                    //Continue
                    XtraMessageBox.Show("Không có phiên bản mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private async Task CheckApplication()
        {
            try
            {
                string versionSoftware = Application.ProductVersion;
                // Check version
                var data = await commom.Function.Instance.InfoUnits(commom.Commom_static.APPID);
                if (!data.FirstOrDefault().Version.Equals(versionSoftware))
                {
                    btnDangNhap.Visible = false;
                }
                else
                {
                    btnNangCapPhanMen.Visible = false;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNangCapPhanMen.Visible = false;
              
            }
           
          
        }

        private void lblDanhKiTaiKhoan_Click(object sender, EventArgs e)
        {
            form.frmDangKiTaiKhoan frm = new form.frmDangKiTaiKhoan();
            frm.ShowDialog();
        }

        private void llblHuongDanSuDung_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string FilePathAbout = AppDomain.CurrentDomain.BaseDirectory + @"\HuongDanSuDungThuVienDientu.txt";
            if (System.IO.File.Exists(FilePathAbout))
            {
                string TextDocument = System.IO.File.ReadAllText(FilePathAbout);
                ThuVien_DienTu_CNXHKH.form.ViewText frm_ViewDocument = new ThuVien_DienTu_CNXHKH.form.ViewText(TextDocument);
                frm_ViewDocument.ShowDialog();
            }
                    
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}