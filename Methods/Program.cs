using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        public static void Main()
        {
            Program.EvenNumbers(30);

            Program p = new Program();
            int Sum = p.Add(10, 20);

            Console.WriteLine("Sum = {0}", Sum);
            Console.ReadLine();
        }

        public int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }


        public static void EvenNumbers(int Target)

        {
            int Start = 0;

            while (Start <= Target)
            {
                Console.WriteLine(Start);
                Start = Start + 2;
                Console.ReadLine();
            }
        }
    }
}
