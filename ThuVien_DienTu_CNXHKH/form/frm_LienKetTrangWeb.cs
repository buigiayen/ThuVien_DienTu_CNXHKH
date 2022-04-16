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
            barButtonItem2.Visibility = commom.Commom_static.isAdmin ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            LoadDS();
        }
        database.TV data = new database.TV();
        private async void Load_GridControl_ViewLienKet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên trang web ", FieldName_Columns = "Mota" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link", FieldName_Columns = "link", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị ", FieldName_Columns = "status", Visible =false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Mota", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShowLink", toolTip = "Tải bài", Action = new Action(() => Show_Link()) });
                if (commom.Commom_static.isAdmin)
                {
                    button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit
                    {
                        buttonIndex = 1,
                        colname = "Mota",
                        styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete,
                        NameButton = "btnDeleteBook",
                        toolTip = "Xóa bài",
                        Action = new Action(() =>
                                                 Delete_Link())
                    });

                }
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            if (commom.Commom_static.isAdmin)
            {
                
                grvList.CellValueChanged += GrvList_CellValueChanged;
            }
            else
            {
                grvList.Columns["Mota"].OptionsColumn.ReadOnly = true;
            }


        }

        private void GrvList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int id = (int)grvList.GetRowCellValue(e.RowHandle, "id");
                var changedata = data.LienKets.Single(p => p.id == id);
                switch (e.Column.FieldName)
                {
                    case "Mota":
                        changedata.Mota = e.Value.ToString();
                        break;
                    case "link":
                        changedata.link = e.Value.ToString();
                        break;
                    case "status":
                        changedata.status = (bool)e.Value;
                        break;
                }
                data.SaveChanges();
            }
        }

        private void Delete_Link()
        {
            if (grvList.FocusedRowHandle >= 0)
            {
                DialogResult r = XtraMessageBox.Show("Bạn có chắc?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult.OK == r)
                {
                    int id = (int)grvList.GetRowCellValue(grvList.FocusedRowHandle, "id");
                    var changedata = data.LienKets.Remove(data.LienKets.Where(p => p.id == id).FirstOrDefault());
                    data.SaveChanges();
                }
            }
        }

        private void Show_Link()
        {
            if (grvList.FocusedRowHandle >= 0)
            {
                string link = grvList.GetFocusedRowCellValue("link").ToString();
                commom.Common.GetInstance().process_ShowLink(link);
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

        private void frm_LienKetTrangWeb_Load(object sender, EventArgs e)
        {

        }
    }
}