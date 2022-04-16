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
    public partial class frm_DanhMucTuSachVanKien : DevExpress.XtraEditors.XtraForm
    {
        public frm_DanhMucTuSachVanKien()
        {
            InitializeComponent();
        }
        database.TV tV = new database.TV();
        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
            view_GridControl_BaiViet();
        }


        private async void view_GridControl_BaiViet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcBaiViet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvBaiViet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã bài viết", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Bài viết", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File văn kiện", FieldName_Columns = "ID_File_PDF" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị bài viết", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);

            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                //word

                //PDF 
                {
                    Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_PDF), new string[] { "ID_File_PDF" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
                }

                // Danh sách câu hỏi
                {
                    List<properties.Button_edit> btnDanhSachBaiThi = new List<properties.Button_edit>();
                    btnDanhSachBaiThi.Add(new properties.Button_edit { buttonIndex = 0, colname = "TenBaiViet", NameButton = "btnDanhMucBaiThi", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, toolTip = "Danh sách bài thi", Action = new Action(() => showListbaiThi("id")) });
                    btnDanhSachBaiThi.Add(new properties.Button_edit { buttonIndex = 1, colname = "TenBaiViet", NameButton = "btnDelete", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, toolTip = "Xóa bài", Action = new Action(() => delelebook()) });
                    Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(btnDanhSachBaiThi);
                }
            }

            grvBaiViet.CellValueChanging += GrvBaiViet_CellValueChanging;

        }

        private async void delelebook()
        {
            if (grvBaiViet.FocusedRowHandle >= 0)
            {
                int IDBai = (int)grvBaiViet.GetFocusedRowCellValue("id");
                database.tbl_BaiViet bv = tV.tbl_BaiViet.Single(p => p.id == IDBai);
                bv.status = false;
                tV.SaveChanges();
                LoadDS();
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
                if (e.Column.FieldName == "ID_File_PDF")
                {
                    bv.ID_File_PDF = (int?)e.Value;
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
                Action(() => { LoadDS(); }));
        }
        private async void LoadDS()
        {
            grcBaiViet.DataSource = tV.tbl_BaiViet.Where(p => p.isTuSachVanKien == true && p.status == true).ToList();
        }

        private async void btnThemMoiBaiViet_Click(object sender, EventArgs e)
        {
            database.tbl_BaiViet baiViet = new database.tbl_BaiViet();
            baiViet.status = true;
            baiViet.isTuSachVanKien = true;
            baiViet.TenBaiViet = "";
            tV.tbl_BaiViet.Add(baiViet);
            await tV.SaveChangesAsync();
            LoadDS();

        }


    }
}
