/**
 * Archivo: Producto
 * autor: Gabriel Gómez
 * descripcion: Contiene clase y metodos de Producto 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sesion2.modelos
{
    internal class Producto
    {
        public Producto () { }
        public string NombreProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }
        public double CostoFinal {  get; set; }

        //Funcion que imprime los datos
        public override string ToString()
        {
            return $"Nombre del producto: {NombreProducto} \nPrecio: C${PrecioProducto} \nCantidad: {CantidadProducto} \nPrecio Final: C${CalcularCantidad()}";
        }

        //Funcion que calcula la cantidad a pagar final
        public double CalcularCantidad()
        {
            CostoFinal = PrecioProducto * CantidadProducto;
            return CostoFinal;
        }

    }
}
