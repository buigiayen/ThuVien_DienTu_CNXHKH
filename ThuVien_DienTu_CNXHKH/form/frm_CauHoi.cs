using DevExpress.Data.Browsing;
using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_CauHoi : XtraForm
    {
        int idBaiViet;
        //0: Mới 1: Sửa
        int action;
        CauHoi currentData;
        public frm_CauHoi(int _idBaiViet)
        {
            InitializeComponent();
            this.idBaiViet = _idBaiViet;
        }

        private void frm_CauHoi_Load(object sender, EventArgs e)
        {
            ClearControl(layoutControlInput);
            action = 0;
            LoadDataToGrid();
            EnableControlByAction(action);
        }

        public static void ClearControl(Control control, bool isNow = true, bool isBinding = false, bool defaultFirstCheck = false)
        {
            if (control.GetType() == typeof(TextEdit))
            {
                TextEdit txtbox = (TextEdit)control;
                txtbox.Text = string.Empty;
            }
            else if (control.GetType() == typeof(LookUpEdit))
            {
                LookUpEdit le = (LookUpEdit)control;
                le.EditValue = null;
            }
            else if (control.GetType() == typeof(GridLookUpEdit))
            {
                GridLookUpEdit gle = (GridLookUpEdit)control;
                gle.EditValue = null;
            }
            else if (control.GetType() == typeof(CheckEdit))
            {
                CheckEdit chkbox = (CheckEdit)control;
                chkbox.Checked = false;
            }
            else if (control.GetType() == typeof(RadioGroup))
            {
                RadioGroup rdg = (RadioGroup)control;
                rdg.SelectedIndex = 0;
            }
            else if (control.GetType() == typeof(DateEdit))
            {
                DateEdit dt = (DateEdit)control;
                dt.EditValue = isNow ? (DateTime?)DateTime.Now : null;
            }
            else if (control.GetType() == typeof(MemoEdit))
            {
                MemoEdit mme = (MemoEdit)control;
                mme.Text = string.Empty;
            }
            else if (control.GetType() == typeof(ComboBoxEdit))
            {
                ComboBoxEdit cbb = (ComboBoxEdit)control;
                cbb.Text = string.Empty;
            }
            else if (control.GetType() == typeof(MemoEdit))
            {
                MemoEdit mme = (MemoEdit)control;
                mme.Text = string.Empty;
            }
            else if (control.GetType() == typeof(SpinEdit))
            {
                SpinEdit sp = (SpinEdit)control;
                sp.EditValue = null;
            }
            else if (control.GetType() == typeof(CheckedListBoxControl))
            {
                CheckedListBoxControl clb = (CheckedListBoxControl)control;
                clb.UnCheckAll();
                if (defaultFirstCheck && clb.ItemCount > 0)
                    clb.SetItemChecked(0, true);
            }
            else if (control.GetType() == typeof(GridControl))
            {
                GridControl grd = (GridControl)control;
                if (!isBinding)
                    grd.DataSource = null;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ClearControl(child, isNow, isBinding, defaultFirstCheck);
                }
            }
        }

        public static void ReadOnlyControl(Control control, bool readOnly)
        {
            if (control.GetType() == typeof(TextEdit))
            {
                TextEdit txtbox = (TextEdit)control;
                txtbox.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(LookUpEdit))
            {
                LookUpEdit le = (LookUpEdit)control;
                foreach (DevExpress.XtraEditors.Controls.EditorButton bt in le.Properties.Buttons)
                {
                    bt.Enabled = !readOnly;
                }
                le.Properties.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(GridLookUpEdit))
            {
                GridLookUpEdit gle = (GridLookUpEdit)control;
                foreach (DevExpress.XtraEditors.Controls.EditorButton bt in gle.Properties.Buttons)
                {
                    bt.Enabled = !readOnly;
                }
                gle.Properties.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(CheckEdit))
            {
                CheckEdit chkbox = (CheckEdit)control;
                chkbox.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(RadioGroup))
            {
                RadioGroup rdg = (RadioGroup)control;
                rdg.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(DateEdit))
            {
                DateEdit dt = (DateEdit)control;
                dt.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(MemoEdit))
            {
                MemoEdit mme = (MemoEdit)control;
                mme.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(ComboBoxEdit))
            {
                ComboBoxEdit cbb = (ComboBoxEdit)control;
                cbb.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(MemoEdit))
            {
                MemoEdit mme = (MemoEdit)control;
                mme.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(SpinEdit))
            {
                SpinEdit sp = (SpinEdit)control;
                sp.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(CheckedListBoxControl))
            {
                CheckedListBoxControl clb = (CheckedListBoxControl)control;
                clb.ReadOnly = readOnly;
            }
            else if (control.GetType() == typeof(GridControl))
            {
                GridControl grd = (GridControl)control;
                GridView view = grd.MainView as GridView;
                view.OptionsBehavior.Editable = !readOnly;
            }

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    ReadOnlyControl(child, readOnly);
                }
            }
        }

        private void LoadDataToCombo(int idCauHoi)
        {
            TV dataContext = new TV();
            var listCauTraLois = dataContext.CauTraLois.Where(o => o.CauHoiId == idCauHoi).ToList();
            cboCauTraLoiDung.Properties.DataSource = listCauTraLois;
        }

        private void LoadDataToGrid()
        {
            TV dataContext = new TV();
            var kcbs = dataContext.CauHois.Where(o => o.BaiVietId == idBaiViet).ToList();
            gridControlDanhSach.DataSource = kcbs;
            gridViewDanhSach.FocusedRowHandle = 0;
            gridViewDanhSach_RowCellClick(null, null);
        }

        private class GioiTinhC
        {
            public int Id { get; set; }
            public string Ten { get; set; }
        }

        private void LoadDataToControl(CauHoi data)
        {
            LoadDataToCombo(data?.Id ?? 0);
            txtSoThuTu.Text = data?.Stt?.ToString();
            txtNoiDungCauHoi.Text = data?.NoiDung;
            chkHoatDong.Checked = data?.Status == true;
            cboCauTraLoiDung.EditValue = data?.IdCauTraLoiDung;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            ReadOnlyControl(layoutControlInput, false);
        }

        private void EnableControlByAction(int _action)
        {
            switch (_action)
            {
                case 1:
                    ReadOnlyControl(layoutControlInput, true);
                    btnSua.Enabled = true;
                    btnCauTraLoi.Enabled = true;
                    btnXoa.Enabled = true;
                    btnLuu.Enabled = false;
                    break;
                case 0:
                    ReadOnlyControl(layoutControlInput, false);
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnCauTraLoi.Enabled = false;
                    btnLuu.Enabled = true;
                    break;
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool success = false;
            TV dataContext = new TV();
            if (action == 0)
            {
                CauHoi add = new CauHoi();
                GetDataSave(ref add);
                dataContext.CauHois.Add(add);
                dataContext.SaveChanges();
                success = true;
            }
            else
            {
                if (currentData != null)
                {
                    var update = dataContext.CauHois.FirstOrDefault(o => o.Id == currentData.Id);
                    if (update != null)
                    {
                        GetDataSave(ref update);
                        dataContext.SaveChanges();
                        success = true;
                    }
                }
            }
            if (success)
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_CauHoi_Load(null, null);
            }
            else
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void GetDataSave(ref CauHoi data)
        {
            data.BaiVietId = idBaiViet;
            data.NoiDung = txtNoiDungCauHoi.Text;
            data.Status = chkHoatDong.Checked;
            data.IdCauTraLoiDung = cboCauTraLoiDung.EditValue != null ? (int?)Convert.ToInt32(cboCauTraLoiDung.EditValue) : null;
            data.Stt = !string.IsNullOrWhiteSpace(txtSoThuTu.Text) ? (int?)Convert.ToInt32(txtSoThuTu.Text) : null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentData == null) return;
            if (XtraMessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && currentData != null)
            {
                bool success = false;
                TV dataContext = new TV();
                var delete = dataContext.CauHois.FirstOrDefault(o => o.Id == currentData.Id);
                if (delete != null)
                {
                    var cauTraLois = dataContext.CauTraLois.Where(o => o.CauHoiId == delete.Id).ToList();
                    dataContext.CauTraLois.RemoveRange(cauTraLois);
                    dataContext.CauHois.Remove(delete);
                    dataContext.SaveChanges();
                    success = true;
                    currentData = null;
                }
                if (success)
                {
                    XtraMessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_CauHoi_Load(null, null);
                }
                else
                    XtraMessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridViewDanhSach_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var row = (CauHoi)gridViewDanhSach.GetFocusedRow();
            currentData = row;
            if (row != null)
            {
                action = 1;
                EnableControlByAction(action);
                LoadDataToControl(row);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = 0;
            ClearControl(groupControl2);
            EnableControlByAction(action);
        }

        private void cbo_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit cbo = sender as LookUpEdit;
            if (cbo != null)
            {
                cbo.Properties.Buttons[1].Visible = cbo.EditValue != null;
            }
        }

        private void cbo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LookUpEdit cbo = sender as LookUpEdit;
            if (cbo != null && e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                cbo.EditValue = null;
            }
        }

        private void frm_CauHoi_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnCauTraLoi_Click(object sender, EventArgs e)
        {
            if (currentData == null)
                return;
            frm_CauTraLoi frm = new frm_CauTraLoi(currentData?.Id ?? 0, LoadDataToCombo);
            frm.ShowDialog();
        }
    }
}
