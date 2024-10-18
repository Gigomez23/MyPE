using Sesion17.Modelos;
using Sesion17.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sesion17.Formularios
{
    public partial class ProductoFrm : Form
    {
        ProductoServicio productos = new ProductoServicio();
        public ProductoFrm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Id = int.Parse(tbId.Text);
            producto.Nombre = tbName.Text;
            producto.Descripcion = tbDescription.Text;
            producto.Precio = double.Parse(tbPrice.Text);
            productos.AgregarProducto(producto);
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos.GetProductos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
