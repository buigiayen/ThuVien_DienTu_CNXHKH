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
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_Email : DevExpress.XtraEditors.XtraForm
    {
        public frm_Email()
        {
            InitializeComponent();
        }
        private async void Load_GridControl_File()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "id", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Gửi từ", FieldName_Columns = "FileName" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tiêu đề", FieldName_Columns = "FilePath" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "", FieldName_Columns = "Ex" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "size", FieldName_Columns = "size" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "status", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            grvList.OptionsBehavior.ReadOnly = true;
        }


    }
}