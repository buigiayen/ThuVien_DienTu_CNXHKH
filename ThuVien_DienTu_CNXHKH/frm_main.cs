﻿

using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
using System.Xml;
using ThuVien_DienTu_CNXHKH.form;

namespace ThuVien_DienTu_CNXHKH
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private static bool IsLogin { get; set; }
        public frm_main(bool _IsLogin = true)
        {
            InitializeComponent();
            IsLogin = _IsLogin;
            lblAppInfomation.Caption = lblAppInfomation.Caption + " - version: " + Application.ProductVersion;
        }

        private void ShowLogin()
        {
            if (!IsLogin)
            {
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
                lblUser.Caption = commom.Commom_static.InfoUser; 
            }
        }

        private Form kiemtraform(Type ftype, int Tabcon)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype && Tabcon == 0)
                {
                    return f;
                }
            }
            return null;
        }
        private void Moform<T>(int tabcon) where T : DevExpress.XtraEditors.XtraForm, new()
        {
            if (IsLogin)
            {
                Form frm = kiemtraform(typeof(T), tabcon);
                if (frm == null)
                {
                    T mofrom = new T();
                    mofrom.MdiParent = this;
                    mofrom.Show();
                }
                else
                {
                    frm.Activate();
                }
            }
            else
            {
                ShowLogin();
            }
        }
                   
        private void btnLyThuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<from.frm_LyThuyet>(0);
        }

        private void btnDanhMucLyThuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_DanhMuc>(0);
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
                    btnNangCapPhanMen.Visibility =  DevExpress.XtraBars.BarItemVisibility.Always;
                }
              
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Không có kết nối: "+ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNangCapPhanMen.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

            }


        }
        private async void frm_main_Load(object sender, EventArgs e)
        {
            await CheckApplication();
            Moform<form.FrmView>(0);
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.Frm_DanhMucSinhVien>(0);
        }

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnTuSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_TuSachV2>(0);

        }

        private void btnLienKetTrangWeb_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Moform<form.frm_LienKetTrangWeb>(0);
        }

        private void btnEmailPhanHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form.frm_Feedback frm = new form.frm_Feedback();
            frm.ShowDialog();
        }

        private void btnTuSachKinhDien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_TuSachKinhDien>(0);

        }

        private void btnNhomSachKinhDien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.Frm_NhomSachKinhDien>(0);
        }

        private void btnSachKinhDien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }

        private void btnFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_File>(0);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_TraCuu>(0);

        }

        private void btnKetQuaThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_KetQuaThi>(0);
        }

        private void btnLogOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IsLogin = false;
            ShowLogin();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTuSachVanKien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_TuSachVanKien>(0);
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_DanhMucTuSachVanKien>(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void skinDropDownButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string FilePathAbout = AppDomain.CurrentDomain.BaseDirectory + @"\HuongDanSuDungThuVienDientu.txt";
            if (System.IO.File.Exists(FilePathAbout))
            {
                string TextDocument = System.IO.File.ReadAllText(FilePathAbout);
                ThuVien_DienTu_CNXHKH.form.ViewText frm_ViewDocument = new ThuVien_DienTu_CNXHKH.form.ViewText(TextDocument);
                frm_ViewDocument.ShowDialog();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnNangCapPhanMen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}
