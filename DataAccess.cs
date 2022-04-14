using Logger;
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
                        cmd.Parameters.Add("@ConfirmDateTo", SqlDbType.DateTime).Value = to.AddMinutes(1439);
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
                LogHelper.Log(LogTarget.File, LogType.Error, e.Message);
            }
            return result;
        }

        public static DataTable GetWhatsappAdmitQueueItem(int queueId, int admitId)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_GetWhatsappReadyAnswerItem", con))
                    {
                        if (queueId > 0)
                            cmd.Parameters.Add("@QueueId", SqlDbType.Int).Value = queueId;
                        if (admitId > 0)
                            cmd.Parameters.Add("@admitId", SqlDbType.Int).Value = admitId;
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
                LogHelper.Log(LogTarget.File, LogType.Error, e.Message);
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
            catch (Exception e) { LogHelper.Log(LogTarget.File, LogType.Error, e.Message); }
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

        public static bool IsUsernameExist(string username)
        {
            bool rv = false;
            string sql = @"SELECT COUNT(username) AS CNT
                           FROM   Tbl_PcrUsers
                           WHERE  username = @username";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                        cnn.Open();
                        int result = (int)cmd.ExecuteScalar();
                        cnn.Close();
                        if (result > 0) rv = true;
                    }
                }
            }
            catch { }
            return rv;
        }

        public static PcrUser GetUserInfo(string username)
        {
            PcrUser rv = null;
            string sql = @"SELECT *
                           FROM   Tbl_PcrUsers
                           WHERE  username = @username";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        int ordId = reader.GetOrdinal("PRK_Id");
                        int ordUsername = reader.GetOrdinal("username");
                        int ordPassword = reader.GetOrdinal("password");
                        int ordUserType = reader.GetOrdinal("userType");
                        int ordName = reader.GetOrdinal("name");
                        int ordLastName = reader.GetOrdinal("lastName");
                        int ordLastActivityTimeStamp = reader.GetOrdinal("lastActivityTimeStamp");
                        int ordIncorrectPasswordAttempts = reader.GetOrdinal("IncorrectPasswordAttempts");

                        reader.Read();

                        rv = new PcrUser(
                            reader.GetInt32(ordId),
                            reader.GetString(ordUsername),
                            reader.GetString(ordPassword),
                            reader.GetInt32(ordUserType),
                            reader.GetString(ordName),
                            reader.GetString(ordLastName),
                            reader.GetDateTime(ordLastActivityTimeStamp),
                            reader.GetInt32(ordIncorrectPasswordAttempts));

                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return rv;
        }

        public static PcrUser GetUserInfo(int userId)
        {
            PcrUser rv = null;
            string sql = @"SELECT *
                           FROM   Tbl_PcrUsers
                           WHERE  PRK_Id = @userId";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@userId", SqlDbType.Int).Value = userId;

                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        int ordId = reader.GetOrdinal("PRK_Id");
                        int ordUsername = reader.GetOrdinal("username");
                        int ordPassword = reader.GetOrdinal("password");
                        int ordUserType = reader.GetOrdinal("userType");
                        int ordName = reader.GetOrdinal("name");
                        int ordLastName = reader.GetOrdinal("lastName");
                        int ordLastActivityTimeStamp = reader.GetOrdinal("lastActivityTimeStamp");
                        int ordIncorrectPasswordAttempts = reader.GetOrdinal("IncorrectPasswordAttempts");

                        reader.Read();

                        rv = new PcrUser(
                            reader.GetInt32(ordId),
                            reader.GetString(ordUsername),
                            reader.GetString(ordPassword),
                            reader.GetInt32(ordUserType),
                            reader.GetString(ordName),
                            reader.GetString(ordLastName),
                            reader.GetDateTime(ordLastActivityTimeStamp),
                            reader.GetInt32(ordIncorrectPasswordAttempts));

                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return rv;
        }

        public static int UpdateUserIncorrectPassword(string username, int incorrectPasswordAttempts)
        {
            int rowsAffected = 0;
            try
            {
                string sql =
                      @"UPDATE dbo.Tbl_PcrUsers 
                        SET IncorrectPasswordAttempts = @incorrectPasswordAttempts,
                            lastActivityTimeStamp = @lastActivityTimeStamp
                        WHERE username = @username";

                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@incorrectPasswordAttempts", SqlDbType.Int).Value = incorrectPasswordAttempts;
                        cmd.Parameters.Add("@lastActivityTimeStamp", SqlDbType.DateTime).Value = DateTime.Now;
                        cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                        cnn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message);
            }
            return rowsAffected;
        }

        public static bool InsertIntoPcrLog(PcrUser user, string description)
        {
            bool result = false;
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Cspc_Insert_PcrUserLog", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)).Value = user.Id;
                        cmd.Parameters.Add(new SqlParameter("@Desc", SqlDbType.NVarChar)).Value = description;


                        cnn.Open();
                        int rowsAdded = cmd.ExecuteNonQuery();
                        cnn.Close();
                        if (rowsAdded > 0)
                            result = true;
                    }
                }
            }
            catch (Exception e) { Logger.LogHelper.Log(Logger.LogTarget.File, Logger.LogType.Error, e.Message); }
            return result;
        }

        public static DataTable GetAttachedTestResult(int admitId)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_GetAttachedTestResult", con))
                    {
                        cmd.Parameters.Add("@admitId", SqlDbType.Int).Value = admitId;
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
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetAttachedTestResult] " + e.Message);
            }
            return result;
        }

        public static DataTable GetAttachedTestResultById(long attachId)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SPC_GetAttachedTestResultById", con))
                    {
                        cmd.Parameters.Add("@attachId", SqlDbType.Int).Value = Convert.ToInt32(attachId);
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
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetAttachedTestResult] " + e.Message);
            }
            return result;
        }

        public static long CreateUpdateWhatsappMessage(long id, string whatsAppId, long whatsAppAdmitQueueId, long admitId, string phoneNumber, long parsicAttachId, string messageBody, string fileName, int status, int sendStatus, int attempt)
        {
            long result = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Cspc_CreateUpdateWhatsAppMessage", con))
                    {
                        if (id > 0)
                            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        if (whatsAppAdmitQueueId > 0)
                            cmd.Parameters.Add("@whatsAppAdmitQueueId", SqlDbType.BigInt).Value = whatsAppAdmitQueueId;
                        if (admitId > 0)
                            cmd.Parameters.Add("@admitId", SqlDbType.BigInt).Value = admitId;
                        if (parsicAttachId > 0)
                            cmd.Parameters.Add("@parsicAttachId", SqlDbType.BigInt).Value = parsicAttachId;
                        if (!string.IsNullOrEmpty(whatsAppId))
                            cmd.Parameters.Add("@whatsAppWebId", SqlDbType.NVarChar).Value = whatsAppId;
                        if (!string.IsNullOrEmpty(messageBody))
                            cmd.Parameters.Add("@message", SqlDbType.NVarChar).Value = messageBody;
                        if (!string.IsNullOrEmpty(fileName))
                            cmd.Parameters.Add("@fileName", SqlDbType.NVarChar).Value = fileName;
                        if (!string.IsNullOrEmpty(phoneNumber))
                            cmd.Parameters.Add("@whatsappNumber", SqlDbType.NVarChar).Value = phoneNumber;
                        if (status > -1)
                            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                        if (sendStatus > -1)
                            cmd.Parameters.Add("@sendStatus", SqlDbType.Int).Value = sendStatus;
                        if (attempt > 0)
                            cmd.Parameters.Add("@attempt", SqlDbType.Int).Value = attempt;

                        cmd.CommandType = CommandType.StoredProcedure;

                        con.Open();
                        object sqlResult = cmd.ExecuteScalar();
                        if (sqlResult.GetType() != typeof(DBNull))
                            result = Convert.ToInt64(sqlResult);
                        con.Close();
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\CreateUpdateWhatsappMessage] " + e.Message);
            }
            return result;
        }

        public static DataTable GetWhatsappNotSentMessages(int maxAttempt)
        {
            DataTable result = null;
            string query = @"SELECT * FROM dbo.Tbl_WhatsAppMessageQueue Where attempt < @maxAttempt and (sendStatus is null or (sendStatus <> 1 and sendStatus <> 10))";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@maxAttempt", SqlDbType.Int).Value = maxAttempt;

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
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetWhatsappNotSentMessages] " + e.Message);
            }
            return result;
        }

        public static DataTable GetDoctorCrmContactList(long doctorCrmSettingId)
        {
            DataTable result = null;
            string query = @"select * from Tbl_DoctorsCrmContactList where Frk_doctorCrmSettingId = @doctorSettingId";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@doctorSettingId", SqlDbType.BigInt).Value = doctorCrmSettingId;

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
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetDoctorCrmContactList] " + e.Message);
            }
            return result;
        }

        public static DataTable GetOrganCrmContactList(long organCrmSettingId)
        {
            DataTable result = null;
            string query = @"select * from Tbl_OrgansCrmContactList where Frk_organCrmSettingId = @organSettingId";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@organSettingId", SqlDbType.BigInt).Value = organCrmSettingId;

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
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetOrganCrmContactList] " + e.Message);
            }
            return result;
        }

        public static WhatsappAdmitQueueItem GetWhatsappAdmitQueueItemById(long admitQueueId)
        {
            WhatsappAdmitQueueItem rv = null;
            string sql = @"SELECT top(1) *
                           FROM   Tbl_WhatsAppAdmitQueue
                           WHERE  Prk_Id = @admitQueueId";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@admitQueueId", SqlDbType.BigInt).Value = admitQueueId;

                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                            rv = new WhatsappAdmitQueueItem(reader);
                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                rv = null;
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetWhatsappAdmitQueueItemById] " + e.Message);
            }
            return rv;
        }

        public static long CreateUpdateWhatsappAdmitQueue(long id, long parsicSmsQueueId, long admitId, long statusId)
        {
            long result = -1;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Cspc_CreateUpdateWhatsAppAdmitQueue", con))
                    {
                        if (id > 0)
                            cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                        if (parsicSmsQueueId > 0)
                            cmd.Parameters.Add("@parsicSmsQueueId", SqlDbType.BigInt).Value = parsicSmsQueueId;
                        if (admitId > 0)
                            cmd.Parameters.Add("@admitId", SqlDbType.BigInt).Value = admitId;
                        if (statusId >= 0)
                            cmd.Parameters.Add("@statusId", SqlDbType.BigInt).Value = statusId;

                        cmd.CommandType = CommandType.StoredProcedure;

                        con.Open();
                        object sqlResult = cmd.ExecuteScalar();
                        if (sqlResult.GetType() != typeof(DBNull))
                            result = Convert.ToInt64(sqlResult);
                        con.Close();
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\CreateUpdateWhatsappAdmitQueue] " + e.Message);
            }
            return result;
        }

        public static long CreateUpdateWhatsappMessage(WhatsappMessageRequest whatsappMessageRequest)
        {
            return CreateUpdateWhatsappMessage(whatsappMessageRequest.Id, whatsappMessageRequest.WhatsAppWebId, whatsappMessageRequest.WhatsAppAdmitQueueId, whatsappMessageRequest.AdmitId, whatsappMessageRequest.WhatsAppNumber, whatsappMessageRequest.ParsicAttachId, whatsappMessageRequest.Message, whatsappMessageRequest.FileName, (int)whatsappMessageRequest.Status, whatsappMessageRequest.SendStatus, whatsappMessageRequest.Attempt);
        }

        public static OrganCrmSetting GetOrganCrmSettings(long organId)
        {
            OrganCrmSetting rv = null;
            string sql = @"SELECT top(1) *
                           FROM   Tbl_OrgansCrmSettings
                           WHERE  organId = @organId";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@organId", SqlDbType.BigInt).Value = organId;

                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                            rv = new OrganCrmSetting(reader);
                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                rv = null;
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetOrganCrmSettings] " + e.Message);
            }
            return rv;
        }

        public static DoctorCrmSetting GetDoctorCrmSettings(long doctorId)
        {
            DoctorCrmSetting rv = null;
            string sql = @"SELECT top(1) *
                           FROM   Tbl_DoctorsCrmSettings
                           WHERE  doctorId = @doctorId";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add("@doctorId", SqlDbType.BigInt).Value = doctorId;

                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                            rv = new DoctorCrmSetting(reader);
                        cnn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                rv = null;
                LogHelper.Log(LogTarget.File, LogType.Error, "[DataAccess\\GetDoctorCrmSettings] " + e.Message);
            }
            return rv;
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
