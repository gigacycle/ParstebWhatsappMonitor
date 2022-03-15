using Logger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ParstebWhatsapp
{
    public class OrganCrmSetting
    {
        public long Id;
        public int OrganId;
        public bool Credited;
        public bool SendToPatient;
        public bool SendToOrganAdmin;
        public string PhoneNumber1;
        public string PhoneNumber2;
        public List<string> OtherNumbers;

        public OrganCrmSetting(DataRow row)
        {
            try
            {
                Id = DataAccess.HasValue(row["Prk_Id"]) ? (long)row["Prk_Id"] : -1;
                OrganId = DataAccess.HasValue(row["organId"]) ? (int)row["organId"] : -1;
                Credited = DataAccess.HasValue(row["credited"]) ? (bool)row["credited"] : false;
                SendToPatient = DataAccess.HasValue(row["sendToPatient"]) ? (bool)row["sendToPatient"] : false;
                SendToOrganAdmin = DataAccess.HasValue(row["sendToOrganInCharge"]) ? (bool)row["sendToOrganInCharge"] : false;
                PhoneNumber1 = DataAccess.HasValue(row["phoneNumber1"]) ? (string)row["phoneNumber1"] : null;
                PhoneNumber2 = DataAccess.HasValue(row["phoneNumber2"]) ? (string)row["phoneNumber2"] : null;
            }
            catch (Exception e)
            {
                Id = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[OrganCrmSetting\\OrganCrmSetting(row)] " + e.Message);
            }
            LoadOtherNumbers();
        }

        public OrganCrmSetting(SqlDataReader reader)
        {
            try
            {
                int ordId = reader.GetOrdinal("Prk_Id");
                int ordOrganId = reader.GetOrdinal("organId");
                int ordCredited = reader.GetOrdinal("credited");
                int ordSendToPatient = reader.GetOrdinal("sendToPatient");
                int ordSendToOrganInCharge = reader.GetOrdinal("sendToOrganInCharge");
                int ordPhoneNumber1 = reader.GetOrdinal("phoneNumber1");
                int ordPhoneNumber2 = reader.GetOrdinal("phoneNumber2");

                reader.Read();

                Id = DataAccess.HasValue(reader["Prk_Id"]) ? reader.GetInt64(ordId) : -1;
                OrganId = DataAccess.HasValue(reader["organId"]) ? reader.GetInt32(ordOrganId) : -1;
                Credited = DataAccess.HasValue(reader["credited"]) ? reader.GetBoolean(ordCredited) : false;
                SendToPatient = DataAccess.HasValue(reader["sendToPatient"]) ? reader.GetBoolean(ordSendToPatient) : false;
                SendToOrganAdmin = DataAccess.HasValue(reader["sendToOrganInCharge"]) ? reader.GetBoolean(ordSendToOrganInCharge) : false;
                PhoneNumber1 = DataAccess.HasValue(reader["phoneNumber1"]) ? reader.GetString(ordPhoneNumber1) : null;
                PhoneNumber2 = DataAccess.HasValue(reader["phoneNumber2"]) ? reader.GetString(ordPhoneNumber2) : null;
            }
            catch (Exception e)
            {
                Id = -1;
                LogHelper.Log(LogTarget.File, LogType.Error, "[OrganCrmSetting\\OrganCrmSetting(reader)] " + e.Message);
            }
            LoadOtherNumbers();
        }

        private void LoadOtherNumbers()
        {
            try
            {
                if (Id <= 0) return;
                DataTable list = DataAccess.GetOrganCrmContactList(Id);
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
                LogHelper.Log(LogTarget.File, LogType.Error, "[OrganCrmSetting\\LoadOtherNumbers] " + e.Message);
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
