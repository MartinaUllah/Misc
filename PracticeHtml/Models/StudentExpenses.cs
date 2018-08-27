using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeHtml.Models
{
    public class StudentExpenses
    {

        public decimal CalculateEarnings()
        {
            var earningFromParents = 50.95M;
            var earningFromGovernment = 355.45M;
            var earningFromJob = 580.55M;

            var Student = new Student();
            var Total = Student.CalculateErnings(earningFromGovernment, earningFromParents, earningFromJob);

            return Total;

        }
    }
}