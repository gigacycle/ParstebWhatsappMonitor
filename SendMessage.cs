using Logger;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ParstebWhatsapp
{
    public class SendMessage
    {
        /// <summary>
        /// Send a message to a 
        /// </summary>
        /// <param name="qItem"></param>
        /// <param name="organExceptions"></param>
        /// <param name="maxDebtAmount"></param>
        /// <param name="dontSendToPatientsByDefault"></param>
        /// <param name="patientGreetingMessage"></param>
        /// <param name="debtorMessage"></param>
        /// <param name="organMessage"></param>
        /// <param name="doctorMessage"></param>
        public static void Send(WhatsappAdmitQueueItem qItem, string organExceptions, long maxDebtAmount, bool dontSendToPatientsByDefault, string patientGreetingMessage, string debtorMessage, string organMessage, string doctorMessage)
        {
            try
            {
                if (qItem.Id <= 0)
                {
                    var wpMsgId = DataAccess.CreateUpdateWhatsappAdmitQueue(-1, qItem.ParsicSmsQueueId, qItem.AdmitId, 0);
                    if (wpMsgId > 0)
                        qItem.Id = wpMsgId;
                }

                string[] strExOrganIds = organExceptions.Split(',');
                List<int> organExceptionIds = new List<int>();
                foreach (string item in strExOrganIds)
                {
                    int organId = -1;
                    int.TryParse(item.Trim(), out organId);
                    if (organId > 0)
                        organExceptionIds.Add(organId);
                }

                var patientName = (qItem.Gender ? "جناب آقای" : "سرکار خانم") + " " + qItem.PatientName;

                //============= Step 1 : Checking Organ Contractor =================
                if (qItem.ContractorId > 0 && !organExceptionIds.Contains(qItem.ContractorId)) // exception (@Exceptions = [1131,...]) ارسالی شرکت، ارسالی پرسنل،...
                {
                    var orgCrmSettings = DataAccess.GetOrganCrmSettings(qItem.ContractorId);
                    organMessage = organMessage.Replace("@N", patientName).Replace("@B", String.Format("{0:#,0}", qItem.RemainedFee) + " ریال").Replace("@P", qItem.AdmitId.ToString());

                    if (orgCrmSettings != null && orgCrmSettings.Id > 0 && orgCrmSettings.GetPhoneNumbers().Length > 0) // Whene organ contractor settings is exist and at least a phone number is exist :
                    {
                        sendTestResult(qItem, patientGreetingMessage, debtorMessage, maxDebtAmount, orgCrmSettings.Credited, orgCrmSettings.SendToPatient, orgCrmSettings.SendToOrganAdmin, orgCrmSettings.GetPhoneNumbers(), organMessage, false);
                    }
                    else
                    {
                        sendTestResult(qItem, patientGreetingMessage, debtorMessage, maxDebtAmount, false, true, false, null, null, true);
                    }
                }
                //============= Step 2 : Checking Doctor Contractor =================
                else
                {
                    var doctorCrmSettings = DataAccess.GetDoctorCrmSettings(qItem.DoctorId);
                    doctorMessage = doctorMessage.Replace("@N", patientName).Replace("@B", String.Format("{0:#,0}", qItem.RemainedFee) + " ریال").Replace("@P", qItem.AdmitId.ToString());
                    if (doctorCrmSettings != null && doctorCrmSettings.Id > 0 && doctorCrmSettings.GetPhoneNumbers().Length > 0) // When doctor contractor settings is exist and at least a phone number is exist :
                    {
                        sendTestResult(qItem, patientGreetingMessage, debtorMessage, maxDebtAmount, doctorCrmSettings.Credited, doctorCrmSettings.SendToPatient, doctorCrmSettings.SendToDoctor, doctorCrmSettings.GetPhoneNumbers(), doctorMessage, false);
                    }
                    else
                    {
                        sendTestResult(qItem, patientGreetingMessage, debtorMessage, maxDebtAmount, false, true, false, null, null, true);
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.Log(LogTarget.File, LogType.Error, "[SendMessage\\Send] " + e.Message);
            }
        }

        private static bool sendTestResult(WhatsappAdmitQueueItem qItem, string patientGreetingMessage, string debtorMessage, long maxDebtAmount, bool credited, bool sendToPatient, bool sendToOthers, string[] otherNumbers, string thirdPartyGreetingMessage, bool isPersonalRequest)
        {
            bool success = true;

            bool isPatientDebtor = qItem.RemainedFee > maxDebtAmount;

            var attachedFiles = DataAccess.GetAttachedTestResult(qItem.AdmitId); // Getting Attached Files
            if (attachedFiles != null)
                qItem.AddFiles(attachedFiles);
            byte[] testResult = AttachedFile.DownloadTestResult(qItem.ResultLink);
            if (testResult != null && testResult.Length > 0)
                qItem.AddFile(new AttachedFile
                {
                    AdmitId = qItem.AdmitId,
                    AttachId = -1,
                    File = testResult,
                    FileExtension = "PDF"
                });

            var patientName = (qItem.Gender ? "جناب آقای" : "سرکار خانم") + " " + qItem.PatientName;

            debtorMessage = debtorMessage.Replace("@N", patientName).Replace("@B", String.Format("{0:#,0}", qItem.RemainedFee) + " ریال");
            patientGreetingMessage = patientGreetingMessage.Replace("@N", patientName).Replace("@B", String.Format("{0:#,0}", qItem.RemainedFee) + " ریال");

            if (isPersonalRequest) // personal request
            {
                if (isPatientDebtor) // debtor
                {
                    if (MessageBox.Show("The patient '" + qItem.PatientName + "' with admit Id (" + qItem.AdmitId + ") is a debtor! Do you want to continue?", "Force Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        DataAccess.CreateUpdateWhatsappAdmitQueue(qItem.Id, qItem.ParsicSmsQueueId, qItem.AdmitId, 4);
                        return false;
                    }
                    sendTestResultToPatient(qItem, patientGreetingMessage);
                }
                else // not debtor
                {
                    sendTestResultToPatient(qItem, patientGreetingMessage);
                }
            }
            else // Not Personal Request
            {
                if (credited)
                {
                    if (sendToPatient)
                    {
                        sendTestResultToPatient(qItem, patientGreetingMessage);
                    }

                    if (sendToOthers && otherNumbers != null)
                    {
                        sendTestResultToOtherNumbers(qItem, otherNumbers, thirdPartyGreetingMessage);
                    }
                }
                else // not credited
                {
                    if (sendToPatient)
                    {
                        if (isPatientDebtor) // debtor
                        {
                            if (MessageBox.Show("The patient '" + qItem.PatientName + "' with admit Id (" + qItem.AdmitId + ") is a debtor! Do you want to continue?", "Force Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                DataAccess.CreateUpdateWhatsappAdmitQueue(qItem.Id, qItem.ParsicSmsQueueId, qItem.AdmitId, 4);
                                return false;
                            }

                            sendTestResultToPatient(qItem, patientGreetingMessage);
                        }
                        else // not debtor
                        {
                            sendTestResultToPatient(qItem, patientGreetingMessage);
                        }
                    }

                    if (sendToOthers && otherNumbers != null)
                    {
                        if (!isPatientDebtor)
                            sendTestResultToOtherNumbers(qItem, otherNumbers, thirdPartyGreetingMessage);
                        else
                        {
                            if (MessageBox.Show("The contractor organ '" + qItem.OrganName + "' with organ Id (" + qItem.OrganId + ") or contractor doctor '" + qItem.DoctorName + "' with doctor Id ("+ qItem.DoctorId+") has not any credit! Do you want to continue?", "Force Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                DataAccess.CreateUpdateWhatsappAdmitQueue(qItem.Id, qItem.ParsicSmsQueueId, qItem.AdmitId, 4);
                                return false;
                            }
                            sendTestResultToOtherNumbers(qItem, otherNumbers, thirdPartyGreetingMessage);
                        }
                    }
                }
            }

            return success;
        }

        private static void sendTestResultToPatient(WhatsappAdmitQueueItem qItem, string patientGreetingMessage)
        {
            if (qItem.AttachedFiles == null || qItem.AttachedFiles.Count == 0)
            {
                long messageId = DataAccess.CreateUpdateWhatsappMessage(-1, null, qItem.Id, qItem.AdmitId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), -1, qItem.MessageText, null, 0, 0, 1);
                if (messageId > 0)
                {
                    string response = WhatsappAPI.SendMessage(messageId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), qItem.AdmitId.ToString(), qItem.MessageText, null, null);
                    if (response == "true")
                    {
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 1, -1);
                    }
                    else
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 10, 3);
                }
            }
            else
            {
                long messageId = DataAccess.CreateUpdateWhatsappMessage(-1, null, qItem.Id, qItem.AdmitId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), -1, patientGreetingMessage, null, 0, 0, 1);
                if (messageId > 0)
                {
                    string response = WhatsappAPI.SendMessage(messageId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), qItem.AdmitId.ToString(), patientGreetingMessage, null, null);
                    if (response == "true")
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 1, -1);
                    else
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 10, 3);
                }
                int i = 1;
                foreach (var file in qItem.AttachedFiles)
                {
                    string fileName = qItem.AdmitId.ToString() + (qItem.AttachedFiles.Count > 1 ? "-" + i.ToString() : "") + "." + file.FileExtension; i++;
                    messageId = DataAccess.CreateUpdateWhatsappMessage(-1, null, qItem.Id, qItem.AdmitId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), file.AttachId, fileName, fileName, 0, 0, 1);
                    var response = WhatsappAPI.SendMessage(messageId, Tools.GlobalizePhoneNumber("98", qItem.MobileNumber), qItem.AdmitId.ToString(), fileName, (file.HasImage) ? file.ImageFile : file.File, file.FileExtension);
                    if (response == "true")
                    {
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 1, -1);
                    }
                    else
                    {
                        DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 10, 3);
                    }
                }
            }
        }

        private static void sendTestResultToOtherNumbers(WhatsappAdmitQueueItem qItem, string[] otherNumbers, string thirdPartyGreetingMessage)
        {
            if (qItem.AttachedFiles == null || qItem.AttachedFiles.Count == 0)
            {
                DataAccess.CreateUpdateWhatsappAdmitQueue(qItem.Id, qItem.ParsicSmsQueueId, qItem.AdmitId, 5);
            }
            else
                foreach (string whatsappNumber in otherNumbers)
                {
                    long messageId = DataAccess.CreateUpdateWhatsappMessage(-1, null, qItem.Id, qItem.AdmitId, Tools.GlobalizePhoneNumber("98", whatsappNumber), -1, thirdPartyGreetingMessage, null, 0, 0, 1);
                    if (messageId > 0)
                    {
                        string response = WhatsappAPI.SendMessage(messageId, Tools.GlobalizePhoneNumber("98", whatsappNumber), qItem.AdmitId.ToString(), thirdPartyGreetingMessage, null, null);
                        if (response == "true")
                            DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 1, -1);
                        else
                            DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 10, 3);
                    }
                    int i = 1;
                    foreach (var file in qItem.AttachedFiles)
                    {
                        string fileName = qItem.AdmitId.ToString() + (qItem.AttachedFiles.Count > 1 ? "-" + i.ToString() : "") + "." + file.FileExtension; i++;
                        messageId = DataAccess.CreateUpdateWhatsappMessage(-1, null, qItem.Id, qItem.AdmitId, Tools.GlobalizePhoneNumber("98", whatsappNumber), file.AttachId, fileName, fileName, 0, 0, 1);
                        var response = WhatsappAPI.SendMessage(messageId, Tools.GlobalizePhoneNumber("98", whatsappNumber), qItem.AdmitId.ToString(), fileName, (file.HasImage) ? file.ImageFile : file.File, file.FileExtension);
                        if (response == "true")
                            DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 1, -1);
                        else
                            DataAccess.CreateUpdateWhatsappMessage(messageId, null, -1, -1, null, -1, null, null, -1, 10, 3);
                    }
                }
        }
    }
}
