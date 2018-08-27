using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Why_and_when_should_we_use_an_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mark",
                LastName = "May",
                AnnualSalary = 60000

            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.ReadLine();

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sara",
                LastName = "S",
                HourlyPay = 200,
                TotalHours = 40

            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.ReadLine();
        }

    }
}
