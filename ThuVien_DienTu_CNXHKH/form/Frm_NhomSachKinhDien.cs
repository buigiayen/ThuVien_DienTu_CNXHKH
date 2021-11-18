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
    public partial class Frm_NhomSachKinhDien : DevExpress.XtraEditors.XtraForm
    {
        public Frm_NhomSachKinhDien()
        {
            InitializeComponent();
            
        }

      

        private database.TV data = new database.TV();

        private void LoadNhomSach()
        {
            grcNhomSachKinhDien.DataSource = data.TuSachKinhDiens.ToList();
            grvNhomSachKinhDien.OptionsBehavior.Editable = false;
            grcSachKinhDien.DataSource = data.SachKinhDiens.ToList();
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
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
        }
        private async void LoadGridControl_TuSachKinhDien_Sach()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcSachKinhDien;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvSachKinhDien;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Nhóm sách", FieldName_Columns = "IDNhomSachKinhDien" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Sách", FieldName_Columns = "TenBai" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Link bài", FieldName_Columns = "linkPPT" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
            columns_GridLookUpedit.Add("Mã", "ID");
            columns_GridLookUpedit.Add("Nhóm", "TenTuSach");
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "linkPPT", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnUploadFile", toolTip = "upload File", Action = new Action(() => OpenSaveFile(1, "linkPPT")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(data.TuSachKinhDiens.ToList(), new string[] { "IDNhomSachKinhDien" }, columns_GridLookUpedit, "ID", "TenTuSach");
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
        private void grvList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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
      
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form_Panel form_Panel = new Form_Panel(Form_Panel.FormName.ThemMoiNhomSachKinhDien, "Thêm mới nhóm tủ sách kinh điển");
            form_Panel.ShowDialog();
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

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            Form_Panel form_Panel = new Form_Panel(Form_Panel.FormName.ThemMoiSachKinhDien, "Thêm mới tủ sách kinh điển");
            form_Panel.ShowDialog();
        }
    }
}