using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database;

namespace ThuVien_DienTu_CNXHKH.commom
{
    public class Function
    {
        #region cấu trúc
        private static Function instance;
        public static Function Instance
        {
            get
            {
                if (instance == null)
                    Instance = new Function();
                return Function.instance;
            }
            private set
            {
                Function.instance = value;

            }
        }
        private Function()
        {
        }
        #endregion
        private TV data = new TV();
        public async Task<List<File>> getfile(string ex)
        {
            return data.Files.Where(p => string.IsNullOrEmpty(ex) ? true : p.Ex.Contains(ex)).ToList();
        }
        public async Task<string> getFilePatd(int? idFile)
        {
            return data.Files.Where(p => p.ID == idFile).FirstOrDefault().FilePath;
        }
        public async Task<List<TraCuuThuatNgu>> Get_TraCuu(bool? Status = null, int PhanLoai = 0)
        {
            return data.TraCuuThuatNgus.Where(p => (Status == null ? true : p.status == Status) && p.PhanLoai == PhanLoai).ToList();
        }
        public async Task<List<BaiThi>> Get_Thi(int? idUser = null, int? idbaithi = null)
        {
            return data.BaiThis.Where(p => p.UserId == idUser && p.BaiVietId == idbaithi).ToList();
        }

        public async Task<List<KQThi>> KQThisAsync(int? UserID, int? IDBaiViet)
        {
            List<KQThi> kQThis = (from bv in data.tbl_BaiViet.Where(p => p.id == IDBaiViet)
                                  join ch in data.CauHois on bv.id equals ch.BaiVietId
                                  join ctl in data.CauTraLois on ch.IdCauTraLoiDung equals ctl.Id
                                  join bt in data.BaiThis on bv.id equals bt.BaiVietId
                                  join us in data.UserLogins on bt.UserId equals us.id
                                  select new KQThi
                                  {
                                      IDBaiThi = bv.id,
                                      TenBai = bv.TenBaiViet,
                                      User = us.id,
                                      UserName = us.TenSinhVien,

                                  }).ToList();

            return kQThis;
        }
        public async Task<string> ChangePassword(int UserID,string passold, string passnew)
        {
         
            string passoldHashMD5 = commom.Common.GetInstance().Md5(passold);
            string passNewHashMD5 = commom.Common.GetInstance().Md5(passnew);
            string dataPassOld = data.UserLogins.Where(p => p.id == UserID).FirstOrDefault().Password;
            if (!dataPassOld.Equals(passoldHashMD5)) return "Mật khẩu chưa chính xác!";
            var UserLogin = data.UserLogins.Single(p => p.id == UserID);
            UserLogin.Password = passNewHashMD5;
            data.SaveChanges();
            return "Thay đổi mật khẩu thành công!";
        }

    }
    public class KQThi
    {
        public int IDBaiThi { get; set; }
        public string TenBai { get; set; }
        public int User { get; set; }
        public string UserName { get; set; }
        public string CauHoi { get; set; }
        public string CauTraLoiCuaBan { get; set; }

    }

}
