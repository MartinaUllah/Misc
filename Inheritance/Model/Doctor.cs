using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Model
{
    public abstract class Doctor : Employee
    {
        public int DoctorID { get; set; }

        public override int EmployeeID { get; set; }

        public override string Qualification { get; set; }

 
    }
}
