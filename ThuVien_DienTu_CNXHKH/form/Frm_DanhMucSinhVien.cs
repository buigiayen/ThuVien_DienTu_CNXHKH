﻿using DevExpress.XtraEditors;
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
    public partial class Frm_DanhMucSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DanhMucSinhVien()
        {
            InitializeComponent();
            showGridControl_DSSinhVien();
        }
        database.TV tV = new database.TV();
        private void showGridControl_DSSinhVien()
        {

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcDanhSachSinhVien;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvDanhSachSinhVien;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã sinh viên", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên đăng nhập", FieldName_Columns = "Username" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên sinh viên", FieldName_Columns = "TenSinhVien" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Quyền admin", FieldName_Columns = "isAdmin" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Sử dụng", FieldName_Columns = "status" });

            List<properties.Button_edit> listButton = new List<properties.Button_edit>();
            listButton.Add(new properties.Button_edit { buttonIndex = 0, colname = "Username", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, Action = ShowChangePassword });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(listButton);
        }

        private void ShowChangePassword()
        {
            int UserID =(int)grvDanhSachSinhVien.GetFocusedRowCellValue("id");
            string UserName = grvDanhSachSinhVien.GetFocusedRowCellValue("Username").ToString();
            frm_ChangePassword frm = new frm_ChangePassword(UserID, UserName);
            frm.ShowDialog();
        }

        private void btnTaiDanhSach_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadDSSinHVien);

        }
        private void LoadDSSinHVien()
        {
            grcDanhSachSinhVien.DataSource = tV.UserLogins.ToList();
        }
        private void btnThemMoiSinhVien_Click(object sender, EventArgs e)
        {
            Form_Panel frm = new Form_Panel(Form_Panel.FormName.ThemMoiSinhVien, "Thêm mới user");
            frm.ShowDialog();
        }
    }
}