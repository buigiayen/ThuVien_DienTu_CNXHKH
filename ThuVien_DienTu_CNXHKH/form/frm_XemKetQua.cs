﻿using DevExpress.XtraEditors;
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
    public partial class frm_XemKetQua : DevExpress.XtraEditors.XtraForm
    {
        public frm_XemKetQua()
        {
            InitializeComponent();
        }
        public class XemCauHoi
        {
            public string CauHoi { get; set; }
            public string CauTraLoiDung { get; set; }
            public string CauTraLoi { get; set; }

        }
        public void DataBindGridControl(List<XemCauHoi> xemCauHois)
        {
            grcKetQua.DataSource = xemCauHois.ToList();
        }


    }
}