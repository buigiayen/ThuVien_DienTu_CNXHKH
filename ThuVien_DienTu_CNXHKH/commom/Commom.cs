using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien_DienTu_CNXHKH.commom
{
    public class Commom_static
    {
        public static bool isAdmin { get; set; }
    }
    public class Commom
    {

        #region cấu trúc
        private static Commom instance;
        public static Commom ThuchiencongViec
        {
            get
            {
                if (instance == null)
                    ThuchiencongViec = new Commom();
                return Commom.instance;
            }
            private set
            {
                Commom.instance = value;

            }
        }
        private Commom()
        {
        }
        #endregion
        /// <summary>
        /// Open file dialog
        /// </summary>
        /// <returns></returns>
        public async Task<string> open_dialogFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            else
                return "";
        }
        /// <summary>
        /// Save File Dialog
        /// </summary>
        /// <returns></returns>
        public async Task<string> save_dialogFile()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() == DialogResult.OK)
                return savefile.FileName;
            else
                return "";
        }
        //Open file 
        public async Task<bool> process_Application(string file_patd)
        {
           
            try
            {
                System.Diagnostics.Process.Start(file_patd);
                return true;
            }
            catch(Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi: " + ex,"Thông báo lỗi",System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }


        }
        public string Md5(string text)
        {
            MD5 mh = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));
            }
            text = sb.ToString();
            return text;
        }

        

    }
}
