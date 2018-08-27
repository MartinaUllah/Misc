using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public abstract class Employee : Person
    {
        public virtual int EmployeeID { get; set; }

        public virtual string Qualification { get; set; }
    }
}
