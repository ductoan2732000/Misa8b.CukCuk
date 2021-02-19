using Misa.CukCuk.Common;
using Misa8b.CukCuk.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.DL
{
    public class DepartmentDL: BaseDL<Department>, IDepartmentDL
    {
        public DepartmentDL(IStringDb stringDb) : base(stringDb)
        {

        }
    }
}
