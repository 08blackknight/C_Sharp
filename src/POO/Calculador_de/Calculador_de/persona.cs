using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador_de
{
    public class persona
    {
        //Atributos
        public string nombre;
        public int diadenac;
        public int mesdenac;
        public int aniodenac;

        //Metodos

        public int calcularedad(int entradadia,int entradames,int entradaanio)
        {
            int resultadoanio;
            resultadoanio = DateTime.Now.Year - entradaanio;      
  
            if(entradames == DateTime.Now.Month)
            {

                //
                bool interruptor= (entradadia < DateTime.Now.Day);
                Console.WriteLine("EL INTERRUPTOR INDICA  " + interruptor);
                //
                if ((entradadia > DateTime.Now.Day)==false)
                {
                    resultadoanio = resultadoanio - 1;
                    Console.WriteLine("ENTRO EN " + resultadoanio);
                }

            }

            if(entradames > DateTime.Now.Month)
            {
                resultadoanio = resultadoanio - 1;
                Console.WriteLine("ENTRO EN  SEGUNDA CONDICIONAL" + resultadoanio);
            }
            
            
            return resultadoanio;
        }



    }
}
