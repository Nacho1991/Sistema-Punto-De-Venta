using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioL
    {
        private string cedula;
        private string nombre;
        private string apellidos;
        private string fechaNacimiento;
        private string telefono;
        private string celular;
        private string edad;
        private string sexo;
        private string nombreUsuario;
        private string contrasenna;
        private string direcPerfil;
        private string email;
        private string fechaCreacion;
        private string fechaModificacion;
        private string creadoPor;
        private string modificadoPor;
        private string departamento;

        public UsuarioL() 
        {

        }

        public UsuarioL(
            string pFechaNacimiento,string pTelefono,string pCelular,string pEdad,string pSexo,string pEmail,string pFechaCreacion,
            string pFechaModificacion,string pCreadoPor,string pModificadoPor,
            string pNombreUsuario, string pContrasenna, string pDireccPerfil,string pCedula,string pDepartamento, string pNombre, string pApellidos)
        {
            cedula = pCedula;
            nombre = pNombre;
            apellidos = pApellidos;
            fechaNacimiento = pFechaNacimiento;
            telefono = pTelefono;
            celular = pCelular;
            direcPerfil = pDireccPerfil;
            edad = pEdad;
            sexo = pSexo;
            nombreUsuario = pNombreUsuario;
            contrasenna = pContrasenna;
            email = pEmail;
            fechaCreacion = pFechaCreacion;
            fechaModificacion = pFechaModificacion;
            creadoPor = pCreadoPor;
            modificadoPor = pModificadoPor;
            departamento = pDepartamento;
        }
        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }
        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }
        public string DirecPerfil
        {
            get { return direcPerfil; }
            set { direcPerfil = value; }
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
        public string Email
        {
            get { return email; }
            set { email = value; }
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
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public override string ToString()
        {
            return "Login: " + this.NombreUsuario + ", Descripcion: " + this.Departamento;
        }
    }
}
