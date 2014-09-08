using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorArchivos
{
    public class AccessoTxt : AccesoDatosTxt
    {
        //ruta en la cual vamos a guardar nuestro documento de texto con los candidatos registrados
        string ruta = Application.StartupPath + "\\" + "configForm.txt";


        /*Metodo que nos ayudara a conectarnos al sistema. Si el archivo existe nos emitira un mensaje de error,
        pues nos creara un nuevo documento de texto*/
        public void Conectar()
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                }
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
        }

        /*Metodo que una vez ya conectados al sistema, nos ayudara a escribir lineas de texto en el documento.
        si no se puedo conectar sistema, nos mostrara un error en pantalla*/
        public void Escribir(string hilera)
        {
            try
            {
                this.Conectar();
                using (StreamWriter escritor = new StreamWriter(ruta, true))
                {
                    escritor.WriteLine(hilera);
                    escritor.Close();
                }
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
        }

        /*Metodo que nos ayudara a ingresar correctamente al sistema,
        en caso de algun error de digitacion o existencia de usuario, nos mostrara un error acontinuacion*/
        public bool ValidarAcceso(string pCedula, string pContrasenna)
        {
            bool userExistente = false;
            return userExistente;
        }

        /*Metodo que nos editará algunos datos del candidato, tendra que estar obviamente conectado al sistema,
         * nos escribira a nueva linea con los datos nuevos, y la reemplazara con la existente.
         * */

        public void Editar(string ID, string moidificar)
        {
            try
            {
                this.Conectar();
                StringBuilder agregarLinea = new StringBuilder();
                StreamReader sr = new StreamReader(ruta);
                StreamWriter sw;
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(new char[] { ',' });
                    if (linea.Contains(ID))
                    {
                        agregarLinea.AppendLine(moidificar);
                    }
                    else
                    {
                        agregarLinea.AppendLine(linea);
                    }
                }
                sr.Close();
                sw = new StreamWriter(ruta);
                sw.Write(agregarLinea);
                sw.Close();
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
        }
        public string TipoBaseDatos
        {
            get;
            set;
        }

        //Metodo que valida los candidatos, en caso de existencia, o datos ingresados, en caso de error se notificara al usuario.
        public bool Validar(string pDatos)
        {
            bool existe = false;
            Conectar();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                string line = "";
                while ((line = lector.ReadLine()) != null)
                {
                    string[] datos = line.Split(new char[] { ',' });
                    if (datos[0] == pDatos)
                    {
                        if (datos[1] == "True")
                        {
                            existe = true;
                            TipoBaseDatos = datos[2];
                            break;
                        }
                        else if (datos[1] == "False")
                        {
                            TipoBaseDatos = datos[2];
                            existe = false;
                            break;
                        }
                    }
                    else
                    {
                        existe = false;
                    }
                }
                lector.Close();
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
            return existe;

        }

        //Metodo que nos leera los candidatos del dicho documento, para asi poder ser mostrados hacia el usuario.
        public string Leer()
        {
            StringBuilder lector = new StringBuilder();
            try
            {
                this.Conectar();
                using (StreamReader sr = new StreamReader(ruta))
                {
                    while (sr.Peek() >= 0)
                    {
                        lector.AppendLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
            return lector.ToString();
        }


        //Metodo capaz de eliminarnos el candidato que elijamos en el momento que nos muestra todos los candidatos disponibles.
        public void Eliminar(string ID)
        {
            try
            {
                this.Conectar();
                StringBuilder agregarLinea = new StringBuilder();
                StreamReader sr = new StreamReader(ruta);
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    if (!linea.Contains(ID))
                    {
                        agregarLinea.AppendLine(linea);
                    }
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(ruta);
                sw.Write(agregarLinea);
                sw.Close();
            }
            catch (Exception xp)
            {
                isError = true;
                ErrorDescripcion = xp.Message;
            }
        }

        //Metodo que nos ayudara a setear o obtener el error.
        public bool isError
        {
            set;
            get;
        }

        //Metodo que nos ayudara a obtener o establecer una descripcion de algun error mostrado.
        public string ErrorDescripcion
        {
            set;
            get;
        }
    }
}
