using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros2 =  {11, 11, 0, 0, 0, 0, 0, 0, 0, 0 };
            
            int[] numeros = new int[5];
            numeros[0] = 33;
            numeros[1] = 33;
            numeros[2] = 33;
            numeros[3] = 33;
            numeros[4] = 33;
            

            for (int i = 0 ; i < 5 ; i++)
            {
                Console.Write(numeros[i]+ "--");
                if (i == 4) Console.WriteLine();
            }

            Console.WriteLine("SEGUNDO ARRAY");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros2[i] + "--");
            }

            Console.ReadKey();

          

            Console.WriteLine("SEGUNDO ARRAY");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros2[i] + "--");
            }



            int lector = 0;
            for (int i = 0; i < 10; i++)
            {




                if (numeros2[i] == 0)
                {

                    if (lector < 5)
                    {
                        numeros2[i] = numeros[lector];
                        lector++;
                    }
                  
                }
                else
                {
                   
                }


            }

            Console.WriteLine("SEGUNDO ARRAY MODIFICADO");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros2[i] + "--");
            }



            Console.ReadKey();
        }
    }
}
