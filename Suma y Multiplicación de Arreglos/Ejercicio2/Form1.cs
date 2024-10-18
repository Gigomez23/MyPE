using Ejercicio2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        vuelo Vuelo = new vuelo();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTicket.Items.Clear();
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor degite un nombre. ");
            }
            else
            {
                String name = txtNombre.Text;
                if (cbSmoking.Checked == true && cbNonSmoking.Checked == false)
                {
                    Vuelo.agregarSmoking(name);
                    imprimirTicket(Vuelo);
                }
                else if (cbNonSmoking.Checked == true && cbSmoking.Checked == false)
                {
                    Vuelo.agregarNonSmoking(name);
                    imprimirTicket(Vuelo);
                }
                else
                {
                    string mensaje = "Solo puede escoger un tipo de asiento (smoking o non-smoking).";
                    MessageBox.Show(mensaje);
                }
                txtNombre.Clear();
                txtNombre.Focus();
            }
            
        }

        private void imprimirTicket(vuelo lista)
        {
            bool asientoSmoking = false;
            string name = $"Nombre: {txtNombre.Text}";
            string asiento = "";
            if (cbNonSmoking.Checked == true && cbSmoking.Checked == false)
            {
                asiento = "Asiento: Non-Smoking";
            }
            else{
                asiento = "Asiento: Smoking";
                asientoSmoking = true;
            }

            string numeroDeAsiento = $"Nuemero de asiento: {Vuelo.imprimirAsiento(name, asientoSmoking)}";

            lbTicket.Items.Add(name);
            lbTicket.Items.Add(asiento);
            lbTicket.Items.Add(numeroDeAsiento);
            
        }

    }
}
