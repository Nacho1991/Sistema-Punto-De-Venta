using GestorArchivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TxtCL
    {
        private AccesoDatosTxt accesoDatos;
        public string tipoBaseDatos { get; set; }
        public TxtCL()
        {
            accesoDatos = new AccessoTxt();
        }
        public void RegistrarEstado(string pEstado)
        {
            accesoDatos.Escribir(pEstado);
            if (accesoDatos.isError)
            {
                isError = true;
                errorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        public void Editar(string pID, string pDatos)
        {
            accesoDatos.Editar(pID, pDatos);
            if (accesoDatos.isError)
            {
                isError = true;
                errorDescripcion = accesoDatos.ErrorDescripcion;
            }
        }
        public bool ValidarEstado(string pID)
        {
            bool voto = false;
            voto = accesoDatos.Validar(pID);
            tipoBaseDatos = accesoDatos.TipoBaseDatos;
            if (accesoDatos.isError)
            {
                errorDescripcion = accesoDatos.ErrorDescripcion;
            }
            return voto;
        }
        public string errorDescripcion { get; set; }
        public bool isError { get; set; }
    }
}
