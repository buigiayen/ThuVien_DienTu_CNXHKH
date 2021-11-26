using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuVien_DienTu_CNXHKH
{
    public partial class frm_main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_main()
        {
            InitializeComponent();
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

        private void btnLyThuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<from.frm_LyThuyet>(0);
        }

        private void btnDanhMucLyThuyet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Moform<form.frm_DanhMuc>(0);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (!commom.Commom_static.isAdmin)
            {
                ribbonPage2.Visible = false;
            }
            
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
            Moform<form.frm_TuSach>(0);
            
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
    }
}
