using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using GUI;
using AccesoDatos;

namespace Datos
{
    class BuscadorCliente
    {
        //Atributos
        AccesoDatosMySql cnx;
        string nombreCliente;
        string cedula;
        string primerApellido;
        string segundoApellido;
        string direccion;
        string codigo;
        string telefono;
        string limite;
        string cantidadActual;

        public BuscadorCliente(AccesoDatosMySql pCnx) 
        {
            cnx = pCnx;
            cedula = "";
            codigo = "";
            nombreCliente = "";
            primerApellido = "";
            segundoApellido = "";
            direccion = "";
            telefono = "";
            limite = "";
            cantidadActual = "";

        }
        //Busca a los clientes por medio de la cedula para comprobar de que no existe en la base de datos
        public bool compararCedulaCliente(string pCedula)
        {
            bool retorno = false;
            string cedula = "";
            string sql = "select cedulaCliente from clientesCreditoAsociados where  cedulaCliente = '" + pCedula + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        cedula = fila["cedulaCliente"].ToString();
                    }
                    if (pCedula == cedula)
                    {
                        retorno = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return retorno;
        }
        //Busca a los clientes por medio del codigo asignado para garantizar de que no existe un codigo igual en la base de datos
        public bool comparaCodigoEmpleado(string pCodigo)
        {
            bool retorno = false;
            string codigo = "";
            string sql = "select id_CodigoCliente from clientesCreditoAsociados where  id_CodigoCliente = '" + pCodigo + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        codigo = fila["id_CodigoCliente"].ToString();
                    }
                    if (pCodigo == codigo)
                    {
                        retorno = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return retorno;
        }
       
        

        //Busca a los clientes por medio de la cédula y recibe por parametro el número de cedula del cliente
        public void extractorDatosClientesPorCedula(string pCedula)
        {
            string sql = "select nombreCliente,id_CodigoCliente,cedulaCliente,primerApellidoCliente,segundoApellidoCliente,direccionCliente,telefonoCliente,limiteCreditoCliente,cantidadCreditoActualCliente from clientesCreditoAsociados where  cedulaCliente = '" + pCedula + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        nombreCliente = fila["nombreCliente"].ToString();
                        codigo = fila["id_CodigoCliente"].ToString();
                        cedula = fila["cedulaCliente"].ToString();
                        primerApellido = fila["primerApellidoCliente"].ToString();
                        segundoApellido = fila["segundoApellidoCliente"].ToString();
                        direccion = fila["direccionCliente"].ToString();
                        telefono = fila["telefonoCliente"].ToString();
                        limite = fila["limiteCreditoCliente"].ToString();
                        cantidadActual = fila["cantidadCreditoActualCliente"].ToString();
                        frmBuscador oSearch = new frmBuscador(cnx);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Busca el cliente por medio del nombre y extrae los datos a solicitar en la base de datos
        public void extractorDatosClientesPorNombre(string pNombre)
        {
            string sql = "select nombreCliente,id_CodigoCliente,cedulaCliente,primerApellidoCliente,segundoApellidoCliente,direccionCliente,telefonoCliente,limiteCreditoCliente,cantidadCreditoActualCliente from clientesCreditoAsociados where  nombreCliente = '" + pNombre + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        codigo = fila["id_CodigoCliente"].ToString();
                        cedula = fila["cedulaCliente"].ToString();
                        nombreCliente = fila["nombreCliente"].ToString();
                        primerApellido = fila["primerApellidoCliente"].ToString();
                        segundoApellido = fila["segundoApellidoCliente"].ToString();
                        direccion = fila["direccionCliente"].ToString();
                        telefono = fila["telefonoCliente"].ToString();
                        limite = fila["limiteCreditoCliente"].ToString();
                        cantidadActual = fila["cantidadCreditoActualCliente"].ToString();
                        frmBuscador oSearch = new frmBuscador(cnx);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void extractorDatosClientesPorCodigo(string pCodigo)
        {
            string sql = "select nombreCliente,id_CodigoCliente,cedulaCliente,primerApellidoCliente,segundoApellidoCliente,direccionCliente,telefonoCliente,limiteCreditoCliente,cantidadCreditoActualCliente from clientesCreditoAsociados where  id_CodigoCliente = '" + pCodigo + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        codigo = fila["id_CodigoCliente"].ToString();
                        nombreCliente = fila["nombreCliente"].ToString();
                        cedula = fila["cedulaCliente"].ToString();
                        primerApellido = fila["primerApellidoCliente"].ToString();
                        segundoApellido = fila["segundoApellidoCliente"].ToString();
                        direccion = fila["direccionCliente"].ToString();
                        telefono = fila["telefonoCliente"].ToString();
                        limite = fila["limiteCreditoCliente"].ToString();
                        cantidadActual = fila["cantidadCreditoActualCliente"].ToString();
                        frmBuscador oSearch = new frmBuscador(cnx);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        //Busca a los empleados registrados en la base de datos por medio del número de cédula
        public string extractorDatosBDAdministradores(string pCedula) 
        {
            string datos="";
            string sql = "select salarioMensual from administradoresGenerales where  id_NumeroEmpleado = '" + pCedula + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        datos = fila["salarioMensual"].ToString();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return datos;

        }

        //Busca en compara el código del empleado para garantizar de que en la base de datos no exista uno igual
        public bool BuscarEmpleadoCodigo(string pCodigo)
        {
            bool retorno = false;
            string codigo = "";
            string sql = "select id_NumeroEmpleado from administradoresGenerales where  id_NumeroEmpleado = '" + pCodigo + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        codigo = fila["id_NumeroEmpleado"].ToString();
                    }
                    if (pCodigo == codigo)
                    {
                        retorno = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return retorno;
        }

        //Se encarga se verificar si la contraseña y el nombre de usuario existen en la base de datos para acceder
        public bool InicadorDeSesion(string pUsuario,string pContrasenna)
        {
            bool retorno = false;
            string user = "";
            string contra = "";
            string sql = "select nombreUsuario,contrasenna from administradoresGenerales where  nombreUsuario = '" + pUsuario + "' and contrasenna = '" + pContrasenna + "'";
            DataSet dSet = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dSet.Tables[0].Rows)
                    {
                        user = fila["nombreUsuario"].ToString();
                        contra = fila["contrasenna"].ToString();
                    }
                    if (pUsuario == user && pContrasenna == contra)
                    {
                        retorno = true;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar los datos.\nDetalles técnicos: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return retorno;
        }

        public string Nombre
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }
        public string SaldoActual
        {
            get { return cantidadActual; }
            set { cantidadActual = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }
    }
}

