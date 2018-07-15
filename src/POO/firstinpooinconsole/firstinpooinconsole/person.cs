using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstinpooinconsole
{
    public class person
    {
        public string name;
        public int born;

        


        public int obteneredad(int entrada)
        {
            int salida;
            salida = DateTime.Now.Year - entrada;

            return salida;
        }

    }
}
