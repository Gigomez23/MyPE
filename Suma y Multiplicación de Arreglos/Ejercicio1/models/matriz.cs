using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class matriz
    {
        public matriz() { }
 
        public int[,] lista = { { 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0 }, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0} };

        public int[] listaSumas = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public int suma(int a, int b)
        {
            return a + b;
        }

        public void agregarValorSuma(int suma)
        {
            suma -= 1;
            listaSumas[suma] += 1;
        }
        
        public void agregarValorLista(int a, int b)
        {
            a -= 1;
            b -= 1;
            lista[a, b] += 1;
        }

    }
}
