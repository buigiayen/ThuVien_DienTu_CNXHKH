using frm_Update;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DownloadFTPWithProgress
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] agrs)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            if (Read_REG().Result)
            {
                Application.Run(new frm_Update());
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }

        }
        private static async Task<bool> Read_REG()
        {
            try
            {
                DungChung.Ham.GetInformationSystems = await DungChung.Ham.InformationSystems(new DungChung.Ham.InformationSystem
                {
                    ID = Convert.ToInt32(Cresoft_Center.DungChung.Ham.ThuchiencongViec.open_Registrykey("MADONVI").Result),
                    URLUPDATE = (await Cresoft_Center.DungChung.Ham.ThuchiencongViec.open_Registrykey("URLUPDATE")).ToString(),
                    URIUPDATE = (await Cresoft_Center.DungChung.Ham.ThuchiencongViec.open_Registrykey("URIUPDATE")).ToString(),
                    Vesion = (await Cresoft_Center.DungChung.Ham.ThuchiencongViec.open_Registrykey("Vesion")).ToString()
                });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể cập nhật ứng dụng! {ex.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                Cresoft_Center.DungChung.Ham.ThuchiencongViec.Write_Log_Error($"Không thể cập nhật ứng dụng! {ex.ToString()}");
                return false;
            }
        }
        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            XtraMessageBox.Show("Cập nhật thất bại! " + t.Exception.Message);
            Application.Exit();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Cập nhật thất bại! " + ((Exception)e.ExceptionObject).Message);
            Application.Exit();
        }
    }
}
