using System;
using System.Data;
using System.Data.SqlClient;

namespace ParstebWhatsapp
{
    public class DataAccess
    {
        private static string _connectionString;

        public static string SqlConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public static DataTable GetSmsListFromServer()
        {
            DataTable result = null;

            string sql =
                     "SELECT * " +
                     "FROM Tbl_SmsTargetList Where(SendStatus = 0) OR (SendStatus is null)";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = CommandType.Text;

                        cnn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        cnn.Close();
                        if (ds != null && ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static bool UpdateStaus(long id, int status)
        {
            bool result = false;
            try
            {
                string sql =
                    @"UPDATE Tbl_SmsTargetList 
                        SET SendStatus = @status
                        WHERE id = @id";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;

                        cnn.Open();
                        int rowsAdded = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    result = true;
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetDoctorsCrmSettingsList()
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_GetDoctorsCrmSettingsList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        con.Close();
                        if (ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetOrgansCrmSettingsList()
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_GetOrgansCrmSettingsList", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        con.Close();
                        if (ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetOrganExtraPhoneNumbers(long organCrmSettingId)
        {
            DataTable result = null;
            string sqlQuery = "select * from Tbl_OrgansCrmContactList where Frk_organCrmSettingId = @organCrmSettingId";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.Add("@organCrmSettingId", SqlDbType.BigInt).Value = organCrmSettingId;
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        con.Close();
                        if (ds != null && ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetDoctorExtraPhoneNumbers(long doctorCrmSettingId)
        {
            DataTable result = null;
            string sqlQuery = "select * from Tbl_DoctorsCrmContactList where Frk_doctorCrmSettingId = @doctorCrmSettingId";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {
                        cmd.Parameters.Add("@doctorCrmSettingId", SqlDbType.BigInt).Value = doctorCrmSettingId;
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        con.Close();
                        if (ds != null && ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetWhatsappAdmitQueueList(DateTime from, DateTime to)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_WhatsappReadyAnswersList", con))
                    {
                        cmd.Parameters.Add("@ConfirmDateFrom", SqlDbType.DateTime).Value = from;
                        cmd.Parameters.Add("@ConfirmDateTo", SqlDbType.DateTime).Value = to;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        con.Close();
                        if (ds.Tables.Count > 0)
                            result = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                //LogHelper.Log(LogTarget.File, LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetWhatsappQueueListByAdmitQueueId(long whatsAppAdmitQueueId)
        {
            DataTable rv = null;
            string sql = @"SELECT *
                           FROM   Tbl_WhatsAppMessageQueue
                           WHERE  whatsAppAdmitQueueId = @whatsAppAdmitQueueId";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@whatsAppAdmitQueueId", SqlDbType.BigInt).Value = whatsAppAdmitQueueId;


                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        var ds = new DataSet();
                        da.Fill(ds);
                        cnn.Close();
                        if (ds.Tables.Count > 0)
                            rv = ds.Tables[0];
                    }
                }
            }
            catch (Exception e)
            {
                rv = null;
            }
            return rv;
        }

        public static long InsertUpdateOrganExtraPhoneNumber(long id, long organCrmSettingId, string name, string phone)
        {
            long result = -1;
            try
            {
                string sql =
                    @"IF EXISTS(SELECT * FROM dbo.Tbl_OrgansCrmContactList Where id = @id)
                        UPDATE dbo.Tbl_OrgansCrmContactList 
                        SET Frk_organCrmSettingId  = @organCrmSettingId,
                            Name          = @name,
                            PhoneNumber   = @phoneNumber
                        WHERE  id = @id
                    ELSE
                        INSERT INTO dbo.Tbl_OrgansCrmContactList (Frk_organCrmSettingId, Name, PhoneNumber) 
                        values(@organCrmSettingId, @name, @phoneNumber)
                    SELECT SCOPE_IDENTITY()";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        cmd.Parameters.Add("@organCrmSettingId", SqlDbType.BigInt).Value = organCrmSettingId;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phone;

                        cnn.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        cnn.Close();
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static long InsertUpdateDoctorExtraPhoneNumber(long id, long doctorCrmSettingId, string name, string phone)
        {
            long result = -1;
            try
            {
                string sql =
                    @"IF EXISTS(SELECT * FROM dbo.Tbl_DoctorsCrmContactList Where id = @id)
                        UPDATE dbo.Tbl_DoctorsCrmContactList 
                        SET Frk_doctorCrmSettingId  = @doctorCrmSettingId,
                            Name          = @name,
                            PhoneNumber   = @phoneNumber
                        WHERE  id = @id
                    ELSE
                        INSERT INTO dbo.Tbl_DoctorsCrmContactList (Frk_doctorCrmSettingId, Name, PhoneNumber) 
                        values(@doctorCrmSettingId, @name, @phoneNumber)
                    SELECT SCOPE_IDENTITY()";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        cmd.Parameters.Add("@doctorCrmSettingId", SqlDbType.BigInt).Value = doctorCrmSettingId;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@phoneNumber", SqlDbType.NVarChar).Value = phone;

                        cnn.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        cnn.Close();
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static bool DeleteAdmitQueueItem(long id)
        {
            bool result = false;
            try
            {
                string sql =
                    @"Delete From dbo.Tbl_WhatsAppAdmitQueue Where Prk_Id = @id
                      Delete From dbo.Tbl_WhatsAppMessageQueue Where whatsAppAdmitQueueId = @id";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;

                        cnn.Open();
                        var re = cmd.ExecuteNonQuery();
                        cnn.Close();
                        if (re > 0)
                            result = true;
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static bool DeleteDoctorExtraNumber(long id)
        {
            bool result = false;
            try
            {
                string sql =
                    @"Delete From dbo.Tbl_DoctorsCrmContactList Where id = @id";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;

                        cnn.Open();
                        var re =cmd.ExecuteNonQuery();
                        cnn.Close();
                        if (re > 0)
                            result = true;
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static bool DeleteOrganExtraNumber(long id)
        {
            bool result = false;
            try
            {
                string sql =
                    @"Delete From dbo.Tbl_OrgansCrmContactList Where id = @id";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;

                        cnn.Open();
                        var re = cmd.ExecuteNonQuery();
                        cnn.Close();
                        if (re > 0)
                            result = true;
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static long InsertIntoDoctorCrmSettings(long id, int doctorId, bool credited, bool sendToPatient, bool sendToDoctor, string phone1, string phone2)
        {
            long result = -1;
            try
            {
                string sql =
                    @"IF EXISTS(SELECT * FROM dbo.Tbl_DoctorsCrmSettings WHERE PRK_Id = @id)
                        UPDATE dbo.Tbl_DoctorsCrmSettings 
                        SET credited               = @credited,
                            sendToPatient          = @sendToPatient,
                            sendToDoctor           = @sendToDoctor,
                            phoneNumber1           = @phoneNumber1,
                            phoneNumber2           = @phoneNumber2
                        WHERE  PRK_Id = @id
                    ELSE
                        INSERT INTO dbo.Tbl_DoctorsCrmSettings (doctorId, credited, sendToPatient, sendToDoctor, phoneNumber1, phoneNumber2) 
                        values(@doctorId, @credited, @sendToPatient, @sendToDoctor, @phoneNumber1, @phoneNumber2)
                    SELECT SCOPE_IDENTITY()";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        cmd.Parameters.Add("@doctorId", SqlDbType.Int).Value = doctorId;
                        cmd.Parameters.Add("@credited", SqlDbType.Bit).Value = credited;
                        cmd.Parameters.Add("@sendToPatient", SqlDbType.Bit).Value = sendToPatient;
                        cmd.Parameters.Add("@sendToDoctor", SqlDbType.Bit).Value = sendToDoctor;
                        cmd.Parameters.Add("@phoneNumber1", SqlDbType.NVarChar).Value = phone1;
                        cmd.Parameters.Add("@phoneNumber2", SqlDbType.NVarChar).Value = phone2;

                        cnn.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        cnn.Close();
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static long InsertIntoOrganCrmSettings(long id, int organId, bool credited, bool sendToPatient, bool sendToAdmin, string phone1, string phone2)
        {
            long result = -1;
            try
            {
                string sql =
                    @"IF EXISTS(SELECT * FROM dbo.Tbl_OrgansCrmSettings WHERE PRK_Id = @id)
                        UPDATE dbo.Tbl_OrgansCrmSettings 
                        SET credited               = @credited,
                            sendToPatient          = @sendToPatient,
                            sendToOrganInCharge    = @sendToOrganInCharge,
                            phoneNumber1           = @phoneNumber1,
                            phoneNumber2           = @phoneNumber2
                        WHERE  PRK_Id = @id
                    ELSE
                        INSERT INTO dbo.Tbl_OrgansCrmSettings (organId, credited, sendToPatient, sendToOrganInCharge, phoneNumber1, phoneNumber2) 
                        values(@organId, @credited, @sendToPatient, @sendToOrganInCharge, @phoneNumber1, @phoneNumber2)
                    SELECT SCOPE_IDENTITY()";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        cmd.Parameters.Add("@organId", SqlDbType.Int).Value = organId;
                        cmd.Parameters.Add("@credited", SqlDbType.Bit).Value = credited;
                        cmd.Parameters.Add("@sendToPatient", SqlDbType.Bit).Value = sendToPatient;
                        cmd.Parameters.Add("@sendToOrganInCharge", SqlDbType.Bit).Value = sendToAdmin;
                        cmd.Parameters.Add("@phoneNumber1", SqlDbType.NVarChar).Value = phone1;
                        cmd.Parameters.Add("@phoneNumber2", SqlDbType.NVarChar).Value = phone2;

                        cnn.Open();
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                        cnn.Close();
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static void BatchStatusUpdate(long[] ids, int status)
        {
            foreach (long id in ids)
                UpdateStaus(id, status);
        }

        public static bool UpdateSetting(string name, string value)
        {
            bool result = false;
            string query =
                @"IF EXISTS(SELECT * FROM dbo.Tbl_Setting WHERE Name = @Name)
                    UPDATE dbo.Tbl_Setting 
                    SET Value = @Value
                    WHERE Name = @Name
                ELSE
                    INSERT INTO dbo.Tbl_Setting (Name, Value) 
                    Values(@Name, @Value)";

            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                        cmd.Parameters.Add("@Value", SqlDbType.NVarChar).Value = value;
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        int rowsAdded = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    result = true;
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static string GetSettingValue(string name, string defaultValue)
        {
            string result = defaultValue;
            string query = @"SELECT * FROM dbo.Tbl_Setting WHERE Name = @Name";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        int ordValue = reader.GetOrdinal("Value");
                        reader.Read();
                        result = reader.GetString(ordValue);
                        con.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return result;
        }

        public static bool HasValue(object cell)
        {
            if (cell == null | cell == DBNull.Value)
                return false;
            return true;
        }

    }
}
