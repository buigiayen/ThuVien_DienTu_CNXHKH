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
    public partial class Form_Panel : DevExpress.XtraEditors.XtraForm
    {
        private FormName _form;
        public Form_Panel(FormName formName)
        {
            InitializeComponent();
            _form = formName;
            grvList.CellValueChanging += GrvList_CellValueChanging;
        }

        public enum FormName
        {
            ThemMoiBaiViet = 0x0000,
            ThemMoiNhom = 0X0001,
            ThemMoiSinhVien = 0X0002,
            ThemMoiSach = 0X0003,
        }
        private List<database.NhomSach> NhomSaches = new List<database.NhomSach>();
        private List<database.UserLogin> userLogins = new List<database.UserLogin>();
        private List<database.tbl_BaiViet> baiViets = new List<database.tbl_BaiViet>();
        private List<database.tuSach> Sachs = new List<database.tuSach>();
        private void Form_Panel_Load(object sender, EventArgs e)
        {
            switch (_form)
            {
                case FormName.ThemMoiBaiViet:
                    Load_GridControl_ThemMoiBaiViet();
                    break;
                case FormName.ThemMoiNhom:
                    Load_GridControl_ThemMoiNhom();
                    break;
                case FormName.ThemMoiSinhVien:
                    Load_GridControl_DSSinhVien();
                    break;
                case FormName.ThemMoiSach:
                    Load_GridControl_Sach();
                    break;

            }

        }
        database.TV tV = new database.TV();
        private async void Load_GridControl_ThemMoiBaiViet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link tệp đính kèm", FieldName_Columns = "Link_ppt" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link âm thanh", FieldName_Columns = "Link_voice" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm bài viết", FieldName_Columns = "ID_NhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties, true);
            Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
            columns_GridLookUpedit.Add("Mã", "IDNhomSach");
            columns_GridLookUpedit.Add("Nhóm", "TenNhomSach");
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(tV.NhomSaches.ToList(), new string[] { "ID_NhomSach" }, columns_GridLookUpedit, "IDNhomSach", "TenNhomSach");
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Link_ppt", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Left, NameButton = "btnFile", toolTip = "Chọn file!", Action = new Action(() => OpenSaveFile(1, "Link_ppt")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Link_voice", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Left, NameButton = "btnFileVoice", toolTip = "Chọn file âm thanh!", Action = new Action(() => OpenSaveFile(2, "Link_voice")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            ForList();
            grcList.DataSource = new BindingList<database.tbl_BaiViet>(baiViets.ToList());

        }
        private async void Load_GridControl_ThemMoiNhom()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên nhóm ", FieldName_Columns = "TenNhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties, true);
            ForList();
            grcList.DataSource = new BindingList<database.NhomSach>(NhomSaches.ToList());

        }
        private void Load_GridControl_DSSinhVien()
        {

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã sinh viên", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên đăng nhập", FieldName_Columns = "Username" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mật khẩu", FieldName_Columns = "Password" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên sinh viên", FieldName_Columns = "TenSinhVien" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Quyền admin", FieldName_Columns = "isAdmin" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Sử dụng", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            ForList();
            grcList.DataSource = new BindingList<database.UserLogin>(userLogins.ToList());
        }
        private void Load_GridControl_Sach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên sách ", FieldName_Columns = "TenSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link ", FieldName_Columns = "LinkSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị ", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "LinkSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, NameButton = "btnUploadFile", toolTip = "upload File", Action = new Action(() => OpenSaveFile(1, "LinkSach")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            ForList();
            grcList.DataSource = new BindingList<database.tuSach>(Sachs.ToList());
        }



        private async void ForList()
        {
            for (int i = 0; i < 100; i++)
            {
                switch (_form)
                {
                    case FormName.ThemMoiBaiViet:
                        baiViets.Add(new database.tbl_BaiViet { id = i, TenBaiViet = "", status = false, Link_ppt = "", Link_voice = "" });
                        break;
                    case FormName.ThemMoiNhom:
                        NhomSaches.Add(new database.NhomSach { IDNhomSach = i, TenNhomSach = "", status = false });
                        break;
                    case FormName.ThemMoiSinhVien:
                        userLogins.Add(new database.UserLogin { id = i, Username = "", Password = "", isAdmin = false, TenSinhVien = "", status = false });
                        break;
                    case FormName.ThemMoiSach:
                        Sachs.Add(new database.tuSach { ID = i, LinkSach = "", status = false, TenSach = "" });
                        break;

                }

            }
        }
        private void OpenSaveFile(int value, string nameFiled)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (value == 2)
            {
                openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3";
            }
            else
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {

                    DevExpress.XtraGrid.Columns.GridColumn gridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
                    gridColumn.FieldName = nameFiled;
                    GrvList_CellValueChanging(null, new DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs(grvList.FocusedRowHandle, gridColumn, openFileDialog.FileName));
                }

            }
        }

        private void GrvList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.Column.FieldName == "Link_ppt")
                {
                    grvList.SetFocusedRowCellValue("Link_ppt", e.Value);
                }
                if (e.Column.FieldName == "Link_voice")
                {
                    grvList.SetFocusedRowCellValue("Link_voice", e.Value);
                }
                if (e.Column.FieldName == "LinkSach")
                {
                    grvList.SetFocusedRowCellValue("LinkSach", e.Value);
                }
            }
        }

        private async void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(Save);
        }

        private void btnLuuSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var items in grvList.GetSelectedRows())
            {

                switch (_form)
                {
                    case FormName.ThemMoiBaiViet:
                        foreach (var item in baiViets.Where(p => p.TenBaiViet != null && p.id == items && p.ID_NhomSach != null))
                        {
                            tV.tbl_BaiViet.Add(new database.tbl_BaiViet { TenBaiViet = item.TenBaiViet, Link_voice = item.Link_voice, Link_ppt = item.Link_ppt, ID_NhomSach = item.ID_NhomSach, status = item.status });
                        }

                        break;
                    case FormName.ThemMoiNhom:
                        foreach (var item in NhomSaches.Where(p => p.IDNhomSach == items && p.TenNhomSach != null))
                        {
                            tV.NhomSaches.Add(new database.NhomSach { TenNhomSach = item.TenNhomSach, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSinhVien:
                        foreach (var item in userLogins.Where(p => p.id == items && p.TenSinhVien != null && p.TenSinhVien != "" && p.Username != null && p.Username != "" && p.Password != null && p.Password != ""))
                        {
                            tV.UserLogins.Add(new database.UserLogin { Username = item.TenSinhVien, Password = commom.Commom.ThuchiencongViec.Md5(item.Password), TenSinhVien = item.TenSinhVien, isAdmin = item.isAdmin, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSach:
                        foreach (var item in Sachs.Where(p => p.ID == items && p.TenSach != null && p.TenSach != "" && p.status != null))
                        {
                            tV.tuSaches.Add(new database.tuSach { TenSach = item.TenSach, LinkSach = item.TenSach, status = item.status });
                        }

                        break;

                }
                if (tV.SaveChanges() > 0)
                {
                    XtraMessageBox.Show("Lưu thành công!", "Thông báo");
                }
            }
        }
        private async void Save()
        {
            if (await CheckConditionSave())
            {
                switch (_form)
                {
                    case FormName.ThemMoiBaiViet:
                        foreach (var item in baiViets.Where(p => p.TenBaiViet != null && p.TenBaiViet != "" && p.ID_NhomSach != null))
                        {
                            tV.tbl_BaiViet.Add(new database.tbl_BaiViet { TenBaiViet = item.TenBaiViet, Link_voice = item.Link_voice, Link_ppt = item.Link_ppt, ID_NhomSach = item.ID_NhomSach, status = item.status });
                        }

                        break;
                    case FormName.ThemMoiNhom:
                        foreach (var item in NhomSaches.Where(p => p.TenNhomSach != null && p.TenNhomSach != ""))
                        {
                            tV.NhomSaches.Add(new database.NhomSach { TenNhomSach = item.TenNhomSach, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSinhVien:

                        foreach (var item in userLogins.Where(p => p.TenSinhVien != null && p.TenSinhVien != "" && p.Username != null && p.Username != "" && p.Password != null && p.Password != ""))
                        {

                            tV.UserLogins.Add(new database.UserLogin { Username = item.TenSinhVien, Password = commom.Commom.ThuchiencongViec.Md5(item.Password), TenSinhVien = item.TenSinhVien, isAdmin = item.isAdmin, status = item.status });
                        }

                        break;
                    case FormName.ThemMoiSach:
                        foreach (var item in Sachs.Where(p => p.TenSach != null && p.TenSach != "" && p.status != null))
                        {

                            tV.tuSaches.Add(new database.tuSach { TenSach = item.TenSach, LinkSach = item.LinkSach, status = item.status });
                        }

                        break;
                }
                if (tV.SaveChanges() > 0)
                {
                    XtraMessageBox.Show("Lưu thành công!", "Thông báo");
                }
            }
            else
            {
                XtraMessageBox.Show("Không thể lưu!", "Thông báo");
            }
        }

        private async Task<bool> CheckConditionSave()
        {
            bool kq = false;
            switch (_form)
            {
                case FormName.ThemMoiBaiViet:
                    kq = true;
                    break;
                case FormName.ThemMoiNhom:
                    kq = true;
                    break;
                case FormName.ThemMoiSinhVien:
                    Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
                    foreach (var item in userLogins.Where(p => p.TenSinhVien != null && p.TenSinhVien != "" && p.Username != null && p.Username != "" && p.Password != null && p.Password != ""))
                    {
                        if (tV.UserLogins.Where(p => p.Username == item.Username).Count() > 0)
                        {
                            keyValuePairs.Add(item.id, item.Username);
                        }
                    }
                    if (keyValuePairs.Count > 0)
                    {
                        var messengerbox = string.Join(" , ", keyValuePairs);
                        XtraMessageBox.Show($"Bạn không thể lưu khi có những sinh viên trùng username: {messengerbox}", "Thông báo");
                        kq = false;
                    }
                    else
                    {
                        kq = true;
                    }
                    break;
                case FormName.ThemMoiSach:
                    kq = true;
                    break;

            }
            return kq;

        }
    }
}
