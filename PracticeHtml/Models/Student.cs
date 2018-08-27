using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeHtml.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Expences { get; set; }

        public decimal CalculateErnings(decimal MoneyFromGovernment, decimal MoneyFromParents, decimal MoneyFromJob)
        {
            var TotalMoney = MoneyFromGovernment + MoneyFromParents + MoneyFromJob;

            return TotalMoney;
        }
    }
}