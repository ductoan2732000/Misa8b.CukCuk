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
    }
}
