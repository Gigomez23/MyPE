/**
 * Archivo: Raiz
 * autor: Gabriel Gómez
 * descripcion: Contiene clase y metodos de Raiz 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2.modelos
{
    class Raiz
    {
        public Raiz() { }
        public double Numero {  get; set; }
        public double NumeroRaiz {  get; set; }
        
        //Funcion que imprime la raiz
        public override string ToString()
        {
            return $"La raíz cuadrada de {Numero} es de {CalcularNumeroRaiz()}";
        }

        //Funcion que calcula la raiz
        public double CalcularNumeroRaiz()
        {
            NumeroRaiz = Math.Sqrt(Numero);
            return NumeroRaiz;
        }
    }
}
