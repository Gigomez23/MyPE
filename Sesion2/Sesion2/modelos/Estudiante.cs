/**
 * Archivo: Estudiante
 * autor: Gabriel Gómez
 * descripcion: Contiene clase y metodos Estudiante 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2.modelos
{
    internal class Estudiante
    {
        public Estudiante() { }
        
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public double NotaFinal { get; set; }
        
        //Funcion que imprime todos los datos
        public override string ToString()
        {
            return $"Nombre: {Nombre} \nCarrera {Carrera} \nPrimera Nota: {Nota1} \nPrimerCualitativo: {EvaluarEstudiante(Nota1)}\nSegunda Nota: {Nota2} \nSegundo Cualitativo: {EvaluarEstudiante(Nota2)} \nTercera Nota: {Nota3}\nTercer Cualitativo: {EvaluarEstudiante(Nota3)} \nNota Final: {NotaFinalEstudiante()} \nFinal Cualitativo: {EvaluarEstudiante((int)NotaFinal)}";  
        }

        //Funcion que Evalua la nota 
        public string EvaluarEstudiante(int nota)
        {
            if (nota >= 70)
            {
                return $"Aprobado";
            }
            else if (nota >= 0 && nota <= 69)
            {
                return "Reprobado";
            }
            return "Ingrese una nota valida";
        }

        //Funcion que calcula el promedio final del estudiante
        public double NotaFinalEstudiante()
        {
            NotaFinal = (Nota1 + Nota2 + Nota3) / 3;
            return NotaFinal;
        }
    }
}
