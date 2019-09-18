using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface04
{
    //Creamos la jerarquia de interfaces
    //Ahora ICalcular aparte de Calculo tiene los metodos de IMostrar
    interface ICalcular:IMostrar
    {
        int Calculo(int a, int b);
    }
}
