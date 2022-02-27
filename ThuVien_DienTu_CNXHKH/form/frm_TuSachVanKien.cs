
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
using DevExpress.XtraPdfViewer;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_TuSachVanKien : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuSachVanKien()
        {
            InitializeComponent();
           
            LoadGridControl_TuSachKinhDien();
            btnThiVanKien.Enabled = false;
        }
        private database.TV data = new database.TV();
       
        private async void LoadGridControl_TuSachKinhDien()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcNhomSach;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvNhomSach;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã nhóm ", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Sách ", FieldName_Columns = "TenTuSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "LinkPDF", FieldName_Columns = "LinkPDF", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trang", FieldName_Columns = "TrangHienThi", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Trang", FieldName_Columns = "ViTri", Visible = false });

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenTuSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnViewGroupBook", toolTip = "Xem nhóm", Action = new Action(() => ShowViewBook("LinkPDF")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
             
            }
          
            grvNhomSach.OptionsBehavior.ReadOnly = true;
        }
        private async void ShowViewBook(string Colname, int Page = -1)
        {
            if (!string.IsNullOrEmpty(Colname))
            {
                string FilePath = commom.Function.Instance.getFilePatd(Convert.ToInt32(grvNhomSach.GetFocusedRowCellValue(Colname)?.ToString())).Result;
                if (!string.IsNullOrEmpty(FilePath))
                {
                    pdfViewer1.LoadDocument(FilePath);
                    if (Page != -1)
                    {
                        pdfViewer1.CurrentPageNumber = Page;
                        PdfFindDialogOptions pdfFindDialogOptions = new PdfFindDialogOptions(btnTimKiemToanTap.Text, false, false);
                        pdfViewer1.FindText(btnTimKiemToanTap.Text);
                        pdfViewer1.ShowFindDialog(pdfFindDialogOptions);
                        pdfViewer1.FindText(btnTimKiemToanTap.Text);

                    }
                }
              
              
            }
        }
        private async void reload_Group_Book()
        {
            grvNhomSach.Columns.Clear();
            LoadGridControl_TuSachKinhDien();
            int IDTuSach = -1;
          
            List<Model.Books> datas = (from ns in data.tbl_BaiViet.Where(p=>p.isTuSachVanKien == true && p.status == true)
                                       select new Model.Books
                                       {
                                           ID = ns.id,
                                           TenTuSach = ns.TenBaiViet,
                                           LinkPDF = ns.ID_File_PDF,
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

           
            reload_Group_Book();
            grvNhomSach.ExpandAllGroups();
            grvNhomSach.Columns["TrangHienThi"].Visible = true;
            grvNhomSach.Columns["TenTuSach"].GroupIndex = 1;
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit
                {
                    buttonIndex = 0,
                    colname = "TrangHienThi",
                    styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search,
                    NameButton = "btnViewPageBook",
                    toolTip = "Chuyển đến trang",
                    Action = new Action(() => ShowViewBook("LinkPDF",
                      (int)grvNhomSach?.GetFocusedRowCellValue("ViTri")))
                });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(() => { FindKey(btnTimKiemToanTap.Text); }));
        }


        private async void FindKey(string text)
        {
            if (!string.IsNullOrEmpty(text) && grvNhomSach.RowCount >= 0)
            {
                var dataList = (List<Model.Books>)grcNhomSach.DataSource;
                await commom.Common.GetInstance().GetContextFromPDF(dataList.Where(p => p.LinkPDF != null).ToList(), text, grcNhomSach);
            }

        }

        private void lupTuSachKinhDien_EditValueChanged(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(reload_Group_Book);
        }

        private async void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grvNhomSach.FocusedRowHandle >= 0)
            {
                int IDBaiViet = (int)grvNhomSach.GetFocusedRowCellValue("ID");
                if ((await commom.Function.Instance.Get_Thi(commom.Commom_static.IDUser, IDBaiViet)).Count() == 0)
                {
                    frm_Thi frm = new frm_Thi(IDBaiViet, commom.Commom_static.IDUser);
                    frm.TieuDe = grvNhomSach.GetFocusedRowCellValue("TenTuSach").ToString();
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Bạn đã thi bài này", "Thông báo");
                }
            }
        }

      

        private async void grvNhomSach_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
        }

        private async void grvNhomSach_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int IDBaiViet = (int)grvNhomSach.GetFocusedRowCellValue("ID");
                bool enablebtnThi = (await commom.Function.Instance.KiemTraThi( IDBaiViet)).Count() > 0 ? true : false;
                btnThiVanKien.Enabled = enablebtnThi;
            }
        }
    }
}