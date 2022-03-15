using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParstebWhatsapp
{
    public class WhatsappAdmitQueueItem
    {
        public long Id;
        public string StatusTitle;
        public int StatusId;
        public int ParsicSmsQueueId;
        public int AdmitId;
        public string AdmitDate;
        public string AdmitTime;
        public bool Gender;
        public string PatientName;
        public bool Emergency;
        public string MobileNumber;
        public string MessageText;
        public string ConfirmDate;
        public string ConfirmTime;
        public int ContractorId;
        public int DoctorId;
        public string DoctorName;
        public int OrganId;
        public string OrganName;
        public int RemainedFee;
        public string ResultLink;
        public DateTime AddedTime;
        public List<AttachedFile> AttachedFiles;

        public WhatsappAdmitQueueItem(DataRow row)
        {
            try
            {
                Id = DataAccess.HasValue(row["Prk_Id"]) ? (long)row["Prk_Id"] : -1;
                StatusTitle = DataAccess.HasValue(row["Title"]) ? (string)row["Title"] : null;
                StatusId = DataAccess.HasValue(row["StatusId"]) ? (int)row["StatusId"] : -1;
                ParsicSmsQueueId = DataAccess.HasValue(row["Prk_SMS_Queue_AutoID"]) ? (int)row["Prk_SMS_Queue_AutoID"] : -1;
                AdmitId = DataAccess.HasValue(row["Frk_AdmitID"]) ? (int)row["Frk_AdmitID"] : -1;
                AdmitDate = DataAccess.HasValue(row["Str_AdmitDate"]) ? (string)row["Str_AdmitDate"] : null;
                AdmitTime = DataAccess.HasValue(row["Str_AdmitTime"]) ? (string)row["Str_AdmitTime"] : null;
                Gender = DataAccess.HasValue(row["Int_Sex"]) ? ((int)row["Int_Sex"]) == 1 : false;
                PatientName = DataAccess.HasValue(row["Str_PatientName"]) ? (string)row["Str_PatientName"] : null;
                Emergency = DataAccess.HasValue(row["Int_Emeregency"]) ? ((int)row["Int_Emeregency"]) == 1 : false;
                MobileNumber = DataAccess.HasValue(row["Str_MobileNumber"]) ? (string)row["Str_MobileNumber"] : null;
                MessageText = DataAccess.HasValue(row["Str_MessageText"]) ? (string)row["Str_MessageText"] : null;
                ConfirmDate = DataAccess.HasValue(row["Str_Logged_Date"]) ? (string)row["Str_Logged_Date"] : null;
                ConfirmTime = DataAccess.HasValue(row["Str_Logged_Time"]) ? (string)row["Str_Logged_Time"] : null;
                ContractorId = DataAccess.HasValue(row["Frk_PrescriptionContractor"]) ? (int)row["Frk_PrescriptionContractor"] : -1;
                DoctorId = DataAccess.HasValue(row["Frk_Doctors"]) ? (int)row["Frk_Doctors"] : -1;
                DoctorName = DataAccess.HasValue(row["Str_Doctor"]) ? (string)row["Str_Doctor"] : null;
                OrganId = DataAccess.HasValue(row["Int_OrgID"]) ? (int)row["Int_OrgID"] : -1;
                OrganName = DataAccess.HasValue(row["Str_OrgName"]) ? (string)row["Str_OrgName"] : null;
                RemainedFee = DataAccess.HasValue(row["Int_Baghimande"]) ? (int)row["Int_Baghimande"] : 0;
                ResultLink = DataAccess.HasValue(row["Str_ResultLink"]) ? (string)row["Str_ResultLink"] : null;
                AddedTime = DataAccess.HasValue(row["AddedTime"]) ? (DateTime)row["AddedTime"] : DateTime.MinValue;
            }
            catch (Exception e)
            {
                ParsicSmsQueueId = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[WhatsappAdmitQueueItem\\WhatsappAdmitQueueItem(row)] " + e.Message);
            }
        }

        public WhatsappAdmitQueueItem(SqlDataReader reader)
        {
            try
            {
                int ordId = reader.GetOrdinal("Prk_Id");
                int ordTitle = reader.GetOrdinal("Title");
                int ordStatusId = reader.GetOrdinal("StatusId");
                int ordParsicSmsQueueId = reader.GetOrdinal("Prk_SMS_Queue_AutoID");
                int ordAdmitId = reader.GetOrdinal("Frk_AdmitID");
                int ordMessageText = reader.GetOrdinal("Str_MessageText");
                int ordMobileNumber = reader.GetOrdinal("Str_MobileNumber");
                int ordRemaindFee = reader.GetOrdinal("Int_Baghimande");
                int ordResultLink = reader.GetOrdinal("Str_ResultLink");

                reader.Read();

                Id = DataAccess.HasValue(reader["Prk_Id"]) ? reader.GetInt32(ordId) : -1;
                StatusTitle = DataAccess.HasValue(reader["Title"]) ? reader.GetString(ordTitle) : null;
                StatusId = DataAccess.HasValue(reader["StatusId"]) ? reader.GetInt32(ordStatusId) : 0;
                ParsicSmsQueueId = DataAccess.HasValue(reader["Prk_SMS_Queue_AutoID"]) ? reader.GetInt32(ordParsicSmsQueueId) : -1;
                AdmitId = DataAccess.HasValue(reader["Frk_AdmitID"]) ? reader.GetInt32(ordAdmitId) : -1;
                MessageText = DataAccess.HasValue(reader["Str_MessageText"]) ? reader.GetString(ordMessageText) : null;
                MobileNumber = DataAccess.HasValue(reader["Str_MobileNumber"]) ? reader.GetString(ordMobileNumber) : null;
                RemainedFee = DataAccess.HasValue(reader["Int_Baghimande"]) ? reader.GetInt32(ordRemaindFee) : 0;
                ResultLink = DataAccess.HasValue(reader["Str_ResultLink"]) ? reader.GetString(ordResultLink) : null;
            }
            catch (Exception e)
            {
                Id = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[WhatsappAdmitQueueItem\\WhatsappAdmitQueueItem(reader)] " + e.Message);
            }
        }

        public void AddFile(AttachedFile attachedFile)
        {
            if (attachedFile != null)
            {
                if (AttachedFiles == null) AttachedFiles = new List<AttachedFile>();
                AttachedFiles.Add(attachedFile);
            }
        }

        public void AddFiles(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
                return;

            if (AttachedFiles == null) AttachedFiles = new List<AttachedFile>();
            foreach (DataRow row in dt.Rows)
            {
                AttachedFile aFile = new AttachedFile(row);
                if (aFile.AdmitId > 0)
                    AttachedFiles.Add(aFile);
            }
        }
    }
}
