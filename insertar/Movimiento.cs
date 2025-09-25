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
    public partial class Movimiento : Form
    {
        Conexion objConexion = new Conexion();
        public Movimiento()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtProdId.Clear();
            txtMov.Clear();
            txtCant.Clear();
            txtFecha.Clear();
            txtRes.Clear();



        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerTablaMov abrirtablamov = new VerTablaMov();
            abrirtablamov.Show();
            Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            index abririndex = new index();
            abririndex.Show();
            Hide();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProdId.Text) ||
               string.IsNullOrWhiteSpace(txtMovId.Text) ||
               string.IsNullOrWhiteSpace(txtMov.Text) ||
               string.IsNullOrWhiteSpace(txtCant.Text) ||
               string.IsNullOrWhiteSpace(txtFecha.Text) ||
               string.IsNullOrWhiteSpace(txtRes.Text))
              
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.",
                                "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener ejecución si hay campos vacíos
            }
            string IngresarProducto = "INSERT INTO " + objConexion.nombreBD() + ".dbo.Movimientos" +
                          "(ProductoId, TipoMovimiento, Cantidad, Fecha, Responsable, MovId)" +
                          " VALUES(@ProductosId, @TipoMovimiento, @Cantidad, @Fecha, @Responsable, @MovId);";
            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand comando = new SqlCommand(IngresarProducto, conexion))
                {
                    //le pasams los parametros a la consulta
                    comando.Parameters.AddWithValue("@MovId", txtMovId.Text);
                    comando.Parameters.AddWithValue("@ProductosId", txtProdId.Text);
                    comando.Parameters.AddWithValue("@TipoMovimiento", (txtMov.Text));
                    comando.Parameters.AddWithValue("@Cantidad", (txtCant.Text));
                    comando.Parameters.AddWithValue("@Fecha", (txtFecha.Text));
                    comando.Parameters.AddWithValue("@Responsable", (txtRes.Text));

                    int ejecutar = comando.ExecuteNonQuery();

                    if (ejecutar > 0)
                    {
                        MessageBox.Show("Dato ingresado correctamente", "Ingresar Datos", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("error, no se ingreso el dato correctamente", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se ingreso el dato", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtProdId.Enabled = true;
            btnBuscar.Enabled = true;
            string actualizar = @"Update " + objConexion.nombreBD() + ".dbo.Movimientos" +
                             " SET ProductoID = @ProductoID ,TipoMovimiento = @TipoMovimiento," +
                             "Cantidad = @Cantidad ,Fecha = @Fecha ," +
                             "Responsable = @Responsable ,MovId = @MovId WHERE MovId = @MovId";

            SqlConnection conexion = objConexion.AbrirConexion();
            try
            {
                using (SqlCommand comando = new SqlCommand(actualizar, conexion))
                {

                    comando.Parameters.AddWithValue("@MovId", txtMovId.Text);
                    comando.Parameters.AddWithValue("@ProductoID", txtProdId.Text);
                    comando.Parameters.AddWithValue("@TipoMovimiento", txtMov.Text);
                    comando.Parameters.AddWithValue("@Cantidad", txtCant.Text);
                    comando.Parameters.AddWithValue("@Fecha", txtFecha.Text);
                    comando.Parameters.AddWithValue("@Responsable", txtRes.Text);


                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Información actualizada", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        btnActualizar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la Información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al actualizar" + ex.Message);
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }



        private void btneliminar_Click(object sender, EventArgs e)
        {
            txtProdId.Enabled = true;
            btnBuscar.Enabled = true;
            string eliminar = @"DELETE FROM " + objConexion.nombreBD() + ".dbo.Movimientos WHERE MovId = @MovId";

            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand(eliminar, conexion))
                {
                    cmd.Parameters.AddWithValue("@MovId", txtMovId.Text);

                    if (MessageBox.Show("¿Estás seguro de eliminar esta Información", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("La Información se ha eliminado exitosamente");
                            Limpiar();
                            btneliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningúna Información con ese ID");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó la Información");

                        btnBuscar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);

                btnBuscar.Enabled = true;
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMovId.Text))
            {
                MessageBox.Show("Debe de ingresar un Id para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta SQL corregida con los nombres correctos
            string buscar = @"SELECT ProductoID, TipoMovimiento, Cantidad, Fecha, Responsable, MovId
                              FROM " + objConexion.nombreBD() + ".dbo.Movimientos"
                             + " WHERE MovId = @MovId";

            SqlConnection conexion = objConexion.AbrirConexion();
            if (conexion == null) return;

            try
            {
                using (SqlCommand comando = new SqlCommand(buscar, conexion))
                {
                    comando.Parameters.AddWithValue("@MovId", txtMovId.Text);

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            txtMovId.Text = leer["MovId"].ToString();
                            txtProdId.Text = leer["ProductoID"].ToString();
                            txtMov.Text = leer["TipoMovimiento"].ToString();
                            txtCant.Text = leer["Cantidad"].ToString();
                            txtFecha.Text = leer["Fecha"].ToString();
                            txtRes.Text = leer["Responsable"].ToString();


                            // Solo si encontró, entonces desactiva el campo código y botones
                            txtProdId.Enabled = false;
                            btnBuscar.Enabled = false;
                            btneliminar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la Información con ese código", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el código: " + ex.Message);
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }
    }
}

