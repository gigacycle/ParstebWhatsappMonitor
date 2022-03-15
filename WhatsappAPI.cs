using Logger;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ParstebWhatsapp
{
    public class WhatsappAPI
    {
        public static string BaseUrl { get; set; }

        public static string SendMessage(long messageId, string phoneNumber, string admitId, string messageText, byte[] file, string fileExtension)
        {
            string result = "";

            Message msg = new Message()
            {
                MessageID = messageId,
                To = phoneNumber,
                AdmitID = admitId,
                MessageBody = messageText,
            };

            if (file == null)
                msg.File = null;
            else
                msg.File = new MessageFile()
                {
                    Bytes = new List<byte>(file),
                    Extension = fileExtension
                };

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(BaseUrl + "api/send");
                request.ContentType = "application/json;charset=utf-8";
                request.Method = "POST";
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(msg);
                    streamWriter.Write(json);
                }

                var response = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    System.Threading.Thread.Sleep(100);
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                result = "error: " + e.Message;
                LogHelper.Log(LogTarget.File, LogType.Error, "[WhatsappWebservice\\SendMessage\\{messageId:" + messageId + ", admitId:" + admitId + "}] " + e.Message);
            }

            return result;
        }

        class Message
        {
            public long MessageID { get; set; }
            public string To { get; set; }
            public string AdmitID { get; set; }
            public string MessageBody { get; set; }
            public MessageFile File { get; set; }
        }
        class MessageFile
        {
            public string Extension { get; set; }
            public List<byte> Bytes { get; set; }
        }
    }
}
