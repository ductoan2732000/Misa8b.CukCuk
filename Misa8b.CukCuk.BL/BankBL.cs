using Misa.CukCuk.Common;
using Misa.CukCuk.Common.Enum;
using Misa8b.CukCuk.BL.Interfaces;
using Misa8b.CukCuk.BL.Result;
using Misa8b.CukCuk.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.BL
{
    public class BankBL : IBankBL
    {
        IBankDL _bankDL;
        public BankBL(IBankDL bankDL)
        {
            _bankDL = bankDL;
        }

        public ActionServiceResult DeleteBank(Guid id)
        {
            
            if (_bankDL.CheckDuplicateDataId(id) == false)
                return new ActionServiceResult()
                {
                    Success = false,
                    Message = Misa.CukCuk.Common.Properties.Resources.Err_NotDupId,
                    MisaCode = Enumarations.MisaCode.Validate,
                    Data = null
                };
            else
            {
                Bank data = _bankDL.GetDataId(id);
                var dataCode = data.BankCode;
                _bankDL.DeleteData(id);
                return new ActionServiceResult()
                {
                    Success = true,
                    Message = Misa.CukCuk.Common.Properties.Resources.DeleteBank + dataCode,
                    MisaCode = Enumarations.MisaCode.Success,
                    Data = null
                };
            }
        }

        public ActionServiceResult GetAllData()
        {
            return new ActionServiceResult()
            {
                Data = _bankDL.GetDatas(),
                Success = true,
                Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                MisaCode = Enumarations.MisaCode.Success
            };
        }

        public ActionServiceResult GetBankByEmployeeId(Guid employeeId)
        {
            return new ActionServiceResult()
            {
                Data = _bankDL.GetBankByEmployeeId(employeeId),
                Success = true,
                Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                MisaCode = Enumarations.MisaCode.Success
            };
        }

        public ActionServiceResult GetDataById(Guid id)
        {
            if (_bankDL.CheckDuplicateDataId(id) == true)
            {
                return new ActionServiceResult()
                {
                    Success = true,
                    Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                    MisaCode = Enumarations.MisaCode.Success,
                    Data = _bankDL.GetDataId(id)
                };
            }

            else return new ActionServiceResult()
            {
                Success = false,
                Message = Misa.CukCuk.Common.Properties.Resources.Err_NotId + ". ",
                MisaCode = Enumarations.MisaCode.Validate,
                Data = null
            };
        }

        public ActionServiceResult InsertData(Bank bank)
        {
            _bankDL.InsertData(bank);
            return new ActionServiceResult()
            {
                Success = true,
                Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                MisaCode = Enumarations.MisaCode.Success,
                Data = null
            };
        }

        public ActionServiceResult UpdateData(Bank bank)
        {
            _bankDL.UpdateData(bank);
            return new ActionServiceResult()
            {
                Success = true,
                Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                MisaCode = Enumarations.MisaCode.Success,
                Data = null
            };
        }
    }
}
