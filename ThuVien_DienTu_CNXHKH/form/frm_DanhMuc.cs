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
    public partial class frm_DanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }
        database.TV tV = new database.TV();
        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
            view_GridControl_DanhMuc();
            view_GridControl_BaiViet();
        }
        private async void view_GridControl_DanhMuc()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcDanhMuc;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvDanhMuc;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã nhóm", FieldName_Columns = "IDNhomSach", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên nhóm", FieldName_Columns = "TenNhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị nhóm", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
        }
        private async void view_GridControl_BaiViet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcBaiViet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvBaiViet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã bài viết", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài viết", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Đường dẫn file", FieldName_Columns = "Link_ppt" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Đường dẫn âm thanh", FieldName_Columns = "Link_voice" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm bài", FieldName_Columns = "ID_NhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị bài viết", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "IDNhomSach");
                columns_GridLookUpedit.Add("Nhóm", "TenNhomSach");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(tV.NhomSaches.ToList(), new string[] { "ID_NhomSach" }, columns_GridLookUpedit, "IDNhomSach", "TenNhomSach");

            }

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
                    grvBaiViet_CellValueChanging(null, new DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs(grvDanhMuc.FocusedRowHandle, gridColumn, openFileDialog.FileName));
                    Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new
                   Action(() => { LoadDS(2); }));
                }

            }
        }

        private void themMoi_BaiViet(Form_Panel.FormName forms)
        {
            form.Form_Panel form = new Form_Panel(forms, "Thêm mới bài viết");
            form.ShowDialog();

        }
        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new
                 Action(() => { LoadDS(1); }));
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new
                Action(() => { LoadDS(2); }));
        }
        private async void LoadDS(int value)
        {
            switch (value)
            {
                case 1:
                    grcDanhMuc.DataSource = tV.NhomSaches.ToList();
                    break;

                case 2:
                    grcBaiViet.DataSource = tV.tbl_BaiViet.ToList();
                    break;
            }
        }
        private void grvDanhMuc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int ID = (int)grvDanhMuc.GetFocusedRowCellValue("IDNhomSach");
                if (e.Column.FieldName == "status")
                {
                    database.NhomSach nhom = tV.NhomSaches.Single(p => p.IDNhomSach == ID);
                    nhom.status = (bool)e.Value;
                }
                if (e.Column.FieldName == "TenNhomSach")
                {
                    database.NhomSach nhom = tV.NhomSaches.Single(p => p.IDNhomSach == ID);
                    nhom.TenNhomSach = e.Value.ToString();
                }
                tV.SaveChanges();
              
            }
        }


        private void btnThemMoiNhom_Click(object sender, EventArgs e)
        {
            themMoi_BaiViet(Form_Panel.FormName.ThemMoiNhom);
        }

        private void btnThemMoiBaiViet_Click(object sender, EventArgs e)
        {
            themMoi_BaiViet(Form_Panel.FormName.ThemMoiBaiViet);

        }

        private void grvBaiViet_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
     {
            int IDBai = (int)grvBaiViet.GetFocusedRowCellValue("id");
            if (e.Column.FieldName == "TenBaiViet")
            {
                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.TenBaiViet = e.Value.ToString();
            }
            if (e.Column.FieldName == "Link_ppt")
            {

                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.Link_ppt = e.Value.ToString();
            }
            if (e.Column.FieldName == "Link_voice")
            {

                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.Link_voice = e.Value.ToString();
            }
            if (e.Column.FieldName == "ID_NhomSach")
            {

                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.ID_NhomSach = (int)e.Value;
            }
            if (e.Column.FieldName == "status")
            {
                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.status = (bool)e.Value;
            }
            tV.SaveChanges();
            
        }
    }
}
