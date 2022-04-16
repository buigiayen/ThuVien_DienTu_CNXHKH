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
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị nhóm", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            var Button_edit = new List<properties.Button_edit>();
            Button_edit.Add(new properties.Button_edit { colname = "TenNhomSach", buttonIndex = 0, NameButton = "btnDeleteGroupBook", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, Action = new Action(() => { DeleteGroupbook(); }) });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(Button_edit);
            grvDanhMuc.CellValueChanging += GrvDanhMuc_CellValueChanging;
        }

        private async void DeleteGroupbook()
        {
            if (grvDanhMuc.FocusedRowHandle > 0)
            {
                int IDBai = (int)grvDanhMuc.GetFocusedRowCellValue("IDNhomSach");
                database.NhomSach nhomSach = tV.NhomSaches.FirstOrDefault(p => p.IDNhomSach == IDBai);
                nhomSach.status = false;
                tV.SaveChanges();
                LoadDS(1);
            }
        }

        private void GrvDanhMuc_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (grvDanhMuc.FocusedRowHandle > 0)
            {
                int IDBai = (int)grvDanhMuc.GetFocusedRowCellValue("IDNhomSach");
                database.NhomSach nhomSach = tV.NhomSaches.Single(p => p.IDNhomSach == IDBai);
                if (e.Column.FieldName == "TenNhomSach")
                {
                    nhomSach.TenNhomSach = e.Value.ToString();
                }
                if (e.Column.FieldName == "status")
                {
                    nhomSach.status = (bool)e.Value;
                }

                tV.SaveChanges();
            }
        }

        private async void view_GridControl_BaiViet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcBaiViet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvBaiViet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã bài viết", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Bài viết", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File powerpoint", FieldName_Columns = "ID_File_PPT" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File Word", FieldName_Columns = "ID_FileWord" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File âm thanh", FieldName_Columns = "ID_File_Voice" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm bài", FieldName_Columns = "ID_NhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị bài viết", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
        
            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "IDNhomSach");
                columns_GridLookUpedit.Add("Nhóm", "TenNhomSach");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(tV.NhomSaches.Where(p => p.status == true).ToList(), new string[] { "ID_NhomSach" }, columns_GridLookUpedit, "IDNhomSach", "TenNhomSach");
            }

            {

                //word

                Dictionary<string, string> columns_GridLookUpedit1 = new Dictionary<string, string>();
                columns_GridLookUpedit1.Add("Mã", "ID");
                columns_GridLookUpedit1.Add("Tên file", "FileName");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_DOCX), new string[] { "ID_FileWord" }, columns_GridLookUpedit1, valueMember: "ID", DisplayFormat: "FileName");

                //PDF

                Dictionary<string, string> columns_GridLookUpedit2 = new Dictionary<string, string>();
                columns_GridLookUpedit2.Add("Mã", "ID");
                columns_GridLookUpedit2.Add("Tên file", "FileName");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_PPT), new string[] { "ID_File_PPT" }, columns_GridLookUpedit2, valueMember: "ID", DisplayFormat: "FileName");

                //PDF

                Dictionary<string, string> columns_GridLookUpedit3 = new Dictionary<string, string>();
                columns_GridLookUpedit3.Add("Mã", "ID");
                columns_GridLookUpedit3.Add("Tên file", "FileName");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_Voice), new string[] { "ID_File_Voice" }, columns_GridLookUpedit3, valueMember: "ID", DisplayFormat: "FileName");

                // Danh sách câu hỏi

                List<properties.Button_edit> btnDanhSachBaiThi = new List<properties.Button_edit>();
                btnDanhSachBaiThi.Add(new properties.Button_edit { buttonIndex = 0, colname = "TenBaiViet", NameButton = "btnDanhMucBaiThi", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, toolTip = "Danh sách bài thi", Action = new Action(() => showListbaiThi("id")) });
                btnDanhSachBaiThi.Add(new properties.Button_edit { buttonIndex = 1, colname = "TenBaiViet", NameButton = "btnTaiLieuThamKhao", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, toolTip = "Danh sách tham khảo", Action = new Action(() => ShowDSThamKhao("id")) });
                btnDanhSachBaiThi.Add(new properties.Button_edit { buttonIndex =  2,colname = "TenBaiViet", NameButton = "btnDeleteBook", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, Action = new Action(() => { Deletebook(); }) });
                
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(btnDanhSachBaiThi);

            }

            grvBaiViet.CellValueChanging += GrvBaiViet_CellValueChanging;

        }
        private async void Deletebook()
        {
            if (grvBaiViet.FocusedRowHandle > 0)
            {
                int IDBai = (int)grvBaiViet.GetFocusedRowCellValue("id");
                database.tbl_BaiViet BaiViet = tV.tbl_BaiViet.FirstOrDefault(p => p.id == IDBai);
                BaiViet.status = false;
                tV.SaveChanges();
                LoadDS(1);
            }
        }
        private void ShowDSThamKhao(string colName)
        {
            if (grvBaiViet.FocusedRowHandle >= 0)
            {
                int IDBaiViet = (int)grvBaiViet.GetFocusedRowCellValue(colName);
                frm_TaiLieuThamKhao frm = new frm_TaiLieuThamKhao(IDBaiViet);
                frm.ShowDialog();
            }


        }



        private async void GrvBaiViet_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvBaiViet.FocusedRowHandle >= 0)
            {
                int IDBai = (int)grvBaiViet.GetFocusedRowCellValue("id");
                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                if (e.Column.FieldName == "TenBaiViet")
                {
                    bv.TenBaiViet = e.Value.ToString();
                }
                if (e.Column.FieldName == "ID_FileWord")
                {
                    bv.ID_FileWord = (int?)e.Value;
                }
                if (e.Column.FieldName == "ID_File_PPT")
                {
                    bv.ID_File_PPT = (int?)e.Value;
                }
                if (e.Column.FieldName == "ID_File_Voice")
                {
                    bv.ID_File_Voice = (int?)e.Value;
                }
                if (e.Column.FieldName == "ID_NhomSach")
                {
                    bv.ID_NhomSach = (int?)e.Value;
                }
                if (e.Column.FieldName == "status")
                {
                    bv.status = (bool)e.Value;
                }
                tV.SaveChanges();

            }
        }

        private void showListbaiThi(string colname)
        {
            if (grvBaiViet.FocusedRowHandle >= 0)
            {
                int iDBaiViet = (int)grvBaiViet.GetFocusedRowCellValue(colname);
                frm_CauHoi frm = new frm_CauHoi(iDBaiViet);
                frm.ShowDialog();
            }

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
                    grcDanhMuc.DataSource = tV.NhomSaches.Where(p => p.status == true).ToList();
                    break;

                case 2:
                    grcBaiViet.DataSource = tV.tbl_BaiViet.Where(p => p.isTuSachVanKien == false && p.status == true ).ToList();
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


        private async void btnThemMoiNhom_Click(object sender, EventArgs e)
        {
            database.NhomSach nhomSach = new database.NhomSach();
            nhomSach.status = true;
            tV.NhomSaches.Add(nhomSach);
            tV.SaveChanges();
            LoadDS(1);
        }

        private async void btnThemMoiBaiViet_Click(object sender, EventArgs e)
        {
            database.tbl_BaiViet baiViet = new database.tbl_BaiViet();
            baiViet.TenBaiViet = "";
            baiViet.status = true;
            baiViet.isTuSachVanKien = false;
            tV.tbl_BaiViet.Add(baiViet);
            tV.SaveChanges();
            LoadDS(2);

        }

        private void grcBaiViet_Click(object sender, EventArgs e)
        {

        }
    }
}
