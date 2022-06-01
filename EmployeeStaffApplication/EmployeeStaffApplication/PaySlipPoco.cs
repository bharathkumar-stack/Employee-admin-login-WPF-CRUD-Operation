using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStaffApplication
{
    class PaySlipPoco
    {
        public int Payslipid { get; set; }
        public int TotalWorkingDays { get; set; }
        public int EmpWorkingDays { get; set; }
        public int EmpLeaves { get; set; }
        public int ProvidentFund { get; set; }
        public int SalDeductions { get; set; }
        public int TotalSalary { get; set; }

        public EmpPoco emp { get; set; }
    }
}
