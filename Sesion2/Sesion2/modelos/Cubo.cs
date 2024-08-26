/**
 * Archivo: Cubo
 * autor: Gabriel Gómez
 * descripcion: Contiene clase y metodos de Cubo 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sesion2.modelos
{
    internal class Cubo
    {
        public Cubo() { }
        public double Numero {  get; set; }
        public double NumeroCubo { get; set; }

        //Funcion que imprime el cubo
        public override string ToString()
        {
            return $"El cubo de {Numero} es de {CalcularCubo()}";
        }

        //Funcion que calcula el area de un Cubo
        public double CalcularCubo()
        {
            NumeroCubo = Math.Pow(Numero, 3);
            return NumeroCubo;
    }


    }

}
