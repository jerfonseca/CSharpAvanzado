using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forma de implementar dos interfaces con el mismo nombre de metodo

            CCuadro cuadro = new CCuadro(5);

            ((IPerimetro)cuadro).Calcular();

            ((IArea)cuadro).Calcular();

            Console.ReadKey();
        }
    }
}
