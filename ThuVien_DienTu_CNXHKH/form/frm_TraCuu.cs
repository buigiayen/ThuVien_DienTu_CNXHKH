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
    public partial class frm_TraCuu : DevExpress.XtraEditors.XtraForm
    {
        public frm_TraCuu()
        {
            InitializeComponent();
        }
        private database.TV data = new database.TV();

        private void frm_TraCuu_Load(object sender, EventArgs e)
        {
            LoadGridControl();
        }
        private async void LoadGridControl()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcTraCuuThuatNgu;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvTraCuuThuatNgu;

            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "id", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Thuật ngữ", FieldName_Columns = "ThuatNgu" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            grvTraCuuThuatNgu.Columns["id"].OptionsColumn.ReadOnly = true;
            grvTraCuuThuatNgu.CellValueChanging += GrvTraCuuThuatNgu_CellValueChanging;
        }
        private async void GrvTraCuuThuatNgu_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvTraCuuThuatNgu.RowCount > 0)
            {
                int id = (int)grvTraCuuThuatNgu.GetFocusedRowCellValue("id");
                database.TraCuuThuatNgu traCuu = data.TraCuuThuatNgus.SingleOrDefault(p => p.id == id);
                if (e.Column.FieldName == "ThuatNgu")
                {
                    traCuu.ThuatNgu = e.Value.ToString();
                }
                if (e.Column.FieldName == "status")
                {
                    traCuu.status = (bool)e.Value;
                }
            }

             data.SaveChanges();
        }
        private void btnReloadTraCuuThuatNgu_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadTraCuuThuaNgu);
        }
        private async void LoadTraCuuThuaNgu()
        {
            grcTraCuuThuatNgu.DataSource = await commom.Function.Instance.Get_TraCuuThuatNgu();
        }
        private async void btnThemMoiTraCuuThuatNgu_Click(object sender, EventArgs e)
        {
            database.TraCuuThuatNgu traCuu = new database.TraCuuThuatNgu();
            traCuu.status = false;
            data.TraCuuThuatNgus.Add(traCuu);
            await data.SaveChangesAsync();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadTraCuuThuaNgu);
        }
    }
}