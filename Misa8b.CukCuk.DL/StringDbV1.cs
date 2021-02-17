using Misa8b.CukCuk.DL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Misa8b.CukCuk.DL
{
    public class StringDbV1: IStringDb
    {
        protected string stringConnectionDb = "User Id=dev;Host=47.241.69.179;" +
                "Database=MS2_29_DucToan_CukCuk;port=3306;password=12345678;Character Set=utf8";
        public string getStringDb()
        {
            return this.stringConnectionDb;
        }

    }
}
