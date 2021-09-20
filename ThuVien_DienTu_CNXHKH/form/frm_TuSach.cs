using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_TuSach : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuSach()
        {
            InitializeComponent();
            Load_GridControl_ViewTuSach();
            btnAddSach.Visibility = commom.Commom_static.isAdmin ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
            grvTuSach.OptionsBehavior.ReadOnly = !commom.Commom_static.isAdmin;


        }
        private database.TV data = new database.TV();
        private async void Load_GridControl_ViewTuSach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcTuSach;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvTuSach;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên sách ", FieldName_Columns = "TenSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link ", FieldName_Columns = "LinkSach", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị ", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShow", toolTip = "Xem sách", Action = new Action(() => Show_task("LinkSach")) });
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 1, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, NameButton = "btnDownFile", toolTip = "Tải bài", Action = new Action(() => DownLoadFile("LinkSach")) });
                if (commom.Commom_static.isAdmin)
                {
                    button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 2, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, NameButton = "btnDeleteBook", toolTip = "Xóa bài", Action = new Action(() => Delete_Book()) });

                }

                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }


        }

        private void Delete_Book()
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                DialogResult r = XtraMessageBox.Show("Bạn có muốn xóa sách này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    int iDBook = (int)grvTuSach.GetFocusedRowCellValue("ID");
                    data.tuSaches.Remove(new database.tuSach { ID = iDBook });
                    data.SaveChanges();
                }
            }


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);

        }
        private void ShowBook()
        {
            grcTuSach.DataSource = data.tuSaches.Where(p => commom.Commom_static.isAdmin ? p.status == true : true).ToList();
        }

        private async void Show_task(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                commom.Commom.ThuchiencongViec.process_Application(grvTuSach.GetFocusedRowCellValue(nameField)?.ToString());
            }




        }
        private async void DownLoadFile(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                string filePatd = await commom.Commom.ThuchiencongViec.save_dialogFile();
                if (!string.IsNullOrEmpty(filePatd))
                {
                    string fileDesc = grvTuSach.GetFocusedRowCellValue(nameField)?.ToString();
                    File.Copy(fileDesc, filePatd);
                }

            }
        }

        private void btnAddSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Panel frm = new Form_Panel(Form_Panel.FormName.ThemMoiSach);
            frm.ShowDialog();
        }

        private void grvTuSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                int iDBook = (int)grvTuSach.GetFocusedRowCellValue("ID");
                database.tuSach ts = data.tuSaches.Single(p => p.ID == iDBook);
                if (e.Column.FieldName == "status")
                {
                    ts.status = (bool)e.Value;
                }
                if (e.Column.FieldName == "LinkSach")
                {
                    ts.LinkSach = e.Value.ToString();
                }
                if (e.Column.FieldName == "TenSach")
                {
                    ts.TenSach = e.Value.ToString();
                }

                data.SaveChanges();
            }


        }
    }
}