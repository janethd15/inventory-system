using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorInventario
{
    public partial class VerTablaMov : Form
    {
        public VerTablaMov()
        {
            InitializeComponent();
        }

        private void VerTablaMov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'intelafDataSet7.Movimientos' Puede moverla o quitarla según sea necesario.
            this.movimientosTableAdapter4.Fill(this.intelafDataSet7.Movimientos);
            
        

        }
        //Regresar a la ventana Movimientoss para seguir agregando datos o ir al Menú
        private void btnback_Click(object sender, EventArgs e)
        {
            Movimiento abrirmovi = new Movimiento();
            abrirmovi.Show();
            Hide();
        }

        private void VerTablaMov_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'intelafDataSet8.Movimientos' Puede moverla o quitarla según sea necesario.
            this.movimientosTableAdapter5.Fill(this.intelafDataSet8.Movimientos);

        }
    }
}


