using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class calculaNumeros
    {
        private double numUno;
        private double numDos;

        public calculaNumeros(double pNumUno, double pNumDos) 
        {
            numUno = pNumUno;
            numDos = pNumDos;
        }

        public double calculaSuma() 
        {
            double result = 0;
            result = numUno + numDos;
            return result;
        }
        public double calculaResta() 
        {
            double result = 0;
            result = numUno - numDos;
            return result;
        }
        public double calculaMultiplicacion() 
        {
            double result = 0;
            result = numUno * numDos;
            return result;
        }

        public double calculaPorcentaje() 
        {
            double result = 0;

            result = ((NumDos / 100) * numUno);

            return result;
        }

        public double calculaDivision() 
        {
            double result;
            if ((numDos == 0) || (numDos < 0) || (numUno < 0))
            {
                result = 0;
            }
            else
            {
                result = (numUno / numDos);
                
            }
            return result;
        }
        public int convertirBinario() 
        {
            int result = 0;
            return result;
        }


        public double NumDos
        {
            get { return numDos; }
            set { numDos = value; }
        }
        public double NumUno
        {
            get { return numUno; }
            set { numUno = value; }
        }
    }
}
