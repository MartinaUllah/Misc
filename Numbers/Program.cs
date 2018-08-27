using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bodmas
            //brackets off divide, multiply, add and then subtract

            // 9+5-4*8/4+8

            //9+5-8+8

            //int a = 18;
            //int b = 6;
            //int c = a + b;
            //Console.WriteLine(c);
            //Console.ReadLine();


            //int a = 18;
            //int b = 6;
            //int c = a / b;
            //Console.WriteLine(c);
            //Console.ReadLine();



            //int a = 5;
            //int b = 4;
            //int c = 2;
            //int d = a + b * c;
            //Console.WriteLine(d);
            //Console.ReadLine();


            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            //Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.ReadLine();

        }
    }
}
