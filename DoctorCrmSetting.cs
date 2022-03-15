using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParstebWhatsapp
{
    public class DoctorCrmSetting
    {
        public long Id;
        public int DoctorId;
        public bool Credited;
        public bool SendToPatient;
        public bool SendToDoctor;
        public string PhoneNumber1;
        public string PhoneNumber2;
        public List<string> OtherNumbers;

        public DoctorCrmSetting(DataRow row)
        {
            try
            {
                Id = DataAccess.HasValue(row["Prk_Id"]) ? (long)row["Prk_Id"] : -1;
                DoctorId = DataAccess.HasValue(row["doctorId"]) ? (int)row["doctorId"] : -1;
                Credited = DataAccess.HasValue(row["credited"]) ? (bool)row["credited"] : false;
                SendToPatient = DataAccess.HasValue(row["sendToPatient"]) ? (bool)row["sendToPatient"] : false;
                SendToDoctor = DataAccess.HasValue(row["sendToDoctor"]) ? (bool)row["sendToDoctor"] : false;
                PhoneNumber1 = DataAccess.HasValue(row["phoneNumber1"]) ? (string)row["phoneNumber1"] : null;
                PhoneNumber2 = DataAccess.HasValue(row["phoneNumber2"]) ? (string)row["phoneNumber2"] : null;
            }
            catch (Exception e)
            {
                Id = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[DoctorCrmSetting\\DoctorCrmSetting(row)] " + e.Message);
            }
            LoadOtherNumbers();
        }

        public DoctorCrmSetting(SqlDataReader reader)
        {
            try
            {
                int ordId = reader.GetOrdinal("PRK_Id");
                int ordDoctorId = reader.GetOrdinal("doctorId");
                int ordCredited = reader.GetOrdinal("credited");
                int ordSendToPatient = reader.GetOrdinal("sendToPatient");
                int ordSendToDoctor = reader.GetOrdinal("sendToDoctor");
                int ordPhoneNumber1 = reader.GetOrdinal("phoneNumber1");
                int ordPhoneNumber2 = reader.GetOrdinal("phoneNumber2");

                reader.Read();

                Id = DataAccess.HasValue(reader["PRK_Id"]) ? reader.GetInt64(ordId) : -1;
                DoctorId = DataAccess.HasValue(reader["doctorId"]) ? reader.GetInt32(ordDoctorId) : -1;
                Credited = DataAccess.HasValue(reader["credited"]) ? reader.GetBoolean(ordCredited) : false;
                SendToPatient = DataAccess.HasValue(reader["sendToPatient"]) ? reader.GetBoolean(ordSendToPatient) : false;
                SendToDoctor = DataAccess.HasValue(reader["sendToDoctor"]) ? reader.GetBoolean(ordSendToDoctor) : false;
                PhoneNumber1 = DataAccess.HasValue(reader["phoneNumber1"]) ? reader.GetString(ordPhoneNumber1) : null;
                PhoneNumber2 = DataAccess.HasValue(reader["phoneNumber2"]) ? reader.GetString(ordPhoneNumber2) : null;
            }
            catch (Exception e)
            {
                Id = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[DoctorCrmSetting\\DoctorCrmSetting(reader)] " + e.Message);
            }
            LoadOtherNumbers();
        }

        private void LoadOtherNumbers()
        {
            try
            {
                if (Id <= 0) return;
                DataTable list = DataAccess.GetDoctorCrmContactList(Id);
                if (list == null || list.Rows.Count == 0)
                    return;
                if (OtherNumbers == null) OtherNumbers = new List<string>();
                OtherNumbers.Clear();
                foreach (DataRow row in list.Rows)
                {
                    var phoneNumber = DataAccess.HasValue(row["PhoneNumber"]) ? row["PhoneNumber"].ToString() : null;
                    if (!string.IsNullOrEmpty(phoneNumber))
                        OtherNumbers.Add(phoneNumber);
                }
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, "[DoctorCrmSetting\\LoadOtherNumbers] " + e.Message);
            }
        }

        public string[] GetPhoneNumbers()
        {
            List<string> rv = new List<string>();
            if (!string.IsNullOrEmpty(PhoneNumber1))
                rv.Add(PhoneNumber1);
            if (!string.IsNullOrEmpty(PhoneNumber2))
                rv.Add(PhoneNumber2);
            if (OtherNumbers != null)
                foreach (string number in OtherNumbers)
                    if (!string.IsNullOrEmpty(number))
                        rv.Add(number);
            return rv.ToArray();
        }
    }
}
