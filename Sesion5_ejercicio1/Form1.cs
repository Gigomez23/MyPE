using Sesion5_ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion5_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Numero1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tBNumbre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lBLAnswer_Click(object sender, EventArgs e)
        {

        }

        private void bTNMayor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tBNumbre1.Text);
                int num2 = int.Parse(tBNumber2.Text);
                ejercicio ejercicio = new ejercicio();
                if (ejercicio.isMayor(num1, num2)) lBLAnswer.Text = $"{num1} es mayor que {num2}";
                else if (ejercicio.isMayor(num2, num1)) lBLAnswer.Text = $"{num2} es mayor que {num1}";
                else lBLAnswer.Text = $"{num2} es igual que {num1}";
            }catch (Exception ex)
            {
                lBLAnswer.Text = ex.Message;
            }
        }

        private void bTNMenor_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tBNumbre1.Text);
                int num2 = int.Parse(tBNumber2.Text);
                ejercicio ejercicio = new ejercicio();
                if (ejercicio.isMenor(num1, num2)) lBLAnswer.Text = $"{num1} es menor que {num2}";
                if (ejercicio.isMenor(num2, num1)) lBLAnswer.Text = $"{num2} es menor que {num1}";
                else lBLAnswer.Text = $"{num2} es igual que {num1}";
            }catch(Exception ex)
            {
                lBLAnswer.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tBNumbre1.Text);
            int num2 = int.Parse(tBNumber2.Text);
            int res = Math.Max(num1, num2);
            lBLAnswer.Text = "El nuero mayor es: " + res.ToString();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
