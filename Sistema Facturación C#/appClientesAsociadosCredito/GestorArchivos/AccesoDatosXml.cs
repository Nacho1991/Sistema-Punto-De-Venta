using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GestorArchivos
{
    public interface AccesoDatosXml
    {
        // Metodo que nos permitira conectarnos al sistema.
        void Conectar(string pTipo, string pUsuario, string pContrasenna, string pServidor, string pBaseDatos, string pEsquema, string pPuerto);
        DataSet CargarArchivoConfiguracion(ref string pEstado, string pTipoBaseDatos);
        //Metodo que nos ayudara en caso de algun error presentado
        bool isError { set; get; }
        //Nos presentara, una breve descripcion sobre el error que esta ocurriendo
        string ErrorDescripcion { set; get; }
    }
}
