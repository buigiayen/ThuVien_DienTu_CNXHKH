using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static frm_Update.DungChung;

namespace DownloadFTPWithProgress
{
    public partial class frm_Update : DevExpress.XtraEditors.XtraForm
    {

        public frm_Update()
        {
            InitializeComponent();
            ListDir();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Task.Run(() => RunDowns());
        }
        private async void RunDowns()
        {
            try
            {
                var ListDLLcheck = listdll.Where(p => p.Check == true).ToList();
                int j = listdll.Count / 100;
                progressBarControl1.Invoke(new Action(() => { progressBarControl1.Properties.Maximum = listdll.Count; }));
                foreach (var item in ListDLLcheck.ToList())
                {
                    progressBarControl1.Invoke(new Action(() =>
                    {
                        progressBarControl1.EditValue = j;
                    }));
                    string remotefile = item.NameDLL;
                    Cresoft_Center.DungChung.Ham.ThuchiencongViec.download_FTP(await getStringURLsync() + "\\" + remotefile, AppDomain.CurrentDomain.BaseDirectory + item.NameDLL);
                    j++;
                }
                DialogResult result = MessageBox.Show("Đã cập nhật xong ứng dụng \n Khởi động lại để áp dụng!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Process process = new Process();
                    process.StartInfo.Verb = "runas";
                    process.StartInfo.FileName = "Cresoft.exe";
                    process.Start();
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex);
            }

        }
        private class File_Upgrade
        {
            public string NameDLL { get; set; }
            public string Date { get; set; }
            public string Kb { get; set; }
            public bool Check { get; set; }
        }
        private List<File_Upgrade> listdll = new List<File_Upgrade>();
        public async Task<string> getStringURLsync()
        {
            return Ham.GetInformationSystems.FirstOrDefault().URLUPDATE + "\\" + Ham.GetInformationSystems.FirstOrDefault().URIUPDATE + "\\" + Ham.GetInformationSystems.FirstOrDefault().Vesion;
        }
        private async void ListDir()
        {
            string[] GetFileFoder = (Cresoft_Center.DungChung.Ham.ThuchiencongViec.directoryListDetailed(await getStringURLsync()).Where(p => !string.IsNullOrEmpty(p)).ToArray());
            progressBarControl1.Properties.Maximum = GetFileFoder.Length;
            int Value = listdll.Count / 100;
            foreach (var item in GetFileFoder)
            {
                string[] FileArr = item.Split(' ').Where(p => !string.IsNullOrEmpty(p)).ToArray();
                File_Upgrade file_Upgrade = new File_Upgrade();
                file_Upgrade.NameDLL = FileArr[3].ToString();
                double sizes = Convert.ToDouble(FileArr[2]?.ToString()) / 1024;
                if ((int)sizes <= 0 || (int)sizes == 0)
                {
                    sizes = 1;
                }
                file_Upgrade.Kb = sizes.ToString("#,#") + " MB";
                file_Upgrade.Date = FileArr[0].ToString() + " " + FileArr[1].ToString();
                file_Upgrade.Check = true;
                listdll.Add(file_Upgrade);
            }
            grvdll.DataSource = listdll.ToList();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            listdll.Clear();
            ListDir();
        }
    }
}
