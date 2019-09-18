using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reconocer si un objeto implementa una determinada interfaz

            CTelevisor miTele = new CTelevisor("LG");
            CPelota miPelota = new CPelota("Molten");
            IElectronico objeto = null;

            //Metodo 1 por exception
            try
            {
                Console.WriteLine("Probamos la tele");
                objeto = (IElectronico)miTele;
                objeto.Encender(true);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine("Probamos la pelota");
                objeto = (IElectronico)miPelota;
                objeto.Encender(true);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("--- Metodo 2 ---");

            Console.WriteLine("Probamos la tele");
            objeto = miTele as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la Pelota");
            objeto = miPelota as IElectronico;

            if (objeto != null)
                objeto.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("--- Metodo 3 ---");
            Console.WriteLine("Probamos la tele");

            if (miTele is IElectronico)
                miTele.Encender(true);
            else
                Console.WriteLine("No implementa IElectronico");

            Console.WriteLine("Probamos la Pelota");

            if (miPelota is IElectronico)
                Console.WriteLine("Wow tienes una pelota electronica");
            else
                Console.WriteLine("No implementa IElectronico");


            Console.ReadKey();
        }
    }
}
