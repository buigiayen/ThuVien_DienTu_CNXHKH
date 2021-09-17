﻿using System;
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
    }
}
