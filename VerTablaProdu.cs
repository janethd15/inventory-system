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
using PruebaConexionBD1;

namespace GestorInventario
{
    public partial class VerTablaProdu : Form
    {
        Conexion objConexion = new Conexion();
        public VerTablaProdu()
        {

            InitializeComponent();
        }

        private void VerTablaProdu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'intelafDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.intelafDataSet.Productos);

        }
        //Regresar a la ventana productos para seguir agregando datos o ir al Menú
        private void btnback_Click(object sender, EventArgs e)
        {
            Productos abrirproducto = new Productos();
            abrirproducto.Show();
            Hide(); 
        }

        

      

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter.FillBy(this.intelafDataSet.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //este botón sirve para alertar de que un producto crítico alcance el stock minimo
        private void btnVeriStock_Click(object sender, EventArgs e)
        {
            // Conectar con la BD 
            string connectionString = @"Server=DESKTOP-OPGRA4G;Database=Intelaf;Trusted_Connection=True;";

            try
            {
                // 1️   Cargar datos directamente desde SQL Server
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT Id, codigo, Nombre, Categoria, Precio, Stock, StockMinimo, ProveedorId FROM Productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dt);
                }

                // Cargar datos en el DataGridView
                dgvProductos.DataSource = dt;

                // 2️ Verificar si hay productos con stock bajo
                bool hayStockBajo = false;
                foreach (DataRow fila in dt.Rows)
                {
                    int stock = Convert.ToInt32(fila["Stock"]);
                    int stockMin = Convert.ToInt32(fila["StockMinimo"]);

                    if (stock <= stockMin)
                    {
                        hayStockBajo = true;
                        break;
                    }
                }

                // 3️ Mostrar mensaje y resaltar si es necesario
                if (!hayStockBajo)
                {
                    MessageBox.Show("Todos los productos tienen stock suficiente.",
                                    "Verificación de Stock",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Hay productos con bajo stock. ¿Deseas resaltarlos?",
                        "Alerta de Stock Bajo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow fila in dgvProductos.Rows)
                        {
                            if (fila.Cells[5].Value != null && fila.Cells[6].Value != null)
                            {
                                int stock = Convert.ToInt32(fila.Cells[5].Value);
                                int stockMin = Convert.ToInt32(fila.Cells[6].Value);

                                if (stock <= stockMin)
                                {
                                    fila.DefaultCellStyle.BackColor = Color.Coral;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

     
    }
}
