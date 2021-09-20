using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ThuVien_DienTu_CNXHKH
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(threadException);
            Application.Run(new frmDangNhap());
        }
        private static void threadException(object sender, ThreadExceptionEventArgs e)
        {
            XtraMessageBox.Show("Có lỗi xảy ra! " + e.Exception.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            return;
        }
    }
}
