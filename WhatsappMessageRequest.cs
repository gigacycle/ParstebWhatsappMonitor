using System;
using System.Data;
using static ParstebWhatsapp.PTypes;
using static ParstebWhatsapp.DataAccess;

namespace ParstebWhatsapp
{
    public class WhatsappMessageRequest
    {
        public long Id;
        public long AdmitId;
        public long WhatsAppAdmitQueueId;
        public long ParsicAttachId;
        public string WhatsAppWebId;
        public string Message;
        public string FileName;
        public string WhatsAppNumber;
        public MessageStatus Status;
        public DateTime Sent;
        public DateTime Delivered;
        public DateTime Seen;
        public int SendStatus;
        public int Attempt;
        public DateTime CreateTime;
        public DateTime ModifyTime;

        public WhatsappMessageRequest(DataRow row)
        {
            Id = HasValue(row["id"]) ? (long)row["id"] : -1;
            WhatsAppAdmitQueueId = HasValue(row["whatsAppAdmitQueueId"]) ? (long)row["whatsAppAdmitQueueId"] : -1;
            AdmitId = HasValue(row["admitId"]) ? (long)row["admitId"] : -1;
            ParsicAttachId = HasValue(row["parsicAttachId"]) ? (long)row["parsicAttachId"] : -1;
            WhatsAppWebId = HasValue(row["whatsAppWebId"]) ? (string)row["whatsAppWebId"] : null;
            Message = HasValue(row["message"]) ? (string)row["message"] : null;
            FileName = HasValue(row["fileName"]) ? (string)row["fileName"] : null;
            WhatsAppNumber = HasValue(row["whatsappNumber"]) ? (string)row["whatsappNumber"] : null;
            Sent = HasValue(row["sent"]) ? (DateTime)row["sent"] : DateTime.MinValue;
            Delivered = HasValue(row["delivered"]) ? (DateTime)row["delivered"] : DateTime.MinValue;
            Seen = HasValue(row["seen"]) ? (DateTime)row["seen"] : DateTime.MinValue;
            SendStatus = HasValue(row["sendStatus"]) ? (int)row["sendStatus"] : -1;
            Attempt = HasValue(row["attempt"]) ? (int)row["attempt"] : -1;
            CreateTime = HasValue(row["createTime"]) ? (DateTime)row["createTime"] : DateTime.MinValue;
            ModifyTime = HasValue(row["modifiedTime"]) ? (DateTime)row["modifiedTime"] : DateTime.MinValue;
            Status = HasValue(row["status"]) ? (MessageStatus)(int)row["status"] : MessageStatus.None;
        }
    }
}
