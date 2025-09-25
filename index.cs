using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        //Botón para ingresar a la ventana de Productos
        private void button1_Click(object sender, EventArgs e)
        {
            Productos abrirFrom3 = new Productos();
            abrirFrom3.Show();
            this.Hide();
        }

        //Botón para ingresar a la ventana de Proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Proveedores abrirFrom4 = new Proveedores();
            abrirFrom4.Show();
            this.Hide();
        }

        //Botón para ingresar a la ventana de Movimientos
        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            Movimiento abrirFrom5 = new Movimiento();
            abrirFrom5.Show();
            this.Hide();
        }

        //Botón para ingresar a la ventana de Inicio
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 abrirFrom1 = new Form1();
            abrirFrom1.Show();
            this.Hide();
        }
    }
}
