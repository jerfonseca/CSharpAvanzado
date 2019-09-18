using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    //La clase donde se guardan las extensiones deben ser estaticas
    static class MetodosExtension
    {
        //El metodo que extiende debe ser estatico
        //El primer parametro lleva this y representa al tipo que estamos extendiendo
        public static bool EsPar(this int i)
        {
            if (i % 2 ==0)
                return true;
            else
                return false;
        }

        //Extiende a un Double
        public static double Dobletea(this double d)
        {
            return d * 2.0;
        }

        //Este extiende solo a las clases que implementan la interfaz ISaludador
        public static void Sonido(this ISaludador s)
        {
            Console.Beep();
        }
    }
}
