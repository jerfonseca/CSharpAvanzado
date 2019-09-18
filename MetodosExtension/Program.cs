using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension del int
            int numero = 55;

            bool par = numero.EsPar(); //Aqui encontramos la extension

            Console.WriteLine("{0} es {1}", numero, par);

            //Extension del double
            double valor = 55.18;

            Console.WriteLine(valor.Dobletea());

            //Extension ISaludador
            CMiInt entero = new CMiInt(7);

            entero.Sonido();

            Console.ReadKey();
        }
    }
}
