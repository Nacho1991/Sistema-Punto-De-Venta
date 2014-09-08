using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    class PruebaConexion
    {
        public bool isError 
        { 
            get; 
            set; 
        }
        public string errroDescription { get; set; }
        public PruebaConexion() 
        {

        }
        public bool probarConexion(string pServidor,string pBaseDatos,string pUsuario, string pContrasenna,string pPuerto) 
        {
            bool conectado = false;
            string CN = "Server=" + pServidor + ";" + "database=" + pBaseDatos + ";" + "Uid=" + pUsuario + ";" + " pwd=" + pContrasenna + ";" + "port=" + pPuerto + ";"; 
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                sqlcon.ConnectionString = CN;
                sqlcon.Open();
            }
            catch (Exception ex)
            {
                isError = true;
                errroDescription = ex.Message;
            }

            if (sqlcon.State == ConnectionState.Open)
            {
                conectado = true;
            }
            sqlcon.Close();
            return conectado;
        }
    }
}
