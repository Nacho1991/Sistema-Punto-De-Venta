using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using GUI;
using AccesoDatos;
using MySql.Data.MySqlClient;

namespace Datos
{
    class Empleadocs
    {
        //Atributos
        AccesoDatosMySql cnx;
        private bool error;
        private string errorDescripcion;

        //Constructo
        public Empleadocs(AccesoDatosMySql pCnx) 
        {
            error = false;
            errorDescripcion = "";
            cnx = pCnx;
        }

        //Obtiene de la base de datos la tabla a solicitar
        public DataSet obtenerEmpleados()
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM login";
            retorno = cnx.ejecutarConsultaSQL(sql);
            error = cnx.IsError;
            return retorno;
        }
        public bool compararCedulaEmpleado(string pCedula)
        {
            bool retorno = false;
            string cedula = "";
            string sql = "SELECT Id_Cedula FROM login WHERE  Id_Cedula = '" + pCedula + "'";
            DataSet dset = cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError == false)
            {
                try
                {
                    foreach (DataRow fila in dset.Tables[0].Rows)
                    {
                        cedula = fila["Id_Cedula"].ToString();
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
        public DataSet FiltrarDatos(string pFiltro, string pTabla)
        {
            DataSet retorno = new DataSet();
            string sql = "SELECT * FROM login WHERE" + " " + pTabla + " LIKE '%" + pFiltro + "%'";
            retorno = cnx.ejecutarConsultaSQL(sql);
            error = cnx.IsError;
            return retorno;
        }
        //Borra el empleado seleccionado por el usuario
        public void borrarEmpleado(string pIdCliente)
        {

            string sql = "DELETE FROM login WHERE id_cedula = @id_cedula";//consulta delete hacia la base de datos por medio de la llave primaria
            MySqlParameter[] parametro = new MySqlParameter[1];
            parametro[0] = new MySqlParameter();
            parametro[0].MySqlDbType = MySqlDbType.VarChar;
            parametro[0].ParameterName = "@id_cedula";
            parametro[0].Value = pIdCliente;
            this.cnx.ejecutarConsultaSQL(sql, "login", parametro);
            error = cnx.IsError;
            if (this.cnx.IsError)
            {
                errorDescripcion = cnx.ErrorDescripcion;
            }
        }
        public void agregarPrivilegios(string pCedula,string pAdminClientes,string pAdminInventario,string pAdminFacturas,string pAdminEmpleados,string pAdminCajas) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "INSERT INTO Privilegios(Login_Id_Cedula,Administracion_Clientes,Administracion_Inventario,Administracion_Facturas,Administracion_Empleados,Administracion_Cajas)" +
                " VALUES(@Login_Id_Cedula,@Administracion_Clientes,@Administracion_Inventario,@Administracion_Facturas,@Administracion_Empleados,@Administracion_Cajas)";//consulta basica para insertar valores a la base de datos parámetrizada
            MySqlParameter[] parametros = new MySqlParameter[6];
            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@Login_Id_Cedula";
            parametros[0].Value = pCedula;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Administracion_Clientes";
            parametros[1].Value = pAdminClientes;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Administracion_Inventario";
            parametros[2].Value = pAdminInventario;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Administracion_Facturas";
            parametros[3].Value = pAdminFacturas;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@Administracion_Empleados";
            parametros[4].Value = pAdminEmpleados;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.VarChar;
            parametros[5].ParameterName = "@Administracion_Cajas";
            parametros[5].Value = pAdminCajas;

            this.cnx.ejecutarConsultaSQL(sql, "Privilegios", parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

        public void modificarPrivilegios(string pCedula, string pAdminClientes, string pAdminInventario, string pAdminFacturas, string pAdminEmpleados, string pAdminCajas)
        {
            string sql = "UPDATE Privilegios SET   Administracion_Clientes = @Administracion_Clientes,Administracion_Inventario = @Administracion_Inventario,Administracion_Facturas = @Administracion_Facturas,Administracion_Empleados = @Administracion_Empleados,Administracion_Cajas = @Administracion_Cajas WHERE Login_Id_Cedula  = @Login_Id_Cedula";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados

            MySqlParameter[] parametros = new MySqlParameter[6];

            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@Login_Id_Cedula";
            parametros[0].Value = pCedula;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Administracion_Clientes";
            parametros[1].Value = pAdminClientes;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Administracion_Inventario";
            parametros[2].Value = pAdminInventario;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.VarChar;
            parametros[3].ParameterName = "@Administracion_Facturas";
            parametros[3].Value = pAdminFacturas;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@Administracion_Empleados";
            parametros[4].Value = pAdminEmpleados;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.VarChar;
            parametros[5].ParameterName = "@Administracion_Cajas";
            parametros[5].Value = pAdminCajas;

            this.cnx.ejecutarSQL(sql, parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

        //Agrega en la base de datos al empleado despues de comprobarse de que no existe uno igual en la base de datos
        public void agregarEmpleado(string pNombreEmpleado, string pApellidos, string pCedula, DateTime pFechaNacimiento, string pEdad, string pSexo, string pTelefono, string pCelular, string pCorreoElectronico, string pContrasenna, string pNombreUsuario, string pDepartamento, DateTime pFechaModificacion, string pModificadoPor, string pCreadoPor) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "INSERT INTO login(Id_Cedula,Nombre,Apellidos,Fecha_Nacimiento,Telefono,Celular,Edad,Sexo,Nombre_Usuario,Contrasenna,Deártamento_Id_Departamento,Email,Fecha_Creacion,Fecha_Modificacion,Creado_Por,Modificado_Por)" +
                " VALUES(@Id_Cedula,@Nombre,@Apellidos,@Fecha_Nacimiento,@Telefono,@Celular,@Edad,@Sexo,@Nombre_Usuario,@Contrasenna,@Deártamento_Id_Departamento,@Email,@Fecha_Creacion,@Fecha_Modificacion,@Creado_Por,@Modificado_Por)";//consulta basica para insertar valores a la base de datos parámetrizada
            MySqlParameter[] parametros = new MySqlParameter[16];
            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@Id_Cedula";
            parametros[0].Value = pCedula;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@Nombre";
            parametros[1].Value = pNombreEmpleado;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@Apellidos";
            parametros[2].Value = pApellidos;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.DateTime;
            parametros[3].ParameterName = "@Fecha_Nacimiento";
            parametros[3].Value = pFechaNacimiento;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@Telefono";
            parametros[4].Value = pTelefono;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.VarChar;
            parametros[5].ParameterName = "@Celular";
            parametros[5].Value = pCelular;

            parametros[6] = new MySqlParameter();
            parametros[6].MySqlDbType = MySqlDbType.VarChar;
            parametros[6].ParameterName = "@Edad";
            parametros[6].Value = pEdad;

            parametros[7] = new MySqlParameter();
            parametros[7].MySqlDbType = MySqlDbType.VarChar;
            parametros[7].ParameterName = "@Sexo";
            parametros[7].Value = pSexo;

            parametros[8] = new MySqlParameter();
            parametros[8].MySqlDbType = MySqlDbType.VarChar;
            parametros[8].ParameterName = "@Nombre_Usuario";
            parametros[8].Value = pNombreUsuario;

            parametros[9] = new MySqlParameter();
            parametros[9].MySqlDbType = MySqlDbType.VarChar;
            parametros[9].ParameterName = "@Contrasenna";
            parametros[9].Value = pContrasenna;

            parametros[10] = new MySqlParameter();
            parametros[10].MySqlDbType = MySqlDbType.VarChar;
            parametros[10].ParameterName = "@Deártamento_Id_Departamento";
            parametros[10].Value = pDepartamento;

            parametros[11] = new MySqlParameter();
            parametros[11].MySqlDbType = MySqlDbType.VarChar;
            parametros[11].ParameterName = "@Email";
            parametros[11].Value = pCorreoElectronico;

            parametros[12] = new MySqlParameter();
            parametros[12].MySqlDbType = MySqlDbType.DateTime;
            parametros[12].ParameterName = "@Fecha_Creacion";
            parametros[12].Value = DateTime.Now;

            parametros[13] = new MySqlParameter();
            parametros[13].MySqlDbType = MySqlDbType.DateTime;
            parametros[13].ParameterName = "@Fecha_Modificacion";
            parametros[13].Value = pFechaModificacion;

            parametros[14] = new MySqlParameter();
            parametros[14].MySqlDbType = MySqlDbType.VarChar;
            parametros[14].ParameterName = "@Creado_Por";
            parametros[14].Value = pCreadoPor;

            parametros[15] = new MySqlParameter();
            parametros[15].MySqlDbType = MySqlDbType.VarChar;
            parametros[15].ParameterName = "@Modificado_Por";
            parametros[15].Value = pModificadoPor;


            this.cnx.ejecutarConsultaSQL(sql, "login", parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }
        
        //Modifica datos de la base de datos 
        public void modificarEmpleado(string pNombreEmpleado, string pApellidos, string pCedula, DateTime pFechaNacimiento, string pEdad, string pSexo, string pTelefono, string pCelular, string pCorreoElectronico, string pContrasenna, string pNombreUsuario,DateTime pFechaCreacion, string pTipoCargo, string pModificadoPor, string pCreadoPor)
        {
            string sql = "UPDATE login SET   nombre = @nombre,apellidos = @apellidos,fecha_Nacimiento = @fecha_Nacimiento,edad = @edad,sexo = @sexo,telefono = @telefono,celular = @celular,email = @email,contrasenna = @contrasenna,nombre_Usuario = @nombre_Usuario,Deártamento_Id_Departamento = @Deártamento_Id_Departamento,creado_Por = @creado_Por,fecha_Creacion = @fecha_Creacion,fecha_Modificacion = @fecha_Modificacion,modificado_Por = @modificado_Por WHERE id_cedula  = @id_cedula";
            //mismo procedimiento que el metódo agregar ,lo que cambia es la consulta update para editar sobre los elementos existentes ,con valores parámetrizados

            MySqlParameter[] parametros = new MySqlParameter[17];

            parametros[0] = new MySqlParameter();
            parametros[0].MySqlDbType = MySqlDbType.VarChar;
            parametros[0].ParameterName = "@nombre";
            parametros[0].Value = pNombreEmpleado;

            parametros[1] = new MySqlParameter();
            parametros[1].MySqlDbType = MySqlDbType.VarChar;
            parametros[1].ParameterName = "@apellidos";
            parametros[1].Value = pApellidos;

            parametros[2] = new MySqlParameter();
            parametros[2].MySqlDbType = MySqlDbType.VarChar;
            parametros[2].ParameterName = "@cedula";
            parametros[2].Value = pCedula;

            parametros[3] = new MySqlParameter();
            parametros[3].MySqlDbType = MySqlDbType.DateTime;
            parametros[3].ParameterName = "@fecha_Nacimiento";
            parametros[3].Value = pFechaNacimiento;

            parametros[4] = new MySqlParameter();
            parametros[4].MySqlDbType = MySqlDbType.VarChar;
            parametros[4].ParameterName = "@edad";
            parametros[4].Value = pEdad;

            parametros[5] = new MySqlParameter();
            parametros[5].MySqlDbType = MySqlDbType.VarChar;
            parametros[5].ParameterName = "@sexo";
            parametros[5].Value = pSexo;

            parametros[6] = new MySqlParameter();
            parametros[6].MySqlDbType = MySqlDbType.VarChar;
            parametros[6].ParameterName = "@telefono";
            parametros[6].Value = pTelefono;

            parametros[7] = new MySqlParameter();
            parametros[7].MySqlDbType = MySqlDbType.VarChar;
            parametros[7].ParameterName = "@celular";
            parametros[7].Value = pCelular;

            parametros[8] = new MySqlParameter();
            parametros[8].MySqlDbType = MySqlDbType.VarChar;
            parametros[8].ParameterName = "@email";
            parametros[8].Value = pCorreoElectronico;

            parametros[9] = new MySqlParameter();
            parametros[9].MySqlDbType = MySqlDbType.VarChar;
            parametros[9].ParameterName = "@contrasenna";
            parametros[9].Value = pContrasenna;

            parametros[10] = new MySqlParameter();
            parametros[10].MySqlDbType = MySqlDbType.VarChar;
            parametros[10].ParameterName = "@nombre_Usuario";
            parametros[10].Value = pNombreUsuario;

            parametros[11] = new MySqlParameter();
            parametros[11].MySqlDbType = MySqlDbType.VarChar;
            parametros[11].ParameterName = "@Deártamento_Id_Departamento";
            parametros[11].Value = pTipoCargo;

            parametros[12] = new MySqlParameter();
            parametros[12].MySqlDbType = MySqlDbType.VarChar;
            parametros[12].ParameterName = "@creado_Por";
            parametros[12].Value = pCreadoPor;

            parametros[13] = new MySqlParameter();
            parametros[13].MySqlDbType = MySqlDbType.DateTime;
            parametros[13].ParameterName = "@fecha_Creacion";
            parametros[13].Value = DateTime.Now;

            parametros[14] = new MySqlParameter();
            parametros[14].MySqlDbType = MySqlDbType.DateTime;
            parametros[14].ParameterName = "@fecha_Modificacion";
            parametros[14].Value = DateTime.Now;

            parametros[15] = new MySqlParameter();
            parametros[15].MySqlDbType = MySqlDbType.VarChar;
            parametros[15].ParameterName = "@modificado_Por";
            parametros[15].Value = pModificadoPor;

            parametros[16] = new MySqlParameter();
            parametros[16].MySqlDbType = MySqlDbType.VarChar;
            parametros[16].ParameterName = "@id_cedula";
            parametros[16].Value = pCedula;

            this.cnx.ejecutarSQL(sql, parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

        public bool Error
        {
            get { return error; }
            set { error = value; }
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }
            set { errorDescripcion = value; }
        }
    }

}
