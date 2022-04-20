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
    public partial class Frm_NhomSachKinhDien : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhomSachKinhDien()
        {
            InitializeComponent();

        }
        private database.TV data = new database.TV();
        private void LoadNhomSach()
        {
            grcNhomSachKinhDien.DataSource = data.TuSachKinhDiens.Where(p=>p.status == true).ToList();
            grvNhomSachKinhDien.OptionsBehavior.Editable = false;
            grcSachKinhDien.DataSource = data.SachKinhDiens.Where(p => p.status == true).ToList();
            grvSachKinhDien.OptionsBehavior.Editable = false;
        }
        private void Frm_NhomSachKinhDien_Load(object sender, EventArgs e)
        {
            LoadGridControl_TuSachKinhDien_Nhom();
            LoadGridControl_TuSachKinhDien_Sach();
        }
        private async void LoadGridControl_TuSachKinhDien_Nhom()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcNhomSachKinhDien;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvNhomSachKinhDien;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tủ sách", FieldName_Columns = "TenTuSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                var button_Edits = new List<properties.Button_edit>();
                button_Edits.Add(new properties.Button_edit { colname = "TenTuSach", buttonIndex = 0 , styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, NameButton = "btnDeleteGroup", toolTip = "Xóa", Action = new Action(() => { Deletegroup(); })  });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
        }

        private async void Deletegroup()
        {
            if (await commom.Common.GetInstance().XtraMessageBoxQuestion() == DialogResult.OK)
            {
                if (grvNhomSachKinhDien.FocusedRowHandle >= 0)
                {
                    int _ID = (int)grvSachKinhDien.GetFocusedRowCellValue("ID");
                    database.SachKinhDien SachKinhDien = data.SachKinhDiens.SingleOrDefault(p => p.ID == _ID);
                    SachKinhDien.status = false;
                    data.SaveChanges();
                }
                LoadNhomSach();
            }    
             
        }

        private async void LoadGridControl_TuSachKinhDien_Sach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcSachKinhDien;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvSachKinhDien;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm sách", FieldName_Columns = "IDNhomSachKinhDien" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Sách", FieldName_Columns = "TenBai" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link bài", FieldName_Columns = "link_File" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            Dictionary<string, string> columns_GridLookUpedit;
            //PDF
            {
                columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Tên file", "FileName");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(await Function.Instance.getfile(commom.Commom_static.File_PDF), new string[] { "link_File" }, columns_GridLookUpedit, valueMember: "ID", DisplayFormat: "FileName");
            }
            {
                columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Nhóm", "TenTuSach");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(data.TuSachKinhDiens.ToList(), new string[] { "IDNhomSachKinhDien" }, columns_GridLookUpedit, "ID", "TenTuSach");
            }
            {
                var button_Edits = new List<properties.Button_edit>();
                button_Edits.Add(new properties.Button_edit { colname = "TenBai", buttonIndex = 0, styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, NameButton = "btnDelete", toolTip = "Xóa", Action = new Action(() => { DeleteBookgroup(); }) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            grvSachKinhDien.Columns["IDNhomSachKinhDien"].GroupIndex = 0;
            grvSachKinhDien.CellValueChanging += GrvSachKinhDien_CellValueChanging;
        }

        private async  void DeleteBookgroup()
        {
            if (await commom.Common.GetInstance().XtraMessageBoxQuestion() == DialogResult.OK)
            {
                if (grvSachKinhDien.FocusedRowHandle >= 0)
                {
                    int _ID = (int)grvSachKinhDien.GetFocusedRowCellValue("ID");
                    database.TuSachKinhDien TuSachKinhDien = data.TuSachKinhDiens.SingleOrDefault(p => p.ID == _ID);
                    TuSachKinhDien.status = false;
                    data.SaveChanges();
                }
                LoadNhomSach();
            }
               
        }

        private async void GrvSachKinhDien_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int _ID = (int)grvSachKinhDien.GetFocusedRowCellValue("ID");
                database.SachKinhDien SachKinhDien = data.SachKinhDiens.SingleOrDefault(p => p.ID == _ID);
                if (e.Column.FieldName == "IDNhomSachKinhDien")
                {
                    SachKinhDien.IDNhomSachKinhDien = (int)e.Value;
                }
                if (e.Column.FieldName == "TenBai")
                {
                    SachKinhDien.TenBai = e.Value.ToString();
                }
                if (e.Column.FieldName == "link_File")
                {
                    SachKinhDien.link_File = (int)e.Value;
                }
                if (e.Column.FieldName == "status")
                {
                    SachKinhDien.status = (bool)e.Value;
                }
                data.SaveChanges();
            }
            LoadNhomSach();
        }

        private void grvList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int _ID = (int)grvNhomSachKinhDien.GetFocusedRowCellValue("ID");
                database.TuSachKinhDien tuSachKinhDiens = data.TuSachKinhDiens.SingleOrDefault(p => p.ID == _ID);
                if (e.Column.FieldName == "TenTuSach")
                {
                    tuSachKinhDiens.TenTuSach = e.Value.ToString();
                }
                if (e.Column.FieldName == "status")
                {
                    tuSachKinhDiens.status = (bool)e.Value;
                }
                data.SaveChanges();
            }
            LoadNhomSach();
        }

        private void btnEditGroupBook_Click(object sender, EventArgs e)
        {
            if (btnEditGroupBook.Text.Contains("Sửa"))
            {
                btnEditGroupBook.Text = "Tắt sửa!";
                grvSachKinhDien.OptionsBehavior.Editable = grvNhomSachKinhDien.OptionsBehavior.Editable = true;
            }
            else
            {
                btnEditGroupBook.Text = "Sửa";
                grvSachKinhDien.OptionsBehavior.Editable = grvNhomSachKinhDien.OptionsBehavior.Editable = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadNhomSach);
        }

        private void btnThemMoiNhomSachKinhDien_Click(object sender, EventArgs e)
        {
            Form_Panel form_Panel = new Form_Panel(Form_Panel.FormName.ThemMoiNhomSachKinhDien, "Thêm mới nhóm tủ sách kinh điển");
            form_Panel.ShowDialog();

        }

        private void btnThemMoiSachKinhDien_Click(object sender, EventArgs e)
        {
            Form_Panel form_Panel = new Form_Panel(Form_Panel.FormName.ThemMoiSachKinhDien, "Thêm mới tủ sách kinh điển");
            form_Panel.ShowDialog();
        }
    }
}