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

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_TuSachV2 : DevExpress.XtraEditors.XtraForm
    {
        public frm_TuSachV2()
        {
            InitializeComponent();

        }
        private database.TV data = new database.TV();
        private async void ShowBook()
        {

            grcTuSach.DataSource = data.tuSaches.Where(p => p.status == true).ToList();
            lupListFile.DataSource = await commom.Function.Instance.getfile(commom.Commom_static.File_PDF);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowBook();
        }

        private void frm_TuSachV2_Load(object sender, EventArgs e)
        {
            grvTuSach.OptionsBehavior.ReadOnly = !commom.Commom_static.isAdmin;
            glupLoaiTaiLieu.Properties.DataSource = (from ts in data.tuSaches.Where(p=> p.LoaiTaiLieu != null && p.LoaiTaiLieu != "") group ts by new { ts.LoaiTaiLieu } into k select new { k.Key.LoaiTaiLieu }).ToList();
        }



        private async void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
        }
        private async void Show_task(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0 && grvTuSach.GetFocusedRowCellValue(nameField) != null)
            {
                view.ViewFile viewFile = new view.ViewFile(await commom.Function.Instance.getFilePatd((int)grvTuSach.GetFocusedRowCellValue(nameField)));
                viewFile.Show();
            }
        }
        private async void DownLoadFile(string nameField)
        {
            if (grvTuSach.FocusedRowHandle >= 0 && grvTuSach.GetFocusedRowCellValue(nameField) != null)
            {
                string fileSource = await commom.Function.Instance.getFilePatd((int)grvTuSach.GetFocusedRowCellValue(nameField));
                string filePatd = await commom.Common.GetInstance().save_dialogFile();

                if (!string.IsNullOrEmpty(fileSource) && !string.IsNullOrEmpty(filePatd))
                {
                    File.Copy(fileSource, filePatd);
                }

            }
        }

        private void lupListFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(new Action(() => { Show_task("ID_File"); }));
                    break;
                case 2:
                    DownLoadFile("ID_File");
                    break;
            }

        }

        private void btnAddBook_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.tuSaches.Add(new database.tuSach { status = true });
            data.SaveChanges();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);
        }

        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtTenSach.Text))
                {
                    LoadTaiLieu();
                }
                else
                {
                    ShowBook();
                }


            }
        }

     

        private void txtTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtTacGia.Text))
                {
                    LoadTaiLieu();
                }
                else
                {
                    ShowBook();
                }


            }
        }

        private void grvTuSach_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (grvTuSach.FocusedRowHandle >= 0)
            {
                int iDBook = (int)grvTuSach.GetFocusedRowCellValue("ID");
                database.tuSach ts = data.tuSaches.Single(p => p.ID == iDBook);
                if (e.Column.FieldName == "status")
                {
                    ts.status = (bool)e.Value;
                }
                if (e.Column.FieldName == "TacGia")
                {
                    ts.TacGia = e.Value.ToString();
                }
                if (e.Column.FieldName == "LoaiTaiLieu")
                {
                    ts.LoaiTaiLieu = e.Value.ToString();
                }
                if (e.Column.FieldName == "NamXuatBan")
                {
                    ts.NamXuatBan = e.Value.ToString();
                }
                if (e.Column.FieldName == "ID_File")
                {
                    ts.ID_File = (int)e.Value;
                }
                if (e.Column.FieldName == "TenSach")
                {
                    ts.TenSach = e.Value.ToString();
                }

                data.SaveChanges();
            }
        }


        private async void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (await commom.Common.GetInstance().XtraMessageBoxQuestion() == DialogResult.OK)
            {
                int iDBook = (int)grvTuSach.GetFocusedRowCellValue("ID");
                database.tuSach ts = data.tuSaches.Single(p => p.ID == iDBook);
                ts.status = false;
                data.SaveChanges();
                ShowBook();
            }
        }

        private void glupLoaiTaiLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(glupLoaiTaiLieu.Text))
                {
                    LoadTaiLieu();
                }
                else
                {
                    ShowBook();
                }


            }
        }

        private async void LoadTaiLieu()
        {
            grcTuSach.DataSource = null;
            grcTuSach.DataSource = data.tuSaches.Where(p => 
            (p.status == true) &&
          
            p.TacGia == txtTacGia.Text || p.TenSach == txtTenSach.Text  || p.LoaiTaiLieu == glupLoaiTaiLieu.Text ).ToList();
        }

      

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            LoadTaiLieu();
        }
    }
}