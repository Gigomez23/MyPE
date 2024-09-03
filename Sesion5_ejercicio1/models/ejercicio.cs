using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sesion5_ejercicio1.models
{
    internal class ejercicio
    {
        public ejercicio() { }

        public bool isMayor(int num1, int num2)
        {
            return num1 > num2;
        }

        public bool isMenor(int num1, int num2)
        {
            return num1 < num2;
        }

        public string EvalueDay(int day)
        {
            switch (day)
            {
                case 1:
                    return "Lunes";
                    break;
                case 2:
                    return "Martes";
                    break;
                case 3:
                    return "Miercoles";
                    break;
                case 4:
                    return "Jueves";
                    break;
                case 5:
                    return "Viernes";
                    break;
                case 6:
                    return "Sabado";
                    break;
                case 7:
                    return "Domingo";
                    break;
                default:
                    return "Digite una opcion valida";
                    break;
            }
        }

    }
}
