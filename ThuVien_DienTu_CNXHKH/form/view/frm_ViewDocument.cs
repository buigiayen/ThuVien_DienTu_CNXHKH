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

namespace ThuVien_DienTu_CNXHKH.form.view
{
    public partial class frm_ViewDocument : DevExpress.XtraEditors.XtraForm
    {
        public frm_ViewDocument(string TextView)
        {
            InitializeComponent();
            richEditControl1.Text = TextView;
        }
    }
}