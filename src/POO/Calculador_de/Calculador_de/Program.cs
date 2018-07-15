using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador_de
{
    class Program
    {
        static void Main(string[] args)
        {
            persona aux = new persona();
            Console.WriteLine("DIA :: "+ DateTime.Now.Day +"MES :: "+ DateTime.Now.Month +"ANIO :: " + DateTime.Now.Year );
            Console.WriteLine("Escriba Nombre : ");
            aux.nombre=Console.ReadLine();
            Console.WriteLine("Escriba dia de nacimiento : ");
            aux.diadenac = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El mes : ");
            aux.mesdenac = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("El Anio : ");
            aux.aniodenac = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("###################");
            Console.ReadKey();

            Console.WriteLine("###################");
            Console.WriteLine("###################");
            Console.WriteLine("Su nombre es " + aux.nombre + "y su edad es de " + aux.calcularedad(aux.aniodenac,aux.mesdenac,aux.aniodenac) + " años" );
            Console.ReadKey();


        }
    }
}
