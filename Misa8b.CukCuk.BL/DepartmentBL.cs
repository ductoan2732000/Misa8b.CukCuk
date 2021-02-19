using Misa.CukCuk.Common.Enum;
using Misa8b.CukCuk.BL.Interfaces;
using Misa8b.CukCuk.BL.Result;
using Misa8b.CukCuk.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.BL
{
    public class DepartmentBL: IDepartmentBL
    {
        IDepartmentDL _departmentDL;
        public DepartmentBL(IDepartmentDL departmentDL)
        {
            _departmentDL = departmentDL;
        }

        public ActionServiceResult GetAllData()
        {
            return new ActionServiceResult()
            {
                Data = _departmentDL.GetDatas(),
                Success = true,
                Message = Misa.CukCuk.Common.Properties.Resources.Success_Mesenger + ". ",
                MisaCode = Enumarations.MisaCode.Success
            };
        }
    }
}
