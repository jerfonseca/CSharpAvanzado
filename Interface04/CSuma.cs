using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface04
{
    //Implementamos ICalcular que al tener la jerarquia tambien nos obliga
    //a implementar IMostrar
    class CSuma : ICalcular
    {
        private int a;
        private int b;
        private int r;

        //Implementacion de ICalcular
        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;
            return r;
        }

        //Implementacion de IMostrar
        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,r);
        }
    }
}
