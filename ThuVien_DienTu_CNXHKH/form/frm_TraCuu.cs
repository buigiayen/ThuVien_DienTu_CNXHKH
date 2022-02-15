using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
            LoadGridControl(grcTraCuuKinhDien, grvTraCuuKinhDien);
            LoadGridControl(grcTraCuuThuatNgu, grvTraCuuThuatNgu);
            btnThemMoiTraCuuThuatNgu.Visible = commom.Commom_static.isAdmin;
            btnThemMoiTraCuuKinhDien.Visible = commom.Commom_static.isAdmin;
        }
        private async void LoadGridControl(DevExpress.XtraGrid.GridControl gridControl, GridView gridView)
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = gridControl;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = gridView;

            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "id", Visible = commom.Commom_static.isAdmin });
            if (gridControl == grcTraCuuThuatNgu)
            {
                columnsproperties.Add(new properties.columns { Caption_Columns = "Thuật ngữ", FieldName_Columns = "MoTaThuatNgu" });
            }
            columnsproperties.Add(new properties.columns { Caption_Columns = "Giải ngữ", FieldName_Columns = "ThuatNgu", Visible = commom.Commom_static.isAdmin ? true : gridControl == grcTraCuuThuatNgu ? false : true  });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Hiển thị", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemMemoEdit(new string[] { "ThuatNgu" });
            {
                List<properties.Button_edit> button_Edits = new List<properties.Button_edit>();
                button_Edits.Add(new properties.Button_edit
                {
                    buttonIndex = 0,
                    colname = gridControl == grcTraCuuThuatNgu ? "MoTaThuatNgu" : "ThuatNgu",
                    toolTip = "Xem thuật ngữ",
                    NameButton = "btnViewThuatNgu",
                    styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search,
                    Action = new Action(() => { TextView(gridView); })
                });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            gridView.Columns["id"].OptionsColumn.ReadOnly = true;
            if (gridControl == grcTraCuuKinhDien)
                grvTraCuuKinhDien.CellValueChanging += GrvTraCuuKinhDien_CellValueChanging;
            if (gridControl == grcTraCuuThuatNgu)
                grvTraCuuThuatNgu.CellValueChanging += GrvTraCuuThuatNgu_CellValueChanging;

        }

        private void TextView(GridView gridView)
        {
            string viewTexts = gridView.GetFocusedRowCellValue("ThuatNgu").ToString();
            form.ViewText viewText = new ViewText(viewTexts);
            viewText.Show();
        }

        private async void GrvTraCuuThuatNgu_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            changeData(grvTraCuuThuatNgu, e);
        }
        private void btnReloadTraCuuThuatNgu_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadTraCuuThuatNgu);
        }
        private async void LoadTraCuuThuatNgu()
        {

            grcTraCuuThuatNgu.DataSource = await commom.Function.Instance.Get_TraCuu(0);
        }
        private async void btnThemMoiTraCuuThuatNgu_Click(object sender, EventArgs e)
        {
            saveData(0);
        }
        private async void LoadTraCuuKinhDien()
        {
            grcTraCuuKinhDien.DataSource = await commom.Function.Instance.Get_TraCuu(1);
        }
        private void btnLoadTraCuuKinhDien_Click(object sender, EventArgs e)
        {
            LoadTraCuuKinhDien();
        }
        private async void saveData(int PhanLoai = 0)
        {
            database.TraCuuThuatNgu traCuu = new database.TraCuuThuatNgu();
            traCuu.status = false;
            traCuu.PhanLoai = PhanLoai;
            data.TraCuuThuatNgus.Add(traCuu);
            await data.SaveChangesAsync();
            switch (PhanLoai)
            {
                case 0:
                    Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadTraCuuThuatNgu);
                    break;
                case 1:
                    Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadTraCuuKinhDien);
                    break;
            }

        }
        private void btnThemMoiTraCuuKinhDien_Click(object sender, EventArgs e)
        {
            saveData(1);
        }
        private void GrvTraCuuKinhDien_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            changeData(grvTraCuuKinhDien, e);
        }
        private async void changeData(GridView gridView, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gridView.FocusedRowHandle >= 0)
            {
                int id = (int)gridView.GetFocusedRowCellValue("id");
                database.TraCuuThuatNgu traCuu = data.TraCuuThuatNgus.SingleOrDefault(p => p.id == id);
                if (e.Column.FieldName == "ThuatNgu")
                {
                    traCuu.ThuatNgu = e.Value.ToString();
                }
                if (e.Column.FieldName == "MoTaThuatNgu")
                {
                    traCuu.MoTaThuatNgu = e.Value.ToString();
                }
                if (e.Column.FieldName == "status")
                {
                    traCuu.status = (bool)e.Value;
                }
            }
            data.SaveChanges();
        }
    }
}