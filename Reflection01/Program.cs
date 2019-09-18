using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Namespace requeridos
using System.Linq;
using System.Reflection;

namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reflection es para obtener informacion sobre un tipo
            try
            {
                //Obtenemos el tipo
                Type t = Type.GetType("System.Collections.ArrayList");
                //Type t = Type.GetType("System.Console");

                //Metodos que buscan la informacion sobre el tipo
                CaracteristicasTipo(t);
                EncuentraCampos(t);
                EncuentraPropiedades(t);
                EncuentraMetodos(t);
                EncuentraInterfaces(t);
            }
            catch
            {
                Console.WriteLine("Verificar el tipo");
            }
            Console.ReadKey();
        }

        private static void CaracteristicasTipo(Type t)
        {
            //Imprimir las caracteristicas principales del tipo
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tiene son:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Clase base: {0}", t.BaseType);
            Console.WriteLine("Es una clase: {0}", t.IsClass);
            Console.WriteLine("Abstracta: {0}", t.IsAbstract);
            Console.WriteLine("Sellada: {0}", t.IsSealed);
            Console.WriteLine("Generica: {0}", t.IsGenericTypeDefinition);

        }

        private static void EncuentraCampos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            //Encontramos los campos en este tipo
            var nombres = from f in t.GetFields() select f.Name;
            foreach(var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        private static void EncuentraPropiedades(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las propiedades encontradas son:");
            Console.ForegroundColor = ConsoleColor.White;

            //Encontramos los campos en este tipo
            var nombres = from f in t.GetProperties() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        private static void EncuentraMetodos(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Los metodos encontrados son:");
            Console.ForegroundColor = ConsoleColor.White;

            //Encontramos los campos en este tipo
            var nombres = from f in t.GetMethods() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }

        private static void EncuentraInterfaces(Type t)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Las interfaces encontradas son:");
            Console.ForegroundColor = ConsoleColor.White;

            //Encontramos los campos en este tipo
            var nombres = from f in t.GetInterfaces() select f.Name;
            foreach (var nombre in nombres)
            {
                Console.WriteLine("{0}", nombre);
            }
        }
    }
} 
