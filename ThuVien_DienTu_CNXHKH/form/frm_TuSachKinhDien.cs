
using DevExpress.XtraEditors;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;
using static ThuVien_DienTu_CNXHKH.commom.Model;
using DevExpress.Pdf;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_TuSachKinhDien : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuSachKinhDien()
        {
            InitializeComponent();
            LoadGridControl_TuSachKinhDien();
        }
        private database.TV data = new database.TV();

        private async void LoadGridControl_TuSachKinhDien()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcNhomSach;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvNhomSach;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã nhóm ", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tủ sách ", FieldName_Columns = "TenTuSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã bài", FieldName_Columns = "IDBai", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "TenSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "LinkPDF", FieldName_Columns = "LinkPDF", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnViewGroupBook", toolTip = "Xem nhóm", Action = new Action(() => ShowViewBook("LinkPDF")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
                grvNhomSach.Columns["TenTuSach"].GroupIndex = 1;

            }
        }

        private async void ShowViewBook(string Colname)
        {
            if (!string.IsNullOrEmpty(Colname))
            {
                string LinkPDF = grvNhomSach.GetFocusedRowCellValue(Colname)?.ToString();
                if (!string.IsNullOrEmpty(LinkPDF))
                {
                    pdfViewer1.LoadDocument(LinkPDF);
                }
            }
        }


        private async void reload_Group_Book()
        {
            var datas = (from ns in data.TuSachKinhDiens
                         join ss in data.SachKinhDiens.Where(p => p.status == true) on ns.ID equals ss.IDNhomSachKinhDien
                         select new
                         {
                             ID = ns.ID,
                             TenTuSach = ns.TenTuSach,
                             IDBai = ss.IDNhomSachKinhDien,
                             TenSach = ss.TenBai,
                             LinkPDF = ss.linkPPT
                         }).ToList();
            grcNhomSach.DataSource = datas;
            grvNhomSach.ExpandAllGroups();
        }

        private void btnReloadall_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(reload_Group_Book);
        }

        private async void btnTimKiemToanTap_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(() => { FindKey(btnTimKiemToanTap.Text); }));
        }


        private async void FindKey(string text)
        {
            List<FindCheck> keyValuePairs = new List<FindCheck>();
            for (int i = 0; i < grvNhomSach.RowCount; i++)
            {

                string LinkPDF = grvNhomSach.GetRowCellValue(i, "LinkPDF")?.ToString();
                keyValuePairs.Add(new FindCheck
                {
                    Key = text,
                    Name = grvNhomSach.GetRowCellValue(i, "TenTuSach")?.ToString() + "-" + grvNhomSach.GetRowCellValue(i, "TenSach")?.ToString(),
                    Tep = grvNhomSach.GetRowCellValue(i, "LinkPDF")?.ToString(),
                    Vitri = "Dòng 1 trang 2",
                    Valid = await commom.Commom.ThuchiencongViec.GetTextFromPDF(LinkPDF,text)
                });

            }

        }
    }
}