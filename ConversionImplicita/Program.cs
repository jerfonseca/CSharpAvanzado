using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            CReal real1 = new CReal(3.5);

            CComplejo comp1 = real1;

            Console.WriteLine(comp1);

            Console.ReadKey();
        }
    }
}
