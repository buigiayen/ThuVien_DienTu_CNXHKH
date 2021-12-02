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
    public partial class frm_TaiLieuThamKhao : DevExpress.XtraEditors.XtraForm
    {
        private int _idBaiViet;
        public frm_TaiLieuThamKhao(int idBaiViet)
        {
            InitializeComponent();
            _idBaiViet = idBaiViet;
            LoadGrid();
        }
        private database.TV data = new database.TV();
        private async void LoadGrid()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã", FieldName_Columns = "id", Visible = commom.Commom_static.isAdmin });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "idBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "File tham khảo", FieldName_Columns = "idFile" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trạng thái", FieldName_Columns = "status", Visible = commom.Commom_static.isAdmin });

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            showTenBai();
            {
                Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
                columns_GridLookUpedit.Add("Mã", "ID");
                columns_GridLookUpedit.Add("Nhóm", "FileName");
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(data.Files.ToList(), new string[] { "idFile" }, columns_GridLookUpedit, "ID", "FileName");
            }
            grvList.Columns["idBaiViet"].GroupIndex = 0;
            if (commom.Commom_static.isAdmin)
            {
                grvList.CellValueChanging += GrvList_CellValueChanging;
            }
        }

        private async void GrvList_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvList.FocusedRowHandle >= 0)
            {
                if (e.Column.FieldName == "idFile")
                {
                    int idTaiLieu = (int)grvList.GetFocusedRowCellValue("id");
                    database.TaiLieuThamKhao taiLieuThamKhao = data.TaiLieuThamKhaos.SingleOrDefault(p => p.id == idTaiLieu);
                    taiLieuThamKhao.idFile = (int)e.Value;
                    await data.SaveChangesAsync();
                }
            }
        }

        private void showTenBai()
        {
            Dictionary<string, string> columns_GridLookUpedit = new Dictionary<string, string>();
            columns_GridLookUpedit.Add("Mã", "id");
            columns_GridLookUpedit.Add("Nhóm", "TenBaiViet");
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemGridLookUpEdit(data.tbl_BaiViet.Where(p=>p.id == _idBaiViet).ToList(), new string[] { "idBaiViet" }, columns_GridLookUpedit, "id", "TenBaiViet");
        }
        private async void btnReload_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowTaiLieu);
        }
        private async void ShowTaiLieu()
        {
            grcList.DataSource = data.TaiLieuThamKhaos.Where(p => p.idBaiViet == _idBaiViet).ToList();
        }
        private async void simpleButton2_Click(object sender, EventArgs e)
        {
            database.TaiLieuThamKhao taiLieuThamKhao = new database.TaiLieuThamKhao();
            taiLieuThamKhao.status = false;
            taiLieuThamKhao.idBaiViet = _idBaiViet;
            data.TaiLieuThamKhaos.Add(taiLieuThamKhao);
            await data.SaveChangesAsync();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowTaiLieu);
            showTenBai();
        }

        private async void btnShowFile_Click(object sender, EventArgs e)
        {
            if (grvList.FocusedRowHandle >= 0)
            {
                int idFile = (int)grvList.GetFocusedRowCellValue("idFile");
                string filePath = await commom.Function.Instance.getFilePatd(idFile);
                if (!await commom.Common.ThuchiencongViec.process_Application(filePath))
                {
                    XtraMessageBox.Show("Không thể mở file");
                }

            }
        }

        private void frm_TaiLieuThamKhao_Load(object sender, EventArgs e)
        {
            btnThemMoi.Visible = commom.Commom_static.isAdmin;
        }
    }
}