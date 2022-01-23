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

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class ViewText : DevExpress.XtraEditors.XtraForm
    {
        public ViewText(string TextView)
        {
            InitializeComponent();
            mmTextView.EditValue = TextView;
        }
    }
}