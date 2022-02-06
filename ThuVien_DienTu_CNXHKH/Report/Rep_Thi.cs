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
            var datasouce = danhGiaKetQua1.cauTraLois;
            colCauHoi.DataBindings.Add("Text", datasouce, "CauHoi");
            colThuong.DataBindings.Add("Text", datasouce, "Thuong");
            colDiem.DataBindings.Add("Text", datasouce, "Diem");
          
        }
        
    }
}
