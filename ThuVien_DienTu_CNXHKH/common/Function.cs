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



    }
}
