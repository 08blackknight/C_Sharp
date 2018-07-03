using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase101
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numerouno;
            int numerodos;
            int suma;
            Console.WriteLine("Escriba un numero:");
            numerouno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba otro numero:");
            numerodos = Convert.ToInt32(Console.ReadLine());
            suma = numerouno + numerodos;
            Console.WriteLine("El resultado es: " + suma);
            Console.ReadKey();
        }
    }
}
