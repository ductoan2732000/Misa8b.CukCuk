using System;
using System.Collections.Generic;
using System.Text;

namespace Misa.CukCuk.Common
{
    public class Bank
    {
        /// <summary>
        /// Id ngân hàng
        /// </summary>
        public Guid BankId { get; set; }
        /// <summary>
        /// Số tài khoản ngân hàng
        /// </summary>
        public string BankCode { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
        public string BankBranch { get; set; }
        /// <summary>
        /// Tỉnh thành phố ngân hàng
        /// </summary>
        public string BankLocation { get; set; }
        /// <summary>
        /// Mã nhân viên là chủ của tài khoản ngân hàng hiện tại
        /// </summary>
        public Guid EmployeeId { get; set; }

    }
}
