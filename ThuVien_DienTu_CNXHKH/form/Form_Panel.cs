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
using ThuVien_DienTu_CNXHKH.commom;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class Form_Panel : DevExpress.XtraEditors.XtraForm
    {
        private FormName _form;

        public Form_Panel(FormName formName, string _NameForm)
        {
            InitializeComponent();
            _form = formName;

            this.Text = _NameForm;
        }

        public enum FormName
        {
            ThemMoiBaiViet = 0x0000,
            ThemMoiNhom = 0X0001,
            ThemMoiSinhVien = 0X0002,
            ThemMoiSach = 0X0003,
            ThemMoiNhomSachKinhDien = 0X0004,
            ThemMoiSachKinhDien = 0X0005,
        }
        private List<database.NhomSach> NhomSaches = new List<database.NhomSach>();
        private List<database.UserLogin> userLogins = new List<database.UserLogin>();
        private List<database.tbl_BaiViet> baiViets = new List<database.tbl_BaiViet>();
        private List<database.tuSach> Sachs = new List<database.tuSach>();
        private List<database.TuSachKinhDien> tuSachKinhDiens = new List<database.TuSachKinhDien>();
        private List<database.SachKinhDien> SachKinhDiens = new List<database.SachKinhDien>();
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
                case FormName.ThemMoiNhomSachKinhDien:
                    LoadGridControl_TuSachKinhDien_Nhom();
                    break;
                case FormName.ThemMoiSachKinhDien:
                    LoadGridControl_TuSachKinhDien_Sach();
                    break;

            }

        }
        private database.TV tV = new database.TV();
        private async void Load_GridControl_ThemMoiBaiViet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File powerpoint", FieldName_Columns = "ID_File_PPT" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File Word", FieldName_Columns = "ID_FileWord" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File âm thanh", FieldName_Columns = "ID_File_Voice" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm bài viết", FieldName_Columns = "ID_NhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties, true);
            // nhóm 
            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "IDNhomSach");
                columns_GridLookUpedit.Add("Nhóm", "TenNhomSach");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(tV.NhomSaches.ToList(), new string[] { "ID_NhomSach" }, columns_GridLookUpedit, "IDNhomSach", "TenNhomSach");
            }

            // File
            {
                //word
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                columns_GridLookUpedit.Add("Đường dẫn", "FilePath");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_DOCX), new string[] { "ID_FileWord" }, columns_GridLookUpedit,valueMember : "ID", DisplayFormat : "FileName");
            }
            // File
            {
                //PDF
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                columns_GridLookUpedit.Add("Đường dẫn", "FilePath");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_PPT), new string[] { "ID_File_PPT" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
            }
            // File
            {
                //PDF
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                columns_GridLookUpedit.Add("Đường dẫn", "FilePath");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_Voice), new string[] { "ID_File_Voice" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
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

        private async void LoadGridControl_TuSachKinhDien_Nhom()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tủ sách ", FieldName_Columns = "TenTuSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái ", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            ForList();
            grcList.DataSource = new BindingList<database.TuSachKinhDien>(tuSachKinhDiens.ToList());
        }

        private async void LoadGridControl_TuSachKinhDien_Sach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Bài", FieldName_Columns = "TenBai" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tủ sách", FieldName_Columns = "IDNhomSachKinhDien" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link PPT", FieldName_Columns = "link_File" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);

            {
                //PDF
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                columns_GridLookUpedit.Add("Đường dẫn", "FilePath");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_PPT), new string[] { "link_File" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
            }
         
            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Nhóm", "TenTuSach");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(tV.TuSachKinhDiens.ToList(), new string[] { "IDNhomSachKinhDien" }, columns_GridLookUpedit, "ID", "TenTuSach");
            }
            ForList();
            grcList.DataSource = new BindingList<database.SachKinhDien>(SachKinhDiens.ToList());
        }

        private async void ForList()
        {
            for (int i = 0; i < 100; i++)
            {
                switch (_form)
                {
                    case FormName.ThemMoiBaiViet:
                        baiViets.Add(new database.tbl_BaiViet { id = i, status = false });
                        break;
                    case FormName.ThemMoiNhom:
                        NhomSaches.Add(new database.NhomSach { IDNhomSach = i, status = false });
                        break;
                    case FormName.ThemMoiSinhVien:
                        userLogins.Add(new database.UserLogin { id = i, isAdmin = false, status = false });
                        break;
                    case FormName.ThemMoiSach:
                        Sachs.Add(new database.tuSach { ID = i, status = false });
                        break;
                    case FormName.ThemMoiNhomSachKinhDien:
                        tuSachKinhDiens.Add(new database.TuSachKinhDien { ID = i, status = false });
                        break;
                    case FormName.ThemMoiSachKinhDien:
                        SachKinhDiens.Add(new database.SachKinhDien { ID = i, IDNhomSachKinhDien = null, status = false });
                        break;

                }

            }
        }
        private void OpenSaveFile(int value, string nameFiled)
        {
            XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog();
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
                            tV.tbl_BaiViet.Add(new database.tbl_BaiViet { TenBaiViet = item.TenBaiViet, ID_File_Voice = item.ID_File_Voice, ID_File_PPT = item.ID_File_PPT, ID_FileWord = item.ID_FileWord ,ID_NhomSach = item.ID_NhomSach, status = item.status });
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
                            tV.UserLogins.Add(new database.UserLogin { Username = item.TenSinhVien, Password = commom.Common.GetInstance().Md5(item.Password), TenSinhVien = item.TenSinhVien, isAdmin = item.isAdmin, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSach:
                        foreach (var item in Sachs.Where(p => p.ID == items && p.TenSach != null && p.TenSach != "" && p.status != null))
                        {
                            tV.tuSaches.Add(new database.tuSach { TenSach = item.TenSach, ID_File = item.ID_File, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiNhomSachKinhDien:
                        foreach (var item in tuSachKinhDiens.Where(p => p.ID == items && p.TenTuSach != null && p.TenTuSach != "" && p.status != null))
                        {

                            tV.TuSachKinhDiens.Add(new database.TuSachKinhDien { TenTuSach = item.TenTuSach, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSachKinhDien:
                        foreach (var item in SachKinhDiens.Where(p => p.ID == items && p.TenBai != null && p.TenBai != "" && p.status != null && p.IDNhomSachKinhDien != null))
                        {
                            tV.SachKinhDiens.Add(new database.SachKinhDien { TenBai = item.TenBai, status = item.status, IDNhomSachKinhDien = item.IDNhomSachKinhDien, link_File = item.link_File });
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
                            tV.tbl_BaiViet.Add(new database.tbl_BaiViet { TenBaiViet = item.TenBaiViet, ID_File_Voice = item.ID_File_Voice, ID_File_PPT = item.ID_File_PPT, ID_FileWord = item.ID_FileWord , ID_NhomSach = item.ID_NhomSach, status = item.status });
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

                            tV.UserLogins.Add(new database.UserLogin { Username = item.TenSinhVien, Password = commom.Common.GetInstance().Md5(item.Password), TenSinhVien = item.TenSinhVien, isAdmin = item.isAdmin, status = item.status });
                        }

                        break;
                    case FormName.ThemMoiSach:
                        foreach (var item in Sachs.Where(p => p.TenSach != null && p.TenSach != "" && p.status != null))
                        {

                            tV.tuSaches.Add(new database.tuSach { TenSach = item.TenSach, ID_File = item.ID_File, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiNhomSachKinhDien:
                        foreach (var item in tuSachKinhDiens.Where(p => p.TenTuSach != null && p.TenTuSach != "" && p.status != null))
                        {

                            tV.TuSachKinhDiens.Add(new database.TuSachKinhDien { TenTuSach = item.TenTuSach, status = item.status });
                        }
                        break;
                    case FormName.ThemMoiSachKinhDien:
                        foreach (var item in SachKinhDiens.Where(p => p.TenBai != null && p.TenBai != "" && p.status != null && p.IDNhomSachKinhDien != null))
                        {
                            tV.SachKinhDiens.Add(new database.SachKinhDien { TenBai = item.TenBai, status = item.status, IDNhomSachKinhDien = item.IDNhomSachKinhDien, link_File = item.link_File });
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
                case FormName.ThemMoiSachKinhDien:
                    kq = true;
                    break;
                case FormName.ThemMoiNhomSachKinhDien:
                    kq = true;
                    break;
            }
            return kq;

        }
    }
}
