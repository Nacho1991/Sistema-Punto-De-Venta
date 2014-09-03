using AccesoDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ClienteD
    {
        AccesoDatosMySql cnx;//Variable de conexion
        bool error;//Variable de error
        string errorDescripcion; //Varable que guarda el detalle del error
        //Constructor
        public ClienteD(AccesoDatosMySql pCnx) //Se envia por parametro la conexion
        {
            cnx = pCnx;
            error = false;
            errorDescripcion = "";
        }
        //Gets y Sets
        public bool Error
        {
            get { return error; }
        }
        public string ErrorDescripcion
        {
            get { return errorDescripcion; }
        }
        //Metodo encargado de obtener los detalles de los clientes
        public List<ClienteL> obtenerDetalles(string pCliente)
        {
            //Creacion de la lista de la clase ClienteL
            List<ClienteL> retorno = new List<ClienteL>();
            try
            {
                MySqlParameter[] parametros = new MySqlParameter[1];

                parametros[0] = new MySqlParameter();
                parametros[0].MySqlDbType = MySqlDbType.VarChar;
                parametros[0].ParameterName = "@Cliente_Credito_Id_Cedula";
                parametros[0].Value = pCliente;
                //Envio de la sentencia SQL
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Area_Credito where Cliente_Credito_Id_Cedula = @Cliente_Credito_Id_Cedula", "Area_Credito", parametros);
                if (this.cnx.IsError == false)
                {
                    //Carga de la lista con los datos del cliente
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new ClienteL(
                                               fila["Id_Registro"].ToString(),
                                               fila["Cliente_Credito_Id_Cedula"].ToString(),
                                               fila["Monto_Acreditado"].ToString(),
                                               fila["Monto_Actual"].ToString(),
                                               fila["Periodo_Pago"].ToString(),
                                               fila["Fecha_Inicio_Credito"].ToString()
                                               ));
                    }
                }
                else
                {
                    //En caso de error por parte de la clase AccesoDatosMySql la variable se vuelve en true
                    this.error = true;
                    //Se guarda el detalle del error
                    this.errorDescripcion = "Error al obtener los detalles de crédito: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                //En caso de error en esta clase la variable se vuelve en True
                this.error = true;
                //Se guarda el detalle del error en la variable
                this.errorDescripcion = "Error al obetener los detalles de crédito:" + e.Message;
            }
            //Se retorna la lista con los datos cargados
            return retorno;
        }
    }
}
