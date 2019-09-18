using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones01HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            //Adicionamos Elementos
            //Add(Key, Value)
            //HashTable ordena por el valor de la Key
            miTabla.Add(123,"Hola");
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");

            //Mostrar los elementos
            foreach(DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);
            }

            //Cantidad de Elementos
            Console.WriteLine("miTabla tiene {0} elementos", miTabla.Count);

            //Obtener elementos con determinada Clave
            Console.WriteLine("Elemento con la Clave 234 = {0}",miTabla[234]);

            //No se pueden agregar elementos con la misma clave
            //miTabla.Add(45, "Otro mas");

            //Colocar elementos en una Clave
            miTabla[234] = "Saludos desde Nicaragua";
            Console.WriteLine("Elemento con la Clave 234 ha sido modificada = {0}", miTabla[234]);

            //Verifica si existe una clave
            Console.WriteLine("La clave 45 validar si existe: {0}", miTabla.Contains(45));
            Console.WriteLine("El valor Adios validar si existe: {0}", miTabla.ContainsValue("Adios"));

            //Listar las claves de la collecion
            Console.WriteLine("Listar las Key de la coleccion");
            foreach(int key in miTabla.Keys)
            {
                Console.WriteLine(key);
            }

            //Listar los valores de la collecion
            Console.WriteLine("Listar los valores de la coleccion");
            foreach (string value in miTabla.Values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
