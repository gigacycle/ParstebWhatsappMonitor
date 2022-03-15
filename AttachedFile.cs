using Logger;
using System;
using System.Data;
using System.Net;

namespace ParstebWhatsapp
{
    public class AttachedFile
    {
        public int AttachId;
        public int AdmitId;
        public int TestID;
        public byte[] File;
        public string FileExtension;
        public bool HasImage;
        public byte[] ImageFile;
        public int Order;

        public AttachedFile() { }

        public AttachedFile(DataRow row)
        {
            try
            {
                AttachId = DataAccess.HasValue(row["Prk_AutoID"]) ? (int)row["Prk_AutoID"] : -1;
                AdmitId = DataAccess.HasValue(row["Frk_AdmitID"]) ? (int)row["Frk_AdmitID"] : -1;
                TestID = DataAccess.HasValue(row["Frk_TestID"]) ? (int)row["Frk_TestID"] : -1;
                FileExtension = DataAccess.HasValue(row["Str_FileExtension"]) ? (string)row["Str_FileExtension"] : null;
                File = DataAccess.HasValue(row["Bin_File"]) ? (byte[])row["Bin_File"] : null;
                HasImage = DataAccess.HasValue(row["Int_HaveImage"]) ? ((int)row["Int_HaveImage"] == 1) : false;
                ImageFile = DataAccess.HasValue(row["Img_File"]) ? (byte[])row["Img_File"] : null;
                Order = DataAccess.HasValue(row["Int_Order"]) ? (int)row["Int_Order"] : 0;
            }
            catch (Exception e)
            {
                AdmitId = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[AttachedFile\\AttachedFile(row)] " + e.Message);
            }
        }

        public static byte[] DownloadTestResult(string url)
        {
            byte[] result = null;
            try
            {
                string html = "";
                using (WebDownload wchtml = new WebDownload(60000))
                {
                    html = wchtml.DownloadString(url);
                }
                string[] lines = html.Split('\n');
                string qryString = null;
                foreach (string line in lines)
                    if (line.ToLower().Contains("var url = '/accountumm/"))
                    {
                        Console.WriteLine(line);
                        int i = line.IndexOf("'");
                        qryString = line.Substring(i + 1);
                        qryString = qryString.Replace("';", "");
                        break;
                    }
                if (!string.IsNullOrEmpty(qryString))
                {
                    string protocol = url.StartsWith("https") ? "https://" : (url.StartsWith("http") ? "http://" : "");
                    string baseUrl = url.Replace(protocol, "");
                    int i = baseUrl.IndexOf('/');
                    baseUrl = baseUrl.Substring(0, i);
                    Uri uri = new Uri(protocol + baseUrl + qryString);
                    using (WebDownload wcwto = new WebDownload(60000))
                    {
                        result = wcwto.DownloadData(uri);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, "[AttachedFile\\DownloadTestResult] " + e.Message);
            }
            return result;
        }

        public class WebDownload : WebClient
        {
            /// <summary>
            /// Time in milliseconds
            /// </summary>
            public int Timeout { get; set; }

            public WebDownload() : this(60000) { }

            public WebDownload(int timeout)
            {
                this.Timeout = timeout;
            }

            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request != null)
                {
                    request.Timeout = this.Timeout;
                }
                return request;
            }
        }
    }
}
