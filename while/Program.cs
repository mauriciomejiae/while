﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
            while (contador < 20)
            {
                Console.WriteLine("Esta es la vez numero " + contador + "que pasa por aqui");
                contador++;
            }

            Console.ReadKey();
        }
    }
}