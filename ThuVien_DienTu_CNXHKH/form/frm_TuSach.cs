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
using ThuVien_DienTu_CNXHKH.commom;
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
            ShowBook();

        }
        private database.TV data = new database.TV();
        private async void Load_GridControl_ViewTuSach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcTuSach;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvTuSach;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên sách ", FieldName_Columns = "TenSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Loại tài liệu ", FieldName_Columns = "LoaiTaiLieu" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tác giả ", FieldName_Columns = "TacGia" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Năm xuất bản", FieldName_Columns = "NamXuatBan" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mô tả", FieldName_Columns = "GhiChu" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tệp", FieldName_Columns = "ID_File", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị ", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShow", toolTip = "Xem sách", Action = new Action(() => Show_task("ID_File")) });
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 1, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, NameButton = "btnDownFile", toolTip = "Tải bài", Action = new Action(() => DownLoadFile("ID_File")) });
                if (commom.Commom_static.isAdmin)
                {
                    button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 2, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, NameButton = "btnDeleteBook", toolTip = "Xóa bài", Action = new Action(() => Delete_Book()) });

                }

                {
                    Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                    columns_GridLookUpedit.Add("Mã", "ID");
                    columns_GridLookUpedit.Add("Tên file", "FileName");
                    columns_GridLookUpedit.Add("Đường dẫn", "FilePath");
                    //All file
                    {
                        Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(string.Empty), new string[] { "ID_File" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
                    }
                }

                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            grvTuSach.CellValueChanging += GrvTuSach_CellValueChanging;

        }

        private async void GrvTuSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                int iDBook = (int)grvTuSach.GetFocusedRowCellValue("ID");
                database.tuSach ts = data.tuSaches.Single(p => p.ID == iDBook);
                if (e.Column.FieldName == "status")
                {
                    ts.status = (bool)e.Value;
                }
                if (e.Column.FieldName == "TacGia")
                {
                    ts.TacGia = e.Value.ToString();
                }
                if (e.Column.FieldName == "LoaiTaiLieu")
                {
                    ts.LoaiTaiLieu = e.Value.ToString();
                }
                if (e.Column.FieldName == "NamXuatBan")
                {
                    ts.NamXuatBan = e.Value.ToString();
                }
                if (e.Column.FieldName == "ID_File")
                {
                    ts.ID_File = (int)e.Value;
                }
                if (e.Column.FieldName == "TenSach")
                {
                    ts.TenSach = e.Value.ToString();
                }

                data.SaveChanges();
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
                    var DeleteBook = data.tuSaches.Single(p => p.ID == iDBook);
                    data.tuSaches.Remove(DeleteBook);
                    data.SaveChanges();
                    Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);
                }
            }


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);

        }
        private void ShowBook()
        {
            grcTuSach.DataSource = data.tuSaches.Where(p => commom.Commom_static.isAdmin ? true : p.status == true).ToList();
        }

        private async void Show_task(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0 && grvTuSach.GetFocusedRowCellValue(nameField) != null)
            {
                view.ViewFile viewFile = new view.ViewFile(await commom.Function.Instance.getFilePatd((int)grvTuSach.GetFocusedRowCellValue(nameField)));
                viewFile.Show();
            }
        }
        private async void DownLoadFile(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0 && grvTuSach.GetFocusedRowCellValue(nameField) != null)
            {
                string fileSource = await commom.Function.Instance.getFilePatd((int)grvTuSach.GetFocusedRowCellValue(nameField));
                string filePatd = await commom.Common.GetInstance().save_dialogFile();
                
                if (!string.IsNullOrEmpty(fileSource) && !string.IsNullOrEmpty(filePatd))
                {
                    File.Copy(fileSource, filePatd);
                }

            }
        }

        private void btnAddSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.tuSaches.Add(new database.tuSach { });
            data.SaveChanges();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);
        }

      
    }
}