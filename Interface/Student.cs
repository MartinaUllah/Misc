using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Student : IStudent
    {
        public string FirstName { get; set; }

        public int GetAge()
        {
            return 65;
        }
    }
}
