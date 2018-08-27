using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_and_when_should_we_use_an_abstract_class
{
    public abstract class BaseEmployee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public abstract int GetMonthlySalary();
    }
}
