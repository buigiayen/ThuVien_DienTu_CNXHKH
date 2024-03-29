﻿using DevExpress.XtraEditors;
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
            columnsproperties.Add(new properties.columns { Caption_Columns = "status", FieldName_Columns = "status", Visible = false });
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.Load_ColumnsView(columnsproperties );
            Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol.GridControls.Control.add_ColumnGricontrol_RepositoryItemButtonEdit(new List<properties.Button_edit>()
            {
                new properties.Button_edit
                {
                    Action = new Action(() => deteleFile(Convert.ToInt32(grvList.GetFocusedRowCellValue("ID")))),
                    buttonIndex = 0,
                     colname = "FileName",
                     NameButton = "DeleteFile",
                     styleButton = DevExpress.XtraEditors.Controls.ButtonPredefines.Clear,
                     toolTip = "Xóa file"
                }
            }) ;

            grvList.OptionsBehavior.ReadOnly = true;
        }

        private async void deteleFile(int idFile)
        {
            if (await commom.Common.GetInstance().XtraMessageBoxQuestion() == DialogResult.OK)
            {
                var file = data.Files.Single(p => p.ID == idFile);
                file.status = false;
                data.SaveChanges();
                LoadData();
            }    
             
        }

        private void frm_File_Load(object sender, EventArgs e)
        {
            Load_GridControl_File();
            LoadData();
        }
        private async void LoadData()
        {
            grcList.DataSource = data.Files.Where(p=>p.status == true).ToList();
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(LoadData);
        }

        private async void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fileInfo =   commom.Common.GetInstance().OpenMultiselectFile();
            if (fileInfo != null && fileInfo.Count > 0)
            {
                foreach (var fileInfos in fileInfo)
                {
                    if (!string.IsNullOrEmpty(fileInfos.nameFile))
                    {
                        var fileExit = data.Files.Where(p => p.FileName == fileInfos.nameFile && p.status == true)?.SingleOrDefault();
                        if (fileExit != null)
                        {
                            DialogResult r = XtraMessageBox.Show("File đã tồn tại bạn muốn thêm mới!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (r == DialogResult.OK)
                            {
                                fileExit.FileName = fileInfos.nameFile + DateTime.Now.ToString();
                                saveFile(fileInfos);
                                //data.SaveChanges();
                            }
                        }
                        else
                        {
                            saveFile(fileInfos);
                        }

                    }
                }
               
            }
            
           LoadData();
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