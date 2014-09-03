using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using AccesoDatos;

namespace Datos
{
    class RegistroInicioSesion
    {
        AccesoDatosMySql cnx;
        private bool error = false;


        private string errorDescripcion;

        public RegistroInicioSesion(AccesoDatosMySql pCnx) 
        {
            errorDescripcion = "";
            this.cnx = pCnx;
            error = false;
        }

        public DataSet ObtenerRegistrosInicioSesion()
        {
            DataSet retorno = new DataSet();
            string sql = "Select * from REGISTROINICIOSESION";
            retorno = cnx.ejecutarConsultaSQL(sql);
            return retorno;
        }

        public void registroInicio(string pCodigoEmpleado,string pNombreEmpleado,string pTipoEmpleado,DateTime pFechaHora) //se recibe por parámetros los valores de NuevoUsuario
        {
            string sql = "Insert into REGISTROINICIOSESION(ID_HoraInicio,CodigoEmpleado,NombreEmpleado,tipoEmpleado)" +
                                    " Values(:ID_HoraInicio,:CodigoEmpleado,:NombreEmpleado,:tipoEmpleado)";//consulta basica para insertar valores a la base de datos parámetrizada
            OracleParameter[] parametros = new OracleParameter[4];

            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.DateTime;
            parametros[0].ParameterName = ":ID_HoraInicio";
            parametros[0].Value = pFechaHora;

            parametros[1] = new OracleParameter();
            parametros[1].OracleType = OracleType.VarChar;
            parametros[1].ParameterName = ":NombreEmpleado";
            parametros[1].Value = pNombreEmpleado;

            parametros[2] = new OracleParameter();
            parametros[2].OracleType = OracleType.VarChar;
            parametros[2].ParameterName = ":tipoEmpleado";
            parametros[2].Value = pTipoEmpleado;

            parametros[3] = new OracleParameter();
            parametros[3].OracleType = OracleType.VarChar;
            parametros[3].ParameterName = ":CodigoEmpleado";
            parametros[3].Value = pCodigoEmpleado;


            this.cnx.ejecutarConsultaSQL(sql, "REGISTROINICIOSESION", parametros);
            this.error = this.cnx.IsError;
            this.errorDescripcion = this.cnx.ErrorDescripcion;
        }

        public string ErrorDescripcion
        {
            get { return errorDescripcion; }
            set { errorDescripcion = value; }
        }
        public bool Error
        {
            get { return error; }
            set { error = value; }
        }
    }
}
