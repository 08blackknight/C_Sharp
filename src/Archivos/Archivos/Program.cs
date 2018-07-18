using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            cliente aux = new cliente();

            string temporal;

            
            
            Console.WriteLine("INGRESE NOMBRE : ");
            aux.nombre = Console.ReadLine();
            
            Console.WriteLine("INGRESE APELLIDO");
            aux.apellido =  Console.ReadLine();
            Console.WriteLine("INGRESE DOCUMENTO");
            aux.docnacional = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            Console.WriteLine("#################################");
            Console.WriteLine(aux.nombre);
            Console.WriteLine(aux.apellido);
            Console.WriteLine(aux.docnacional);
            Console.WriteLine("#################################");
            Console.WriteLine("#################################");
            
            Console.ReadKey();
            //
            TextWriter archivo;
            archivo = new StreamWriter("set.txt");
            
            temporal = aux.nombre;
            archivo.WriteLine(temporal);
            temporal = aux.apellido;
            archivo.WriteLine(temporal);
            temporal = Convert.ToString(aux.docnacional);
            archivo.WriteLine(temporal);
            archivo.Close();
            Console.ReadKey();
            //

            TextReader leer_archivo;
            leer_archivo = new StreamReader("set.txt");
            Console.WriteLine(leer_archivo.ReadLine());
            Console.WriteLine(leer_archivo.ReadLine());
            Console.WriteLine(leer_archivo.ReadLine());
            leer_archivo.Close();
            Console.ReadKey();

            StreamWriter leer_archivo2 = File.AppendText("set.txt");
            temporal = aux.nombre;
            leer_archivo2.WriteLine(temporal);
            temporal = aux.apellido;
            leer_archivo2.WriteLine(temporal);
            temporal = Convert.ToString(aux.docnacional);
            leer_archivo2.WriteLine(temporal);
            leer_archivo2.Close();









        }
    }
}
