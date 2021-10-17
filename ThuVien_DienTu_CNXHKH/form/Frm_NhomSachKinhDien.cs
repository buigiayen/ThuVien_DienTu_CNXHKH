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
        private void btnThemMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form_Panel form_Panel = new Form_Panel(Form_Panel.FormName.ThemMoiNhomSachKinhDien,"Thêm mới nhóm tủ sách kinh điển");
            form_Panel.ShowDialog();
        }

        private void btnTaiDanhSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadNhomSach);
        }
        private void LoadNhomSach()
        {
            grcList.DataSource = data.TuSachKinhDiens.ToList();
            grvList.OptionsBehavior.Editable = false;
        }
      
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Caption.Contains("Sửa"))
            {
                btnSua.Caption = "Tắt sửa!";
                grvList.OptionsBehavior.Editable = true;
            }
            else
            {
                btnSua.Caption = "Sửa";
                grvList.OptionsBehavior.Editable = false;
            }
        }

        private void Frm_NhomSachKinhDien_Load(object sender, EventArgs e)
        {
            LoadGridControl_TuSachKinhDien_Nhom();
        }
        private async void LoadGridControl_TuSachKinhDien_Nhom()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tủ sách", FieldName_Columns = "TenTuSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
        }

        private void grvList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int _ID = (int)grvList.GetFocusedRowCellValue("ID");
            database.TuSachKinhDien tuSachKinhDiens = data.TuSachKinhDiens.SingleOrDefault(p=>p.ID == _ID);
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
    }
}