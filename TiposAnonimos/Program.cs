using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un tipo temporal con atributos, propiedades, toString()

            var miCompu = new { Procesador= "i7", Memoria=16, Graficos="intel" };

            //Imprimimos la variable
            Console.WriteLine(miCompu);

            //Imprimimos un atributo
            Console.WriteLine("la compu tiene {0} de memoria", miCompu.Memoria);

            //No podemos modificar el atributo, es de solo lectura
            //miCompu.Graficos = "nvidia";

            Console.ReadKey();
        }
    }
}
