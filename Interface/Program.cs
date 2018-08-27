using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IChair martina = new Martina();

            IChair mercedes = new Mercedes();
            martina.GetWheels();

        }
    }
}
