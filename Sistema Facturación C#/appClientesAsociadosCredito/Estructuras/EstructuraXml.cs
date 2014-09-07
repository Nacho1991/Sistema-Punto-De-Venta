using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    public struct EstructuraXml
    {
        public string Servidor { set; get; }
        public string Puerto { set; get; }
        public string BaseDatos { set; get; }
        public string Usuario { set; get; }
        public string Contrasenna { set; get; }
        public string Esquema { set; get; }
    }
}
