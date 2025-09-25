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
    public partial class Proveedores : Form
    {
        Conexion objConexion = new Conexion();
        public Proveedores()
        {
            InitializeComponent();
        }
          private void Activar()
                {
                    txtNombre.Enabled = true;
                    txtConta.Enabled = true;
                    txtCui.Enabled = true;          
                    btnActualizar.Enabled = true;
                }

        //para limpiar las casillas despúes de usar cada botón
        private void Limpiar()
        {
            txtCui.Clear();
            txtNombre.Clear();
            txtConta.Clear();

        }
      

        //boton para regresar al menu
        private void btnback_Click(object sender, EventArgs e)
        {
            index abrirmenu = new index();
            abrirmenu.Show();
            this.Hide();
        }

        //boton de guardar
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCui.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
             string.IsNullOrWhiteSpace(txtConta.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.",
                                "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener ejecución si hay campos vacíos
            }

            string IngresarProducto = "INSERT INTO " + objConexion.nombreBD() + ".dbo.Proveedores" +
                "(CUI, Nombre, Contacto)" +
                " VALUES (@CUI, @Nombre, @Contacto);";
            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand comando = new SqlCommand(IngresarProducto, conexion))
                {
                    //le pasams los parametros a la consulta
                    comando.Parameters.AddWithValue("@CUI", txtCui.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Contacto", txtConta.Text);
                    int ejecutar = comando.ExecuteNonQuery();

                    if (ejecutar > 0)
                    {
                        MessageBox.Show("Información ingresada correctamente", "Ingresar Datos", MessageBoxButtons.OK);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("error, no se ingreso correctamente", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, no se ingreso el Información", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }

        //boton de Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtCui.Enabled = true;
            btnBuscar.Enabled = true;
            // Consultar desde Sql
            string actualizar = @"Update " + objConexion.nombreBD() + ".dbo.Proveedores" +
                             " SET CUI = @CUI ,Nombre = @Nombre," +
                             " Contacto = @Contacto " +
                             " WHERE CUI = @CUI";

            SqlConnection conexion = objConexion.AbrirConexion();
            try
            {
                using (SqlCommand comando = new SqlCommand(actualizar, conexion))
                {
                    comando.Parameters.AddWithValue("@CUI", txtCui.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Contacto", txtConta.Text);



                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Información actualizada", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();

                    }
                    // Si no se logro actualizar o hubó algún error notificar al usuario
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

        //Botón para eliminar datos
        private void btneliminar_Click(object sender, EventArgs e)
        {

            txtCui.Enabled = true;
            btnBuscar.Enabled = true;
            //hacer la consulta de borrar desde la BD
            string eliminar = @"DELETE FROM " + objConexion.nombreBD() + ".dbo.Proveedores WHERE CUI = @CUI";

            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand(eliminar, conexion))
                {
                    cmd.Parameters.AddWithValue("@CUI", txtCui.Text);

                    // Pedirle confirmación al usuario
                    if (MessageBox.Show("¿Estás seguro de eliminar el producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("El producto se ha eliminado exitosamente");
                            Limpiar();
                            btneliminar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún producto con ese código");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó el producto");

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

        //Entrar a la ventana de Ver Tabla
        private void btnVer_Click(object sender, EventArgs e)
        {
            VerTablaProve abrirTablaProve = new VerTablaProve();
            abrirTablaProve.Show();
            Hide();
        }

        //Boton para buscar datos 
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            // Verificar si el campo código está vacío
            if (string.IsNullOrWhiteSpace(txtCui.Text))
            {
                MessageBox.Show("Debe de ingresar un CUI para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta SQL corregida con los nombres correctos
            string buscar = @"SELECT CUI, Nombre, Contacto 
                              FROM " + objConexion.nombreBD() + ".dbo.Proveedores"
                             + " WHERE CUI = @CUI";

            SqlConnection conexion = objConexion.AbrirConexion();
            if (conexion == null) return;

            try
            {
                using (SqlCommand comando = new SqlCommand(buscar, conexion))
                {
                    comando.Parameters.AddWithValue("@CUI", txtCui.Text);

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            txtCui.Text = leer["CUI"].ToString();
                            txtNombre.Text = leer["Nombre"].ToString();
                            txtConta.Text = leer["Contacto"].ToString();


                            // Solo si encontró, entonces desactiva el campo código y botones
                            txtCui.Enabled = false;
                            btnBuscar.Enabled = false;
                            btneliminar.Enabled = true;
                        }

                        // solo sí no se encontró el código o si falló
                        else
                        {
                            MessageBox.Show("No se encontró el Proveedor con ese CUI", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el código: " + ex.Message);
            }
            //cerrar conexión con BD
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }
    }
}


