using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jerarquia de interfaces
            CSuma miSuma = new CSuma();

            //metodo de ICalcular
            miSuma.Calculo(5, 3);

            //metodo de IMostrar
            miSuma.MostrarDatos();

            Console.ReadKey();
        }
    }
}
