using DevExpress.XtraEditors;
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
using ThuVien_DienTu_CNXHKH.Report;
using static Cresoft_controlCustomer.windows.componet_devexpress.Gricontrol;

namespace ThuVien_DienTu_CNXHKH.form
{
    public partial class frm_DanhGiaKetQuaThi : DevExpress.XtraEditors.XtraForm
    {
        public class DanhGiaKetQua
        {
            public string TieuDe { get; set; }
            public string IDNguoiDung { get; set; }
            public string DiaChiEmail { get; set; }
            public string DaTraLoi { get; set; }
            public string DiemCuaNguoiHoc { get; set; }
            public string ThoiGian { get; set; }
            public string DiemDat { get; set; }
            public double TiLePhanTram { get; set; }
            public List<CauTraLoi> cauTraLois { get; set; }
        }
        public class CauTraLoi
        {
            public int STT { get; set; }
            public string CauHoi { get; set; }
            public string CauTraLoiDungText { get; set; }
      
            public string CauTraLoiText { get; set; }


            public int Thuong { get; set; }
            public int Diem { get; set; }
            public bool KetQua { get; set; } = false;

        }
        private DanhGiaKetQua danhGiaKetQua1;
        public frm_DanhGiaKetQuaThi(DanhGiaKetQua danhGiaKetQua)
        {
            InitializeComponent();
            danhGiaKetQua1 = danhGiaKetQua;
            BindingData();
        }

        private async void BindingData()
        {
            txtNgayGio.Text = DateTime.Now.Day + " Tháng " + DateTime.Now.Month + " Năm " + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Second;
            lblTieuDe.Text += danhGiaKetQua1.TieuDe;
            txtIDNguoiDung.Text = danhGiaKetQua1.IDNguoiDung;
            txtDiaChiEmail.Text = danhGiaKetQua1.DiaChiEmail;
            txtDaTraLoi.Text = danhGiaKetQua1.DaTraLoi;
            txtDiemCuaNguoiHoc.Text = danhGiaKetQua1.DiemCuaNguoiHoc;
            txtThoiGian.Text = danhGiaKetQua1.ThoiGian;
            lblTiLe.Text = danhGiaKetQua1.TiLePhanTram + "%";
            lblTiLe.Appearance.ForeColor = danhGiaKetQua1.TiLePhanTram >= 50 ? Color.Green : Color.Red;
            txtKetQua.Text = danhGiaKetQua1.TiLePhanTram >= 50 ? "Bạn đã hoàn thành!" : "Bạn chưa hoàn thành!";
            txtKetQua.Appearance.ForeColor = danhGiaKetQua1.TiLePhanTram >= 50 ? Color.Green : Color.Red;
            txtDiemDat.Text = danhGiaKetQua1.DiemDat;
            progressBarControl1.EditValue = danhGiaKetQua1.TiLePhanTram;
            groupControl3.Text = danhGiaKetQua1.TieuDe.ToUpper();
            grcDanhSachDiem.DataSource = danhGiaKetQua1.cauTraLois;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Rep_Thi rep_Thi = new Rep_Thi(danhGiaKetQua1);
            rep_Thi.DataSource = danhGiaKetQua1.cauTraLois;
            ReportPrintTool printTool = new ReportPrintTool(rep_Thi);
            printTool.ShowPreview();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var listXemCauHoi = new List<frm_XemKetQua.XemCauHoi>();
            frm_XemKetQua frm_XemKetQua = new frm_XemKetQua();
            foreach (var item in danhGiaKetQua1.cauTraLois)
            {
                frm_XemKetQua.XemCauHoi xemCauHoi = new frm_XemKetQua.XemCauHoi();
                xemCauHoi.CauHoi = item.CauHoi;
                xemCauHoi.CauTraLoiDung = item.CauTraLoiDungText;
                xemCauHoi.CauTraLoi = item.CauTraLoiText;
                listXemCauHoi.Add(xemCauHoi);
            }
            frm_XemKetQua.DataBindGridControl(listXemCauHoi);
            frm_XemKetQua.ShowDialog();
        }
    }
}