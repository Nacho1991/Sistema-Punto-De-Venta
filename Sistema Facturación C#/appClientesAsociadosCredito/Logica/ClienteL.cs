using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class ClienteL
    {
        //Variables
        string registro;
        string cedula;
        string montoAcreditado;
        string montoActual;
        string periodoPago;
        string inicioCredito;
        //Constructor
        public ClienteL(string pRegistro,string pCedula,string pMontoAcreditado,string pMontoActual, string pPeriodoPago,string pInicioCredito) 
        {
            registro = pRegistro;
            cedula = pCedula;
            montoAcreditado = pMontoAcreditado;
            montoActual = pMontoActual;
            periodoPago = pPeriodoPago;
            inicioCredito = pInicioCredito;
        }
        //Gets y Sets
        public string InicioCredito
        {
            get { return inicioCredito; }
            set { inicioCredito = value; }
        }
        public string PeriodoPago
        {
            get { return periodoPago; }
            set { periodoPago = value; }
        }
        public string MontoActual
        {
            get { return montoActual; }
            set { montoActual = value; }
        }
        public string MontoAcreditado
        {
            get { return montoAcreditado; }
            set { montoAcreditado = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Registro
        {
            get { return registro; }
            set { registro = value; }
        }
    }
}
