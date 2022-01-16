﻿using DevExpress.XtraEditors;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace ThuVien_DienTu_CNXHKH.commom
{
    public class Commom_static
    {
        public static bool isAdmin { get; set; }
        public static string InfoUser { get; set; }
        public static int IDUser { get; set; }
        public static string File_DOCX = "DOCX";
        public static string File_PDF = "PDF";
        public static string File_Voice = "Mp3";
        public static string File_PPT = "PPTX";
    }
    public class Common : common.FunctionPattent.BaseFunction<Common>
    {


        /// <summary>
        /// Open file dialog
        /// </summary>
        /// <returns></returns>
        public async Task<string> open_dialogFile(string filename = "")
        {
            XtraOpenFileDialog xtraOpenFileDialog = new XtraOpenFileDialog();
            xtraOpenFileDialog.FileName = filename;
            if (xtraOpenFileDialog.ShowDialog() == DialogResult.OK)
                return xtraOpenFileDialog.FileName;
            else
                return "";
        }
        /// <summary>
        /// Save File Dialog
        /// </summary>
        /// <returns></returns>
        public async Task<string> save_dialogFile(string fileName = "")
        {
            XtraSaveFileDialog savefile = new XtraSaveFileDialog();
            savefile.FileName = fileName;
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
                if (File.Exists(file_patd))
                {
                    System.Diagnostics.Process.Start(file_patd);
                    return true;
                }
                else
                {
                    XtraMessageBox.Show("Không thể mở file, Đường dẫn không tồn tại hoặc đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi: " + ex, "Thông báo lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
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
        public async Task<List<Model.SendEmailStatus>> SendEmail(string emailto, string title, string body, string filePath)
        {
            List<Model.SendEmailStatus> listSend = new List<Model.SendEmailStatus>();
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("Buiyen.cresoft@gmail.com");
                mail.To.Add(emailto);
                mail.Subject = title;
                mail.IsBodyHtml = true;
                mail.Body = body;
                if (!string.IsNullOrEmpty(filePath)) { mail.Attachments.Add(new Attachment(filePath)); }
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.UseDefaultCredentials = false;
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("Buiyen.cresoft@gmail.com", "Buiyen45");
                client.EnableSsl = true; //vì ta cần thiết lập kết nối SSL với SMTP server nên cần gán nó bằng true
                client.Send(mail);
                listSend.Add(new Model.SendEmailStatus { messeger = "Thành công!", sendStatus = true });

            }
            catch (Exception ex)
            {
                listSend.Add(new Model.SendEmailStatus { messeger = "Lỗi!" + ex, sendStatus = false });
            }
            return listSend;
        }
        public async Task<List<Model.Email_connec>> Email_Connecs()
        {
            List<Model.Email_connec> email_Connecs = new List<Model.Email_connec>();
            email_Connecs.Add(new Model.Email_connec { Email = "Buiyen.cresoft@gmail.com", MoTa = "Kỹ thuật!" });
            email_Connecs.Add(new Model.Email_connec { Email = "20A72010129@students.hou.edu.vn", MoTa = "Kinh doanh!" });
            email_Connecs.Add(new Model.Email_connec { Email = "Nguyentruongminhtp1@gmail.com", MoTa = "Admin!" });
            return email_Connecs;
        }
        public async Task<bool> GetTextFromPDF(string filePath, string textContains)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString().Contains(textContains);
        }
        public async Task<int> PageSize(string file)
        {
            int pageSize = 0;
            using (PdfReader reader = new PdfReader(file))
            {
                if (!string.IsNullOrEmpty(file))
                {
                    pageSize = reader.NumberOfPages;
                }
            }
            return pageSize;
        }
        public async Task GetContextFromPDF(List<Model.Books> books, string textContains, GridControl gridControl)
        {
            List<Model.Books> Listbook = new List<Model.Books>();
            string contentPage = string.Empty;
            StringBuilder text = new StringBuilder();
            foreach (var item in books)
            {
                string fileName = await commom.Function.Instance.getFilePatd(item.LinkPDF);
                if (!string.IsNullOrEmpty(fileName))
                {
                    using (PdfReader reader = new PdfReader(fileName))
                    {
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            if (reader != null)
                            {
                                contentPage = PdfTextExtractor.GetTextFromPage(reader, i);
                                contentPage = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(contentPage));
                                if (contentPage.ToLower().Contains(textContains.Trim().ToLower()))
                                {
                                    Listbook.Add(new Model.Books
                                    {
                                        ID = item.ID,
                                        IDBai = item.IDBai,
                                        LinkPDF = item.LinkPDF,
                                        TenSach = item.TenSach,
                                        TenTuSach = item.TenTuSach,
                                        ViTri = i
                                    });

                                    gridControl.Invoke( new Action(() => { gridControl.DataSource = null; gridControl.DataSource = Listbook; }));
                                }
                            }

                        }
                    }
                }

            }
        }
        public async Task<Model.FileInfos> FileSave()
        {
            Model.FileInfos FileInfos = new Model.FileInfos();

            XtraOpenFileDialog xtraOpenFileDialog = new XtraOpenFileDialog();
            xtraOpenFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(xtraOpenFileDialog.FileName))
            {
                if (!Directory.Exists(Application.StartupPath + "/File/"))
                    Directory.CreateDirectory(Application.StartupPath + "/File");

                FileInfo fileInfos = new FileInfo(xtraOpenFileDialog.FileName);
                string destFileName = Application.StartupPath + "/File/" + fileInfos.Name;

                File.Copy(xtraOpenFileDialog.FileName, destFileName, true);
                FileInfo fileInfo = new FileInfo(destFileName);
                FileInfos.nameFile = fileInfo.Name;
                FileInfos.Path = fileInfo.FullName;
                FileInfos.size = fileInfo.Length;
                FileInfos.ex = fileInfo.Extension;
            }
            return FileInfos;
        }
     
            
    }

    public class Model
    {
        public class Email_connec
        {
            public string Email { get; set; }
            public string MoTa { get; set; }
        }
        public class SendEmailStatus
        {
            public string messeger { get; set; }
            public bool sendStatus { get; set; }
        }
        public class FindCheck
        {
            public string Tep { get; set; }
            public string Name { get; set; }
            public string Key { get; set; }
            public string Vitri { get; set; }
            public bool Valid { get; set; }
        }

        public class FileInfos
        {
            public string nameFile { get; set; }
            public string Path { get; set; }
            public double size { get; set; }
            public string ex { get; set; }
        }

        public class Books
        {
            public int ID { get; set; }
            public string TenTuSach { get; set; }
            public int? IDBai { get; set; }
            public string TenSach { get; set; }
            public int? LinkPDF { get; set; }
            public int ViTri { get; set; }
        }

    }
}