using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceConMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglos de interfaces
            IElectronico[] teles = { new CTelevisor("Charp"), new CTelevisor("Zony"), new CRadio("RCB Radio"), new CRadio("Phillips") };
            IElectronico aparatoCreado = null;

            for(int n = 0; n < teles.Length; n++)
            {
                Console.WriteLine(teles[n]);
            }

            Console.WriteLine("--------");

            //Uso de interfaces con metodos
            CTelevisor miTV = new CTelevisor("Charp TV");
            CRadio miRadio = new CRadio("RCB Radio");

            Muestra(miTV);
            Muestra(miRadio);

            Console.WriteLine("--------");

            //Metodo que regresa objeto que implementa IElectronico
            aparatoCreado = CreaAparato();
            aparatoCreado.Encender(true);
            Console.WriteLine(aparatoCreado);

            Console.ReadKey();
        }

        //Este metodo puede recibir cualquier objeto que implemente la interfaz IElectronico
        static void Muestra(IElectronico aparato)
        {
            if (aparato is CTelevisor)
                Console.WriteLine("El televisor es {0}",aparato);
            if(aparato is CRadio)
                Console.WriteLine("El Radio es {0}", aparato);
        }

        //Retorna cualquier objeto que implemente IElectronico
        static IElectronico CreaAparato()
        {
            IElectronico aparato = null;
            string dato = string.Empty;
            int opcion = 0;

            Console.WriteLine("Que deseas crear? 1- Tele, 2- Radio");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);

            if (opcion == 1)
            {
                Console.WriteLine("Dame la marca del tele");
                dato = Console.ReadLine();
                aparato = new CTelevisor(dato);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Dame la marca del radio");
                dato = Console.ReadLine();
                aparato = new CRadio(dato);
            }

            return aparato;
        }
    }
}
