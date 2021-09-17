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
            view_GridControl_LyThuyet();
        }
        private async void view_GridControl_NhomLyThuyet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcNhomLyThuyet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvNhomLyThuyet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "mã nhóm", FieldName_Columns = "IDNhomSach" , Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên nhóm", FieldName_Columns = "TenNhomSach" });

            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
            button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "TenNhomSach", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShow", toolTip = "Xem lý thuyết", Action = new Action(() => { ShowLyThuyet("IDNhomSach"); }) });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);

        }
        private async void view_GridControl_LyThuyet()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcDanhSachLyThuyet;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvDanhSachLyThuyet;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "Mã lý thuyết", FieldName_Columns = "id" , Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên bài", FieldName_Columns = "TenBaiViet" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Đường dẫn Power Point", FieldName_Columns = "Link_ppt" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Đường dẫn âm thanh", FieldName_Columns = "Link_voice" });


            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties);
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Link_ppt", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShowPowerPoint", toolTip = "Xem bài", Action = new Action(() => Show_task("Link_ppt")) });
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 1, colname = "Link_ppt", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, NameButton = "btnDownFile", toolTip = "Tải bài", Action = new Action(() => DownLoadFile("Link_ppt")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            {
                List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit> button_Edits = new List<Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit>();
                button_Edits.Add(new Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.properties.Button_edit { buttonIndex = 0, colname = "Link_voice", styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Search, NameButton = "btnShowVoice", toolTip = "Xem bài", Action = new Action(() => Show_task("Link_voice")) });
                Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(button_Edits);
            }
            

        }

        private async void ShowNhomLyThuyet()
        {

            grcNhomLyThuyet.DataSource = tV.NhomSaches.Where(p => p.status == true).ToList();
        }

        private async void Show_task(string fieldName)
        {
            string filePatd = grvDanhSachLyThuyet.GetFocusedRowCellValue(fieldName)?.ToString();
            if (!string.IsNullOrEmpty(filePatd))
            {
                commom.Commom.ThuchiencongViec.process_Application(filePatd);
            }
            else
            {
                XtraMessageBox.Show("Không có bài để mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private async void DownLoadFile(string fieldName)
        {
            string filePatd = grvDanhSachLyThuyet.GetFocusedRowCellValue(fieldName)?.ToString();
            if (!string.IsNullOrEmpty(filePatd))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();
                {
                    File.Copy(filePatd, saveFileDialog.FileName, true);
                }
            }
            else
            {
                XtraMessageBox.Show("Không có bài để tải!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void ShowLyThuyet(string fieldName)
        {
            int IDNhomBai = (int)grvNhomLyThuyet.GetFocusedRowCellValue(fieldName);
            grcDanhSachLyThuyet.DataSource = tV.tbl_BaiViet.Where(p => p.ID_NhomSach == IDNhomBai && p.status == true).ToList();
        }

        private void btnTaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(ShowNhomLyThuyet));
        }
    }
}