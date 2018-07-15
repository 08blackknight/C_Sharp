using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace firstinpooinconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            person personal = new person();
            personal.name = "JOSE ANTONIO";
            personal.born = 1970;

            Console.WriteLine("PASO UNO");

            Console.ReadKey();

            Console.WriteLine("Su nombre es :" + personal.name );
            Console.WriteLine("Tiene "+ personal.obteneredad(personal.born) + " años de edad");
            Console.ReadKey();
        }
    }
}
