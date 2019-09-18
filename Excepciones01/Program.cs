using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones01
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
            catch (Exception e)
            {
                Console.WriteLine("Sucedio la excepcion");
                Console.WriteLine("En este metodo: {0}", e.TargetSite);
                Console.WriteLine("Con este mensaje de error: {0}", e.Message);
                Console.WriteLine("Fuente: {0}", e.Source);

                Console.WriteLine("Clase donde ocurrio: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro: {0}", e.TargetSite.MemberType);

                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                Console.WriteLine("Mostramos los datos propios");

                //verificamos que existan datos
                if(e.Data != null)
                {
                    //Mostramos los datos propios de la excepcion
                    foreach(DictionaryEntry dato in e.Data)
                    {
                        Console.WriteLine("-> {0} -> {1}", dato.Key, dato.Value);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
