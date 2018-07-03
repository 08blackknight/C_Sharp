using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase102
{
    class Program
    {
        static void Main(string[] args)
        {
            string contenedor = "hydraidios";
            string recibir;
            Console.WriteLine("Escriba un nombre para determinar si un jugador es Fariseo");
            recibir = Console.ReadLine();
            if(contenedor==recibir)
            {
                Console.WriteLine("ES FARISEO");

            }
            else
            {
                Console.WriteLine("NO ES FARISEO");
            }
            Console.ReadKey();
        }

    }
}
