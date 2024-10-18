using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Ejercicio2.model
{
    internal class vuelo
    {
        public vuelo() { }

        string[] smokingList = new string[5];

        string[] nonSmokingList = new string[5];

        public void agregarSmoking(string nombre)
        {
            if (smokingList[4] == null)
            {
                agregarNombre(smokingList, nombre);
            }
            else if (nonSmokingList[4] == null && smokingList[4] != null)
            {
                DialogResult mensaje = MessageBox.Show("Los asientos reservados para fumar estan llenos, esta de acuerdo en ser asignado un asiento en el area libre de humo?", "Advertencia", MessageBoxButtons.YesNo);
                if (mensaje == DialogResult.Yes)
                {
                    agregarNombre(nonSmokingList, nombre);
                }
                else
                {
                    MessageBox.Show("No hay asientos disponibles, el próximo vuelo sale dentro de 3 horas. ");
                }
            }
            else
            {
                MessageBox.Show("No hay asientos disponibles, el próximo vuelo sale dentro de 3 horas. ");
            }
        }

        public void agregarNonSmoking(string nombre)
        {
            if (nonSmokingList.Length != 5)
            {
                agregarNombre(nonSmokingList, nombre);
            }
            else if (smokingList.Length != 5 && nonSmokingList.Length == 5)
            {
                DialogResult mensaje = MessageBox.Show("Los asientos libre de humo estan lleno, esta de acuerdo en ser asignado un asiento del area de fumar?", "Advertencia", MessageBoxButtons.YesNo);
                if (mensaje == DialogResult.Yes)
                {
                    agregarNombre(smokingList, nombre);
                }
                else
                {
                    MessageBox.Show("No hay asientos disponibles, el próximo vuelo sale dentro de 3 horas. ");
                }
            }
            else
            {
                MessageBox.Show("No hay asientos disponibles, el próximo vuelo sale dentro de 3 horas. ");
            }
        }

        public int imprimirAsiento(string nombre, bool isSmoking)
        {
            if (isSmoking)
            {
                int numeroAsiento = Array.IndexOf(smokingList, nombre);
                return numeroAsiento;
            }
            else
            {
                int numeroAsiento = Array.IndexOf(nonSmokingList, nombre);
                return numeroAsiento;
            }
        }

        public void agregarNombre(string[] lista, string nombre)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                // Find the first empty position (null means it's uninitialized for strings)
                if (lista[i] == null)
                {
                    lista[i] = nombre;
                    break; // Exit the loop once the item is added
                }
            }
        }

    }
}
