using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcepcionesAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CMetodos metodos = new CMetodos();
                metodos.Calcular();
            }
            catch (CMetodoException e)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Momento);
            }
            catch (Exception e)
            {
                Console.WriteLine("El mensaje:| {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
