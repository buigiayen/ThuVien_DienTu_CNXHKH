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
        public Function()
        {
        }
        #endregion
        private TV data = new TV();
        public async Task<List<File>> getfile(string ex)
        {
            var ListFile = data.Files.Where(p => (string.IsNullOrEmpty(ex) ? true : p.Ex.Contains(ex.ToLower())) && p.status == true).ToList();
            return ListFile;
        }
        public async Task<string> getFilePatd(int? idFile)
        {
            string currentPath = AppDomain.CurrentDomain.BaseDirectory + "File";
            string filePath = "";
            if (!System.IO.Directory.Exists(currentPath)) { System.IO.Directory.CreateDirectory(currentPath); }
            var dataFile = data.Files.Where(p => p.ID == idFile).FirstOrDefault()?.FileName;
            if (!string.IsNullOrEmpty(dataFile))
            {
                filePath = System.IO.Path.Combine(currentPath, dataFile);
                if (!System.IO.File.Exists(filePath))
                {
                    await commom.Common.GetInstance().DownloadFile(commom.Commom_static.Bucket, dataFile, currentPath);
                }
            }
            return filePath;

        }
        public async Task<List<TraCuuThuatNgu>> Get_TraCuu(int PhanLoai = 0)
        { 
            return data.TraCuuThuatNgus.Where(p => p.status == true  && p.PhanLoai == PhanLoai ).ToList();
        }
        public async Task<List<BaiThi>> Get_Thi(int? idUser = null, int? idbaithi = null)
        {
            return data.BaiThis.Where(p => p.UserId == idUser && p.BaiVietId == idbaithi).ToList();
        }
        public async Task<List<CauHoi>> KiemTraThi(int idbaithi)
        {
            return data.CauHois.Where(p => p.BaiVietId == idbaithi).ToList();
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
        public async Task<string> ChangePassword(int UserID, string passold, string passnew)
        {
            string passNewHashMD5 = commom.Common.GetInstance().Md5(passnew);
            if (!commom.Commom_static.isAdmin)
            {
                string dataPassOld = data.UserLogins.Where(p => p.id == UserID).FirstOrDefault().Password;
                string passoldHashMD5 = commom.Common.GetInstance().Md5(passold);
                if (!dataPassOld.Equals(passoldHashMD5)) return "Mật khẩu chưa chính xác!";
            }
            var UserLogin = data.UserLogins.Single(p => p.id == UserID);
            UserLogin.Password = passNewHashMD5;
            data.SaveChanges();
            return "Thay đổi mật khẩu thành công!";
        }

        private Newtonsoft.Json.Linq.JObject parameter = null;
        public async Task<List<DonVi>> InfoUnits(string IDDonVi)
        {
            string url = "GetCongifVersion?IDDonVi=" + IDDonVi;
            parameter = new Newtonsoft.Json.Linq.JObject();
            parameter.Add("IDDonVi", IDDonVi);
            var data = await commom.Common.GetInstance().API_data_Async(url, parameter);
            if (data.Count > 0 && data != null)
            {
                var dataContext = data.FirstOrDefault();
                return await commom.Common.GetInstance().ConvertObjectToListClassAsync<DonVi>(dataContext.code, dataContext.Data, dataContext.Messenger);
            }
            else
            {
                return null;
            }
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
    public class DonVi
    {
        public int ID { get; set; }
        public string MaDonVi { get; set; }
        public string TenDonVi { get; set; }
        public bool Active { get; set; }
        public string URL { get; set; }
        public string Bucket { get; set; }
        public string Note { get; set; }
        public string Version { get; set; }
    }
}
