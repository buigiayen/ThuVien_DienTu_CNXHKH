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
    public partial class ViewFile : DevExpress.XtraEditors.XtraForm
    {
        public ViewFile(string fileName)
        {
            InitializeComponent();
            pdfViewer1.LoadDocument(fileName);
        }
    }
}