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
            btnAddBook.Visibility = commom.Commom_static.isAdmin ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never;
        }
        private database.TV data = new database.TV();
        private async void ShowBook()
        {
            grcTuSach.DataSource = data.tuSaches.Where(p => commom.Commom_static.isAdmin ? true : p.status == true).ToList();
            lupListFile.DataSource = await commom.Function.Instance.getfile(commom.Commom_static.File_PDF);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowBook();
        }

        private void frm_TuSachV2_Load(object sender, EventArgs e)
        {
            grvTuSach.OptionsBehavior.ReadOnly = !commom.Commom_static.isAdmin;
        }

        private void grvTuSach_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
            data.tuSaches.Add(new database.tuSach { });
            data.SaveChanges();
            Cresoft_controlCustomer.windows.Watting.CallProcess.Control.CallProcessbar(ShowBook);
        }

        private void txtTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtTenSach.Text))
                {
                    grcTuSach.DataSource = null;
                    grcTuSach.DataSource = data.tuSaches.Where(p => (commom.Commom_static.isAdmin ? true : p.status == true) && (p.TenSach.Contains(txtTenSach.Text))).ToList();
                }
                else
                {
                    ShowBook();
                }


            }
        }

        private void txtLoaiTaiLieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtLoaiTaiLieu.Text))
                {
                    grcTuSach.DataSource = null;
                    grcTuSach.DataSource = data.tuSaches.Where(p => (commom.Commom_static.isAdmin ? true : p.status == true) && (p.LoaiTaiLieu.Contains(txtLoaiTaiLieu.Text))).ToList();
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
                    grcTuSach.DataSource = null;
                    grcTuSach.DataSource = data.tuSaches.Where(p => (commom.Commom_static.isAdmin ? true : p.status == true) && (p.TacGia.Contains(txtTacGia.Text))).ToList();
                }
                else
                {
                    ShowBook();
                }


            }
        }
    }
}