﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //Hacemos uso de la expresion lambda
            List<int> numPares = numeros.FindAll((i) =>
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine("Un par");
                      return true;
                  }
                  else
                  {
                      Console.WriteLine("Un impar");
                      return false;
                  }
              });

            foreach (int n in numPares)
                Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
