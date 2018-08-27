using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_and_when_should_we_use_an_abstract_class
{
    public class ContractEmployee : BaseEmployee
    {
        public int HourlyPay { get; set; }

        public int TotalHours { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
