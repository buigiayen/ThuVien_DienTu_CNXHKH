using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ThuVien_DienTu_CNXHKH.Report
{
    public partial class Rep_Thi : DevExpress.XtraReports.UI.XtraReport
    {
        private form.frm_DanhGiaKetQuaThi.DanhGiaKetQua danhGiaKetQua1;
        public Rep_Thi(form.frm_DanhGiaKetQuaThi.DanhGiaKetQua danhGiaKetQua)
        {
            InitializeComponent();
            danhGiaKetQua1 = danhGiaKetQua;
            BingDinglist();
        }
        public Rep_Thi()
        {
            InitializeComponent();
          
        }
        private async void BingDinglist()
        {
            lblTieuDe.Text = "KẾT QUẢ CỦA GÓI CÂU HỎI: " + danhGiaKetQua1.TieuDe;
            celNgayGio.Text = DateTime.Now.Day + " Tháng " + DateTime.Now.Month + " Năm " + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Second;
            CelThoiGian.Text = danhGiaKetQua1.ThoiGian;
            CelIDNguoiDung.Text = danhGiaKetQua1.IDNguoiDung;
            celDiaChiEmail.Text = danhGiaKetQua1.DiaChiEmail;
            CelDaTraLoi.Text = danhGiaKetQua1.DaTraLoi;
            CelDiemCuaNguoiHoc.Text = danhGiaKetQua1.DiemCuaNguoiHoc;
            CelDiemDat.Text = danhGiaKetQua1.DiemDat;
            CelThoiGian.Text = danhGiaKetQua1.ThoiGian;
            CelTiLe.Text = danhGiaKetQua1.TiLePhanTram + "%";
            CelKQ.Text = danhGiaKetQua1.TiLePhanTram >= 50 ? "Bạn đã vượt qua" : "Bạn chưa vượt qua";
           


            colCauHoi.DataBindings.Add("Text", DataSource, "CauHoi");
            colThuong.DataBindings.Add("Text", DataSource, "Thuong");
            colDiem.DataBindings.Add("Text", DataSource, "Diem");
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
         
        }

        private void Rep_Thi_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          
        
        }
    }
}
