
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
using ThuVien_DienTu_CNXHKH.commom;
using System.Threading;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_TuSachKinhDien : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuSachKinhDien()
        {
            InitializeComponent();
            LoadTuSach();
            LoadGridControl_TuSachKinhDien();
        }
        private database.TV data = new database.TV();
        private async void LoadTuSach()
        {
            lupTuSachKinhDien.Properties.DataSource = data.TuSachKinhDiens.Where(p => p.status == true).ToList();

        }
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
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trang", FieldName_Columns = "ViTri", Visible = false });

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnViewGroupBook", toolTip = "Xem nhóm", Action = new Action(() => ShowViewBook("LinkPDF")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
                grvNhomSach.Columns["TenTuSach"].GroupIndex = 1;
            }

            grvNhomSach.OptionsBehavior.ReadOnly = true;
        }
        private async void ShowViewBook(string Colname, int? Page = null)
        {
            if (!string.IsNullOrEmpty(Colname))
            {
                string filePath = await commom.Function.Instance.getFilePatd(Convert.ToInt32(grvNhomSach.GetFocusedRowCellValue(Colname)?.ToString()));
                pdfViewer1.LoadDocument(filePath);
                if (Page != null)
                {
                    pdfViewer1.CurrentPageNumber = Convert.ToInt32(Page);
                    pdfViewer1.FindText(btnTimKiemToanTap.Text);
                    grvNhomSach.Columns["TenTuSach"].GroupIndex = 1;
                }
            }
        }
        private async void reload_Group_Book()
        {
            int IDTuSach = -1;
            if (lupTuSachKinhDien.EditValue != null)
            {
                IDTuSach = (int)lupTuSachKinhDien.EditValue;
            }
            List<Model.Books> datas = (from ns in data.TuSachKinhDiens.Where(p => IDTuSach == -1 ? true : p.ID == IDTuSach)
                                       join ss in data.SachKinhDiens.Where(p => p.status == true) on ns.ID equals ss.IDNhomSachKinhDien
                                       select new Model.Books
                                       {
                                           ID = ns.ID,
                                           TenTuSach = ns.TenTuSach,
                                           IDBai = ss.IDNhomSachKinhDien,
                                           TenSach = ss.TenBai,
                                           LinkPDF = ss.link_File,
                                           ViTri = 0
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
            grvNhomSach.ExpandAllGroups();
            grvNhomSach.Columns["ViTri"].Visible = true;
            grvNhomSach.Columns["TenSach"].GroupIndex = 2;
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "ViTri", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnViewPageBook", toolTip = "Chuyển đến trang", Action = new Action(() => ShowViewBook("LinkPDF", (int)grvNhomSach.GetFocusedRowCellValue("ViTri"))) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }

            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(() => { FindKey(btnTimKiemToanTap.Text); }));


        }


        private async void FindKey(string text)
        {
            if (!string.IsNullOrEmpty(text) && grvNhomSach.RowCount >= 0)
            {
                var dataList = (List<Model.Books>)grcNhomSach.DataSource;
                grcNhomSach.DataSource = null;
                grcNhomSach.DataSource = await commom.Common.GetInstance().GetContextFromPDF(dataList.Where(p=>p.LinkPDF != null).ToList(), text);
            }

        }

        private void lupTuSachKinhDien_EditValueChanged(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(reload_Group_Book);
        }
    }
}