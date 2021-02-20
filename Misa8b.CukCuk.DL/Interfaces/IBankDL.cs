using Misa.CukCuk.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.DL.Interfaces
{
    public interface IBankDL: IBaseDL<Bank>
    {
        public List<Bank> GetBankByEmployeeId(Guid employeeId);
        public int DeleteBankByEmployeeId(Guid employeeId);
    }
}
