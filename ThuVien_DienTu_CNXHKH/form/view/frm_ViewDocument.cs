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
        public string TextSave { get; set; }
        public bool SaveBai { get; set; } = false;
        public frm_ViewDocument(string TextView, int? IDBai)
        {
            InitializeComponent();
            richEditControl1.Text = TextView;
          
            btnLuuTaiLieu.Visible = IDBai != null;
        }
        database.TV data = new database.TV();
        private void btnLuuTaiLieu_Click(object sender, EventArgs e)
        {
            TextSave = richEditControl1.Text;
            SaveBai = true;
            this.Close();
        }
    }
}