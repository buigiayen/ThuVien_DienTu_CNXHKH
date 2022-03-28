using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ThuVien_DienTu_CNXHKH.form;

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
            Application.Run(new frm_main(false));
        }
        private static void threadException(object sender, ThreadExceptionEventArgs e)
        {
            DialogResult r = XtraMessageBox.Show("Có lỗi xảy ra! " + e.Exception.ToString(), "Bạn có muốn báo cáo tới hệ thống về lỗi dưới này hay không!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (r == DialogResult.OK)
            {
                frm_Feedback frm = new frm_Feedback(e.Exception.Message + commom.Commom_static.InfoUser);
                frm.ShowDialog();
            }

            return;
        }
    }
}
