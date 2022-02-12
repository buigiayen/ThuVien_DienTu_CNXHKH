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
    public partial class frm_LienKetTrangWeb : DevExpress.XtraEditors.XtraForm
    {
        public frm_LienKetTrangWeb()
        {
            InitializeComponent();
            Load_GridControl_ViewLienKet();
        }
        database.TV data = new database.TV();
        private async void Load_GridControl_ViewLienKet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mô tả ", FieldName_Columns = "Mota" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link", FieldName_Columns = "link", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị ", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Mota", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShowLink", toolTip = "Tải bài", Action = new Action(() => Show_Link()) });
                if (commom.Commom_static.isAdmin)
                {
                    button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 1, colname = "Mota", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, NameButton = "btnDeleteBook", toolTip = "Xóa bài", Action = new Action(() => Delete_Link()) });

                }

                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }


        }

        private void Delete_Link()
        {
            throw new NotImplementedException();
        }

        private void Show_Link()
        {
            if (grvList.FocusedRowHandle >= 0)
            {
                string link = grvList.GetFocusedRowCellValue("link").ToString();
                commom.Common.GetInstance().process_Application(link);
            }
                    
          
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadDS);
        }
        private async void LoadDS()
        {
            grcList.DataSource = data.LienKets.Where(p => commom.Commom_static.isAdmin == true ? true : p.status == true).ToList();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.LienKets.Add(new database.LienKet { });
            data.SaveChanges();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadDS);
        }
    }
}