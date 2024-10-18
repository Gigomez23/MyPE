using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            matriz Matriz = new matriz();
            Random rng = new Random();
            int progreso = 0;
            for (int i = 0; i < 36000; i++)
            {
                int dado1 = rng.Next(1, 7);
                int dado2 = rng.Next(1, 7);
                Matriz.agregarValorLista(dado1, dado2);
                Matriz.agregarValorSuma(Matriz.suma(dado1, dado2));
            }
            ImprimirValores(Matriz);
            ImprimirSumas(Matriz);

            
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ImprimirValores(matriz listaNumeros)
        {
            string textoTitulo = "        1     2      3      4      5      6";
            lbLista.Items.Add(textoTitulo);
            for (int i = 0;i < 6; i++)
            {
                string texto = $"{i + 1}   {listaNumeros.lista[i, 0]} {listaNumeros.lista[i, 1]} {listaNumeros.lista[i, 2]} {listaNumeros.lista[i, 3]} {listaNumeros.lista[i, 4]} {listaNumeros.lista[i, 5]}";
                lbLista.Items.Add(texto);
            }
        }

        private void ImprimirSumas(matriz listaNumeros)
        {
            for (int i =0; i < 12; i++)
            {
                string texto = $"{i + 1} {listaNumeros.listaSumas[i]}";
                lbSumas.Items.Add(texto);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
