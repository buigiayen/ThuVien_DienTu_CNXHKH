using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class frm_Thi : XtraForm
    {
        int idBaiViet;
        int idUser;
        public string TieuDe { get; set; }
        List<DaTraLoi> listDaTraLois;
        DateTime thoiGianBatDau;
        public frm_Thi(int _idBaiViet, int _idUser)
        {
            InitializeComponent();
            this.idBaiViet = _idBaiViet;
            this.idUser = _idUser;
        }

        public class DaTraLoi
        {
            public int CauHoiId { get; set; }
            public int? CauTraLoiId { get; set; }
        }

        private void frm_Thi_Load(object sender, EventArgs e)
        {

        }


        public class CauTraLoiCheck
        {
            public int Id { get; set; }
            public int CauHoiId { get; set; }
            public string NoiDung { get; set; }
            public bool? Check { get; set; }
        }
        CauHoi currentRow;
        private void gridViewCauHoi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = (CauHoi)gridViewCauHoi.GetFocusedRow();
            currentRow = row;
            if (row != null)
            {
                txtNoiDung.Text = row.NoiDung;
                TV dataContext = new TV();
                var cauTraLois = dataContext.CauTraLois.Where(o => o.CauHoiId == row.Id).ToList().Select(o => new CauTraLoiCheck { Check = null, Id = o.Id, CauHoiId = o.CauHoiId, NoiDung = o.NoiDung }).ToList();
                var cauDaTraLoi = listDaTraLois.FirstOrDefault(o => o.CauHoiId == row.Id);
                var check = cauTraLois.FirstOrDefault(o => o.Id == cauDaTraLoi.CauTraLoiId);
                if (check != null)
                {
                    check.Check = true;
                }

                radioGroup_TraLoi.Properties.Items.Clear();
                int selectIndex = -1;
                for (int i = 0; i < cauTraLois.Count; i++)
                {
                    radioGroup_TraLoi.Properties.Items.Add(new RadioGroupItem { Description = cauTraLois[i].NoiDung, Tag = cauTraLois[i] });
                    if (cauTraLois[i].Check == true)
                    {
                        selectIndex = i;
                    }
                }
                radioGroup_TraLoi.SelectedIndex = selectIndex;

            }
        }

        private void gridViewCauHoi_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            var row = (CauHoi)gridViewCauHoi.GetRow(gridViewCauHoi.GetRowHandle(e.ListSourceRowIndex));
            if (row != null && e.IsGetData && e.Column.UnboundType != DevExpress.Data.UnboundColumnType.Bound)
            {
                if (e.Column.FieldName == "Cau")
                {
                    e.Value = $"Câu {e.ListSourceRowIndex + 1}";
                }
            }
        }

        private void radioGroup_TraLoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup_TraLoi.SelectedIndex < 0)
                return;
            var item = (CauTraLoiCheck)radioGroup_TraLoi.Properties.Items[radioGroup_TraLoi.SelectedIndex].Tag;
            if (item != null)
            {
                listDaTraLois.FirstOrDefault(o => o.CauHoiId == item.CauHoiId).CauTraLoiId = item.Id;
            }
           
        }

        private void btnCauTiepTheo_Click(object sender, EventArgs e)
        {
            gridViewCauHoi.FocusedRowHandle += 1;
        }

        private void btnCauTruoc_Click(object sender, EventArgs e)
        {
            gridViewCauHoi.FocusedRowHandle -= 1;
        }

        private void btnKetThucBaiThi_Click(object sender, EventArgs e)
        {
            t.Stop();
            TV dataContext = new TV();
            BaiThi addBt = new BaiThi();
            addBt.BaiVietId = idBaiViet;
            addBt.ThoiGianBatDauThi = thoiGianBatDau;
            addBt.ThoiGianKetThucThi = DateTime.Now;
            addBt.UserId = idUser;
            int soCauDung = 0;
            int STT = 1;
            List<frm_DanhGiaKetQuaThi.CauTraLoi> cauTraLois = new List<frm_DanhGiaKetQuaThi.CauTraLoi>();
            var listCauTraLoiDung = dataContext.CauTraLois.ToList();
            foreach (var item in listDaTraLois)
            {
                frm_DanhGiaKetQuaThi.CauTraLoi cauTraLoi = new frm_DanhGiaKetQuaThi.CauTraLoi();
                cauTraLoi.STT = STT;
                var cauHoi = dataContext.CauHois.FirstOrDefault(o => o.Id == item.CauHoiId);
                cauTraLoi.CauHoi = cauHoi.NoiDung;
                cauTraLoi.CauTraLoiDungText = listCauTraLoiDung.Where(p => p.Id == cauHoi.IdCauTraLoiDung).FirstOrDefault().NoiDung;
                cauTraLoi.CauTraLoiText = listCauTraLoiDung.Where(p => p.Id == item.CauTraLoiId).FirstOrDefault()?.NoiDung;
                if (cauHoi.IdCauTraLoiDung == item.CauTraLoiId)
                {
                    soCauDung += 1;
                    cauTraLoi.Thuong = 1;
                    cauTraLoi.KetQua = true;
                    
                }
                else
                {
                    cauTraLoi.Thuong = 0;
                }
                cauTraLoi.Diem = 1;
                cauTraLois.Add(cauTraLoi);
                STT++;
               
            }
            addBt.IsThiLai = false;
            addBt.SoCauTraLoiDung = soCauDung;
            addBt.TongSoCau = listDaTraLois.Count;
            dataContext.BaiThis.Add(addBt);

            if (dataContext.SaveChanges() > 0)
            {
                XtraMessageBox.Show($"Đã hoàn thành bài thi! Số câu trả lời đúng là: {soCauDung}/{listDaTraLois.Count}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                XtraMessageBox.Show($"Lưu bài thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);


            frm_DanhGiaKetQuaThi frm = new frm_DanhGiaKetQuaThi(new frm_DanhGiaKetQuaThi.DanhGiaKetQua
            {
                TieuDe = TieuDe,
                ThoiGian = lblTime.Text,
                TiLePhanTram = ((double)soCauDung / (double)listDaTraLois.Count) * 100,
                DiemDat = $"{((double)listDaTraLois.Count * 50) / 100 } (50%)",
                DiemCuaNguoiHoc = $"{ soCauDung }/{ listDaTraLois.Count } {soCauDung} ({((double)soCauDung / (double)listDaTraLois.Count) * 100}%)",
                IDNguoiDung = commom.Commom_static.TenNguoiDung,
                DaTraLoi = $"{ soCauDung }/{ listDaTraLois.Count }",
                cauTraLois = cauTraLois

            }) ;
            frm.ShowDialog();
        }

        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            btnBatDauThi.Enabled = false;
            btnCauTiepTheo.Enabled = true;
            btnCauTruoc.Enabled = true;
            btnKetThucBaiThi.Enabled = true;

            clock = new Clock();
            StartTimer();
            t.Start();
            thoiGianBatDau = DateTime.Now;
            TV dataContext = new TV();
            var cauHois = dataContext.CauHois.Where(o => o.BaiVietId == idBaiViet).OrderBy(o => o.Stt).ToList();
            listDaTraLois = cauHois.Select(o => new DaTraLoi { CauHoiId = o.Id, CauTraLoiId = null }).ToList();
            gridControlCauHoi.DataSource = cauHois;
        }

        Clock clock = null;
        System.Windows.Forms.Timer t = null;
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            clock.IncrementSeconds();
            lblTime.Text = $"{clock.GetHours()} giờ {clock.GetMinutes()} phút {clock.GetSeconds()} giây";
        }

        public class Clock
        {
            //instance variables
            private int hours, minutes, seconds;

            public Clock()
            {
                SetTime(0, 0, 0);
            }

            public Clock(int hours, int minutes, int seconds)
            {
                SetTime(hours, minutes, seconds);
            }

            public void SetTime(int hours, int minutes, int seconds)
            {
                if ((seconds >= 0) && (seconds < 60) && (minutes >= 0) && (minutes < 60)
                    && (hours >= 0) && (hours < 24))
                {
                    this.hours = hours;
                    this.minutes = minutes;
                    this.seconds = seconds;
                }
                else
                {
                    this.hours = 0;
                    this.minutes = 0;
                    this.seconds = 0;
                }

            }

            public int GetHours()
            {
                return hours;
            }

            public int GetMinutes()
            {
                return minutes;
            }

            public int GetSeconds()
            {
                return seconds;
            }

            //Tick()
            public void Tick()
            {
                IncrementSeconds();
                IncrementMinutes();
                IncrementHours();
            }

            //incrementSeconds()
            public void IncrementSeconds()
            {
                seconds++;
                if (seconds > 59)
                {
                    seconds = 0;
                    IncrementMinutes();
                }
            }

            //incrementMinutes()
            public void IncrementMinutes()
            {
                minutes++;
                if (minutes > 59)
                {
                    minutes = 0;
                    IncrementHours();
                }
            }

            //incrementHours()
            public void IncrementHours()
            {
                hours++;
                if (hours > 23)
                {
                    hours = 0;
                }
            }

        }
    }
}
