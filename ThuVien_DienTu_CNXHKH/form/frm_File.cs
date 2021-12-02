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
using ThuVien_DienTu_CNXHKH.commom;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_File : DevExpress.XtraEditors.XtraForm
    {
        public frm_File()
        {
            InitializeComponent();
        }
        private database.TV data = new database.TV();
        private async void Load_GridControl_File()
        {
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridControl = grcList;
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.GridView = grvList;
            List<properties.columns> columnsproperties = new List<properties.columns>();
            columnsproperties.Add(new properties.columns { Caption_Columns = "id", FieldName_Columns = "ID", Visible = false });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên file", FieldName_Columns = "FileName" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Dường dẫn", FieldName_Columns = "FilePath" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "Tên tệp", FieldName_Columns = "Ex" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "size", FieldName_Columns = "size" });
            columnsproperties.Add(new properties.columns { Caption_Columns = "status", FieldName_Columns = "status" });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties );
            grvList.OptionsBehavior.ReadOnly = true;
        }
        private void frm_File_Load(object sender, EventArgs e)
        {
            Load_GridControl_File();
            LoadData();
        }
        private async void LoadData()
        {
            grcList.DataSource = data.Files.ToList();
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadData);
        }

        private async void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fileInfo = await commom.Common.ThuchiencongViec.FileSave();
            if (!string.IsNullOrEmpty(fileInfo.nameFile))
            {
                int fileExit = data.Files.Where(p => p.FileName == fileInfo.nameFile).Count();
                if (fileExit > 0)
                {
                    DialogResult r = XtraMessageBox.Show("File đã tồn tại bạn muốn thêm mới!","Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (r == DialogResult.OK)
                    {
                        fileInfo.nameFile += "_" + DateTime.Now.ToString("ddMMyyyHHmmss");
                        saveFile(fileInfo);
                    }
                    else
                    {
                        saveFile(fileInfo);
                    }
                }
                else
                {
                    saveFile(fileInfo);
                }

            }
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadData);
        }
        private async void saveFile(Model.FileInfos files)
        {
            var file = new database.File();
            file.FileName = files.nameFile;
            file.FilePath = files.Path;
            file.Ex = files.ex;
            file.size = files.size;
            file.status = true;
            data.Files.Add(file);
            data.SaveChanges();
        }
        
    }
}