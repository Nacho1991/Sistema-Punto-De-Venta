using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using AccesoDatos;

namespace Datos
{
    class ObtenerDatosEmpleado
    {
        AccesoDatosMySql cnx;
        private bool error;
        private string errorDescription;
        private string id_NumeroEmpleado;//
        private string nombre;//
        private string apellidos;//
        private string cedula;//
        private string fechaNacimiento;//
        private string edad;//
        private string sexo;//
        private string telefono;//
        private string celular;//
        private string correoElectronico;//
        private string contrasenna;//
        private string nombreUsuario;//
        private string salarioMensual;//
        private string departamento;//
        private string tipoCargo;//
        private string creadoPor;//
        private string fechaCreacion;//
        private string fechaModificacion;//
        private string modificadoPor;//

        public ObtenerDatosEmpleado(AccesoDatosMySql pCnx)
        {
            cnx = pCnx;
            errorDescription = "";
            error = false;
        }

        public void extractor(string pID_Usuario)
        {
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select id_NumeroEmpleado,nombre,apellidos,cedula,fechaNacimiento,edad,sexo,telefono,celular,correoElectronico,contrasenna,nombreUsuario,salarioMensual,departamento,tipoCargo,creadoPor,fechaCreacion,fechaModificacion,modificadoPor from EMPLEADOS where  id_NumeroEmpleado = '" + pID_Usuario + "'");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        id_NumeroEmpleado = fila["id_NumeroEmpleado"].ToString();
                        nombre = fila["nombre"].ToString();
                        apellidos = fila["apellidos"].ToString();
                        cedula = fila["cedula"].ToString();
                        fechaNacimiento = fila["fechaNacimiento"].ToString();
                        edad = fila["edad"].ToString();
                        sexo = fila["sexo"].ToString();
                        telefono = fila["telefono"].ToString();
                        celular = fila["celular"].ToString();
                        correoElectronico = fila["correoElectronico"].ToString();
                        contrasenna = fila["contrasenna"].ToString();
                        nombreUsuario = fila["nombreUsuario"].ToString();
                        salarioMensual = fila["salarioMensual"].ToString();
                        departamento = fila["departamento"].ToString();
                        TipoCargo = fila["tipoCargo"].ToString();
                        creadoPor = fila["creadoPor"].ToString();
                        fechaCreacion = fila["fechaCreacion"].ToString();
                        fechaModificacion = fila["fechaModificacion"].ToString();
                        modificadoPor = fila["modificadoPor"].ToString();
                        
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error validando usuario: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error de extracción de datos.";
            }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Id_NumeroEmpleado
        {
            get { return id_NumeroEmpleado; }
            set { id_NumeroEmpleado = value; }
        }
        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }

        public string FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }
        public string FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string SalarioMensual
        {
            get { return salarioMensual; }
            set { salarioMensual = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string TipoCargo
        {
            get { return tipoCargo; }
            set { tipoCargo = value; }
        }
        public string Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
    }
}
