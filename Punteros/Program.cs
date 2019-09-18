using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicarle al proyecto el uso de codigo no seguro
            //Menu Proyecto-> Propiedades de Punteros -> Compilacion -> Permitir Codigo no Seguro(Habilitar)
            
            //Es necesario poner el proyecto en unsafe
            unsafe
            {
                int valor = 5;

                //Creo puntero
                int* p;

                //Apunte a la direccion de valor
                p = &valor;

                Console.WriteLine(*p);

                //No se puede
                //Console.WriteLine(p);

                //Cambiamos el valor
                *p = 67;

                Console.WriteLine(*p);
                Console.WriteLine(valor);
                
            }

            Console.WriteLine("--- Haremos uso de swap ---");

            int a = 3;
            int b = 8;

            Console.WriteLine("a={0}, b={1}", a,b);

            //Invocar el metodo que usa punteros
            unsafe { swap(&a, &b); }

            Console.WriteLine("a={0}, b={1}", a, b);

            Console.ReadKey();
        }

        //Metodo que usa Punteros
        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;
            *m = *n;
            *n = temp;
        }
    }
}
