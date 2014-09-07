using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorArchivos
{
    public interface AccesoDatosTxt
    {
        // Metodo que nos permitira conectarnos al sistema.
        void Conectar();

        //Metodo que nos va a permitir escribir lineas de texto, en el documento de texto para luego ser mostradas en pantalla.
        void Escribir(string hilera);

        //Metodo que nos leera las listas o el documento de texto, para asi poder ser mostrados hacia el usuario.
        string Leer();

        //Metodo que nos editará algunos datos, ya sean personas o periodos electorales.
        void Editar(string ID, string moidificar);

        //Metodo que atravez de un identificador nos eliminara lo que deseemos
        void Eliminar(string ID);

        //Metodo que nos validara, diferentes acciones que el usuario quiera ejecutar.
        bool Validar(string pDato);


        //Metodo que nos ayudara en caso de algun error presentado
        bool isError { set; get; }

        //Nos presentara, una breve descripcion sobre el error que esta ocurriendo
        string ErrorDescripcion { set; get; }
    }
}
