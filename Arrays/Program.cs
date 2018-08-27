using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   //object[] array = new object[2];
            //array[0] = 1;
            //array[1] = "string";

            object[] array = new object[3];
            array[0] = 1;
            array[1] = "string";

            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Pragim";
            array[2] = c;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
                Console.ReadLine();
            }

        }

        class Customer
        {
            public int ID { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }
        }

    }
}                           