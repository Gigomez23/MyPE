/**
 * Archivo: AreaCirculo
 * autor: Gabriel Gómez
 * descripcion: Contiene clase y metodos de AreaCirculo 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2.modelos
{
    internal class AreaCirculo
    {
        public AreaCirculo() { }
        public double Numero {  get; set; }
        public double AreaDeCirculo { get; set; }

        //Funcion que imprime el area del circulo
        public override string ToString()
        {
            return $"El area del circulo con radio de: {Numero} es de: {CalcularArea()}";
        }

        //Funcion que calcula el area de un circulo
        public double CalcularArea()
        {
            double numeroCuadrado = Math.Pow(Numero, 2);
            AreaDeCirculo = numeroCuadrado * 3.14;
            return AreaDeCirculo;
        }
    }
}
