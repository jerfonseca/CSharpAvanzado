using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList palabras = new ArrayList();
            ArrayList numeros = new ArrayList();

            int n = 0, r = 0;

            //Adicionar con rangos
            palabras.AddRange(new string[] { "hola", "como", "estan?"});
            numeros.AddRange(new Int32[] { 2,8,3,5,4,1,9,7});

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}", palabras.Count);

            //Validar si existe un elemento
            Console.WriteLine("El elemento existe {0}", palabras.Contains("hola"));

            //Insertar en un indice en particular
            palabras.Insert(3, "Bien y Tu?");

            //Recorremos con ciclo
            foreach (string str in palabras)
            {
                Console.WriteLine("{0}", str);
            }

            //Numeros desordenados
            Console.WriteLine("Numeros desordenados");
            foreach(int i in numeros)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();

            //Numeros ordenados
            numeros.Sort();
            Console.WriteLine("Numeros Ordenados");
            foreach (int i in numeros)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();

            //Numeros reverse
            numeros.Reverse();
            Console.WriteLine("Numeros Reverse");
            foreach (int i in numeros)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();

            string strNumeros = string.Empty;
            Console.WriteLine("Numeros Separados por coma");
            foreach (int i in numeros)
            {
                strNumeros += "," + i.ToString();
            }

            Console.WriteLine(strNumeros.Remove(0,1)); //Se elimina la primer coma

            Console.ReadKey();

        }
    }
}
