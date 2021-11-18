using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class frm_KetQuaThi : XtraForm
    {
        public frm_KetQuaThi()
        {
            InitializeComponent();
        }

        private void frm_KetQuaThi_Load(object sender, EventArgs e)
        {
            TV dataContext = new TV();
            var sources = (from ns in dataContext.NhomSaches
                           join bv in dataContext.tbl_BaiViet on ns.IDNhomSach equals bv.ID_NhomSach
                           join bt in dataContext.BaiThis on bv.id equals bt.BaiVietId
                           join user in dataContext.UserLogins on bt.UserId equals user.id
                           select new KetQuaThi { IdNhomSach = ns.IDNhomSach, BaiThiId = bt.Id, IdBaiViet = bv.id, TenBaiViet = bv.TenBaiViet, TenNhomSach = ns.TenNhomSach, TenSinhVien = user.TenSinhVien, UserId = user.id, Username = user.Username, IsThiLai = bt.IsThiLai, TrangThai = bt.IsThiLai == true ? "Thi lại" : "Đã thi", SoCauDung = bt.SoCauTraLoiDung, TongSoCau = bt.TongSoCau }).ToList();
            gridControl_KetQuaThi.DataSource = sources;
        }

        public class KetQuaThi
        {
            public int IdNhomSach { get; set; }
            public int IdBaiViet { get; set; }
            public int BaiThiId { get; set; }
            public int UserId { get; set; }
            public string Username { get; set; }
            public string TenNhomSach { get; set; }
            public string TenBaiViet { get; set; }
            public string TenSinhVien { get; set; }
            public bool? IsThiLai { get; set; }
            public string TrangThai { get; set; }
            public int? SoCauDung { get; set; }
            public int? TongSoCau { get; set; }
        }

        private void gridView_KetQuaThi_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            var row = (KetQuaThi)gridView_KetQuaThi.GetRow(e.RowHandle);
            if (row != null)
            {
                GridGroupRowInfo groupInfo = e.Info as GridGroupRowInfo;
                if (groupInfo.Column.FieldName == "IdNhomSach")
                {
                    groupInfo.GroupText = row.TenNhomSach;
                }
                else if (groupInfo.Column.FieldName == "IdBaiViet")
                {
                    groupInfo.GroupText = row.TenBaiViet;
                }
                else if (groupInfo.Column.FieldName == "UserId")
                {
                    groupInfo.GroupText = $"{row.TenSinhVien} ({row.Username})";
                }
            }
        }

        private void gridView_KetQuaThi_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            var row = (KetQuaThi)gridView_KetQuaThi.GetRow(e.RowHandle);
            if (row != null && e.Column.FieldName == "ThiLai")
            {
                var dataSource = (List<KetQuaThi>)gridControl_KetQuaThi.DataSource;
                if (dataSource != null)
                {
                    var checkMax = dataSource.Where(o => o.IdNhomSach == row.IdNhomSach && o.IdBaiViet == row.IdBaiViet && o.UserId == row.UserId).Max(o => o.BaiThiId);
                    if (checkMax == row.BaiThiId && row.IsThiLai != true)
                    {
                        e.RepositoryItem = repositoryItemButtonEdit1;
                    }
                }
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var row = (KetQuaThi)gridView_KetQuaThi.GetFocusedRow();
            if (row != null)
            {
                TV dataContext = new TV();
                var baiThi = dataContext.BaiThis.FirstOrDefault(o => o.Id == row.BaiThiId);
                if (baiThi != null)
                {
                    baiThi.IsThiLai = true;
                    dataContext.SaveChanges();
                }
            }
        }

        private void gridView_KetQuaThi_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var row = (KetQuaThi)gridView_KetQuaThi.GetRow(gridView_KetQuaThi.GetRowHandle(e.ListSourceRowIndex));
            if (row != null && e.IsGetData && e.Column.UnboundType != DevExpress.Data.UnboundColumnType.Bound)
            {
                if (e.Column.FieldName == "KetQua")
                {
                    e.Value = $"{row.SoCauDung}/{row.TongSoCau}";
                }
            }
        }
    }
}
