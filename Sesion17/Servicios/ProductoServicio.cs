using Sesion17.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion17.Servicios
{
    internal class ProductoServicio
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> GetProductos()
        {
            return productos;
        }

        public void EliminarProducto(Producto producto)
        {
            productos.Remove(producto);
        }
    }
}
