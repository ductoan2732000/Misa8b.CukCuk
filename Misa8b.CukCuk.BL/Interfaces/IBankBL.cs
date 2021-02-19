using Misa.CukCuk.Common;
using Misa8b.CukCuk.BL.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.BL.Interfaces
{
    public interface IBankBL
    {
        public ActionServiceResult GetAllData();
        public ActionServiceResult InsertData(Bank bank);
        public ActionServiceResult GetDataById(Guid id);
        public ActionServiceResult GetBankByEmployeeId(Guid employeeId);
        public ActionServiceResult UpdateData(Bank bank);
        public ActionServiceResult DeleteBank(Guid id);
    }
}
