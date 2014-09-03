using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class PrivilegiosL
    {
        private string cedula;
        private string administracionCajas;
        private string administracionClientes;
        private string administracionInventario;
        private string administracionEmpleados;
        private string administracionFacturas;
        public PrivilegiosL(string pCedula, string pAdminCajas, string pAdminClientes, string pAdminInventario, string pAdminEmpleado, string pAdminFacturas) 
        {
            cedula = pCedula;
            administracionCajas = pAdminCajas;
            administracionClientes = pAdminClientes;
            administracionInventario = pAdminInventario;
            administracionEmpleados = pAdminEmpleado;
            administracionFacturas = pAdminFacturas;
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string AdministracionCajas
        {
            get { return administracionCajas; }
            set { administracionCajas = value; }
        }
        public string AdministracionClientes
        {
            get { return administracionClientes; }
            set { administracionClientes = value; }
        }
        public string AdministracionInventario
        {
            get { return administracionInventario; }
            set { administracionInventario = value; }
        }
        public string AdministracionEmpleados
        {
            get { return administracionEmpleados; }
            set { administracionEmpleados = value; }
        }
        public string AdministracionFacturas
        {
            get { return administracionFacturas; }
            set { administracionFacturas = value; }
        }
    }
}
