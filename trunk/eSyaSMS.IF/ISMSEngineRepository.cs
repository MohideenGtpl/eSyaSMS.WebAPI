﻿using HCP.SMS.DO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HCP.SMS.IF
{
    public interface ISMSEngineRepository
    {
        #region SMS Variable

        Task<List<DO_SMSVariable>> GetSMSVariableInformation();

        Task<List<DO_SMSVariable>> GetActiveSMSVariableInformation();

        Task<DO_ReturnParameter> InsertIntoSMSVariable(DO_SMSVariable obj);

        Task<DO_ReturnParameter> UpdateSMSVariable(DO_SMSVariable obj);

        Task<DO_ReturnParameter> ActiveOrDeActiveSMSVariable(bool status, string smsvariable);

        #endregion SMS Variable

        #region SMS Information
        Task<List<DO_Forms>> GetExistingFormsFromSMSHeader();

        Task<List<DO_SMSTEvent>> GetSMSTriggerEvent();

        Task<List<DO_SMSHeader>> GetSMSHeaderInformationByFormId(int formId);

        Task<DO_SMSHeader> GetSMSHeaderInformationBySMSId(string smsId);

        Task<DO_ReturnParameter> InsertIntoSMSHeader(DO_SMSHeader obj);

        Task<DO_ReturnParameter> UpdateSMSHeader(DO_SMSHeader obj);


        #endregion SMS Information

        #region SMS Recipient

        Task<List<DO_SMSHeader>> GetSMSHeaderForRecipientByFormIdandParamId(int formId,int parameterId);

        Task<List<DO_SMSRecipient>> GetSMSRecipientByBusinessKeyAndSMSId(int businessKey, string smsId);

        Task<DO_ReturnParameter> InsertIntoSMSRecipient(DO_SMSRecipient obj);

        Task<DO_ReturnParameter> UpdateSMSRecipient(DO_SMSRecipient obj);

        #endregion SMS Recipient

        #region Trigger Event
        Task<List<DO_SMSTEvent>> GetAllSMSTriggerEvents();

        Task<DO_ReturnParameter> InsertIntoSMSTriggerEvent(DO_SMSTEvent obj);

        Task<DO_ReturnParameter> UpdateSMSTriggerEvent(DO_SMSTEvent obj);

        Task<DO_ReturnParameter> DeleteSMSTriggerEvent(int TeventId);

        Task<DO_ReturnParameter> ActiveOrDeActiveSMSTriggerEvent(bool status, int TriggerEventId);
        #endregion SMS Trigger Event
    }
}