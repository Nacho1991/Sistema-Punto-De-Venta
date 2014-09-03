using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class InventarioL
    {
        private string idProducto;
        private string nombre;
        private string marca;
        private string descripcion;
        private string precioCompra;
        private string precioVenta;
        private string existencia;
        private string cantidad;
        private string fechaEntrada;

        public InventarioL(string pIdProducto, string pNombre, string pMarca, string pDescripcion, string pPrecioCompra, string pPrecioVenta, string pExistencia, string pCantidad, string pFechaEntrada)
        {
            idProducto = pIdProducto;
            nombre = pNombre;
            marca = pMarca;
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = pPrecioVenta;
            existencia = pExistencia;
            cantidad = pCantidad;
            fechaEntrada = pFechaEntrada;
        }
        public string IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string PrecioCompra
        {
            get { return precioCompra; }
            set { precioCompra = value; }
        }
        public string PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public string Existencia
        {
            get { return existencia; }
            set { existencia = value; }
        }
        public string Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public string FechaEntrada
        {
            get { return fechaEntrada; }
            set { fechaEntrada = value; }
        }
    }
}
