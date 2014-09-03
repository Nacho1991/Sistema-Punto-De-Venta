using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class VerificadorDatos
    {
        public VerificadorDatos() 
        {

        }

        public bool esNumeroEntero(string num) 
        {
            bool correcto = false;
            try
            {
                Convert.ToInt32(num);
                correcto = true;
            }
            catch 
            {
                correcto = false;
            }
            return correcto;
        }
        public bool esNumeroDecimal(string num) 
        {
            bool correcto = false;
            try
            {
                Convert.ToDouble(num);
                correcto = true;
            }
            catch 
            {
                correcto = false;
            }
            return correcto;
        }
    }
}
