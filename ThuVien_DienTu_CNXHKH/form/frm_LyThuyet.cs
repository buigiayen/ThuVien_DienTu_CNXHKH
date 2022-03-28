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
using ThuVien_DienTu_CNXHKH.commom;
using ThuVien_DienTu_CNXHKH.form;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;




namespace ThuVien_DienTu_CNXHKH.from
{
    public partial class frm_LyThuyet : DevExpress.XtraEditors.XtraForm
    {
        public frm_LyThuyet()
        {
            InitializeComponent();
        }

        database.TV tV = new database.TV();
        private void frm_LyThuyet_Load(object sender, EventArgs e)
        {
            view_GridControl_NhomLyThuyet();
            ShowNhomLyThuyet();
        }
        private async void view_GridControl_NhomLyThuyet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcNhomLyThuyet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvNhomLyThuyet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã nhóm", FieldName_Columns = "IDNhomSach", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Bộ môn", FieldName_Columns = "TenNhomSach" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã bài", FieldName_Columns = "id", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Power Point", FieldName_Columns = "ID_File_PPT", Visible = false });

            columnsproperties.Add(new properties.columns { Caption_Columns = "Âm thanh", FieldName_Columns = "ID_FileWord", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "FileWord", FieldName_Columns = "ID_File_Voice", Visible = false });

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties, false, true);
            //{
            //    List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
            //    button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenBaiViet", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShowWord", toolTip = "Mở file word", Action = new Action(() => { showFileWord("ID_FileWord"); }) });
            //    Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            //}
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemMemoEdit(new string[] { "TenBaiViet" }, AllowEdit: false, WordWrap: true);


            grvNhomLyThuyet.Columns["TenNhomSach"].GroupIndex = 0;
            grvNhomLyThuyet.RowClick += GrvNhomLyThuyet_RowClick;
        }

        private async void GrvNhomLyThuyet_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int? IDFile = (int?)grvNhomLyThuyet.GetFocusedRowCellValue("ID_FileWord") ?? null;
                if (IDFile != null)
                {
                    string FilePath = Function.Instance.getFilePatd(IDFile).Result;
                    if (!string.IsNullOrEmpty(FilePath))
                    {
                        richEditControl1.LoadDocument(FilePath);
                    }

                }

            }

        }




        private async void ShowNhomLyThuyet()
        {

            grcNhomLyThuyet.DataSource = (from ns in tV.NhomSaches.Where(p => p.status == true)
                                          join s in tV.tbl_BaiViet.Where(p => p.isTuSachVanKien == false) on ns.IDNhomSach equals s.ID_NhomSach
                                          select new
                                          {
                                              ns.IDNhomSach,
                                              ns.TenNhomSach,
                                              s.id,
                                              s.TenBaiViet,
                                              s.ID_File_PPT,
                                              s.ID_FileWord,
                                              s.ID_File_Voice
                                          }).ToList();
        }


        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(ShowNhomLyThuyet));
        }

        private async void btnPowerPoint_Click(object sender, EventArgs e)
        {
            int? IDFile = (int?)grvNhomLyThuyet.GetFocusedRowCellValue("ID_File_PPT") ?? null;
            if (IDFile != null)
            {
                commom.Common.GetInstance().process_Application(await Function.Instance.getFilePatd(IDFile));
            }
        }

        private async void btnShowFileMp3_Click(object sender, EventArgs e)
        {
            int? IDFile = (int?)grvNhomLyThuyet.GetFocusedRowCellValue("ID_File_Voice") ?? null;
            if (IDFile != null)
            {
                commom.Common.GetInstance().process_Application(await Function.Instance.getFilePatd(IDFile));
            }
        }

        private async void btnTracNghiem_Click(object sender, EventArgs e)
        {
            if (grvNhomLyThuyet.FocusedRowHandle >= 0)
            {
                int IDBaiViet = (int)grvNhomLyThuyet.GetFocusedRowCellValue("id");
                frm_Thi frm = new frm_Thi(IDBaiViet, commom.Commom_static.IDUser);
                frm.TieuDe = grvNhomLyThuyet.GetFocusedRowCellValue("TenBaiViet").ToString();
                frm.ShowDialog();
            }


        }

        private void btnTaiLieuThamKhao_Click(object sender, EventArgs e)
        {
            if (grvNhomLyThuyet.FocusedRowHandle >= 0)
            {
                int IDBaiViet = (int)grvNhomLyThuyet.GetFocusedRowCellValue("id");
                frm_TaiLieuThamKhao frm = new frm_TaiLieuThamKhao(IDBaiViet);
                frm.ShowDialog();
            }

        }

        private void grvNhomLyThuyet_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                btnPowerPoint.Enabled = !string.IsNullOrEmpty(grvNhomLyThuyet.GetFocusedRowCellValue("ID_File_PPT")?.ToString());
                btnShowFileMp3.Enabled = !string.IsNullOrEmpty(grvNhomLyThuyet.GetFocusedRowCellValue("ID_File_Voice")?.ToString());
            }
        }
    }
}