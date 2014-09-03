using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Departamento
    {
        AccesoDatosMySql cnx;
        public Departamento(AccesoDatosMySql pCnx) 
        {
            cnx = pCnx;
        }
    }
}
