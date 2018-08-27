using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Teacher : ITeacher
    {
       public string Qualification { get; set; }

        public decimal GetSalary()
        {
            return 4.5M;
        }
    }
}
