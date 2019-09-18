using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface03
{
    //Implementa dos interfaces que tienen metodos con el mismo nombre
    //Esto se resuelve con la implementacion explicita de interfaces
    class CCuadro: IArea, IPerimetro
    {
        private int lado;

        public CCuadro(int pLado)
        {
            lado = pLado;
        }
        void IArea.Calcular()
        {
            Console.WriteLine("Calcular area={0}", lado * lado);
        }
        void IPerimetro.Calcular()
        {
            Console.WriteLine("Calcular perimetro={0}", lado * 4);
        }
    }
}
