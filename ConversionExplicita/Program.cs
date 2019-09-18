using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita
{
    class Program
    {
        static void Main(string[] args)
        {
            CComplejo comp1 = new CComplejo(2, 3);

            //No se puede
            //CReal real1 = comp1;

            //Haciendo uso de conversion explicita
            CReal real2 = (CReal)comp1;
            Console.WriteLine(real2);

            Console.ReadKey();

        }
    }
}
