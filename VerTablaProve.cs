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
    public partial class VerTablaProve : Form
    {
        public VerTablaProve()
        {
            InitializeComponent();
        }
        private void VerTablaProve_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'intelafDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.intelafDataSet.Proveedores);

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Proveedores abrirProve = new Proveedores();
            abrirProve.Show();
            Hide();
        }

       
    }
}