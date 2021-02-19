using Dapper;
using Misa.CukCuk.Common;
using Misa8b.CukCuk.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Misa8b.CukCuk.DL
{
    public class BankDL: BaseDL<Bank>, IBankDL 
    {
        public BankDL(IStringDb stringDb): base(stringDb)
        {

        }

        public List<Bank> GetBankByEmployeeId(Guid employeeId)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@EmployeeId", employeeId.ToString());
            return dbConnection.Query<Bank>($"Proc_GetBankByEmployeeId", dynamicParameters, commandType: CommandType.StoredProcedure).ToList();

        }
    }
}
