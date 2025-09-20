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
    public partial class Productos : Form
    {
        Conexion objConexion = new Conexion();

        public Productos()
        {
            InitializeComponent();

        }


        private void Activar()
        {
            txtNombre.Enabled = true;
            txtCate.Enabled = true;
            txtPrecio.Enabled = true;
            txtCodigo.Enabled = true;
            txtProvId.Enabled = true;
            txtStokM.Enabled = true;
            txtStock.Enabled = true;
            btnActualizar.Enabled = true;
        }

        //para limpiar las casillas despúes de usar cada botón
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCate.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtStokM.Clear();
            txtProvId.Clear();


        }


        //boton para regresar al menu
        private void button5_Click(object sender, EventArgs e)
        {
            index abrirmenu = new index();
            abrirmenu.Show();
            this.Hide();
        }

        //boton de guardar
        private void btnguardar_Click(object sender, EventArgs e)

        {
            string IngresarProducto = "INSERT INTO " + objConexion.nombreBD() + ".dbo.Productos" +
                "(codigo, Nombre, Categoria, Precio, Stock, StockMinimo, ProveedorId)" +
                " VALUES (@codigo, @Nombre, @Categoria, @Precio, @Stock, @StockMinimo, @ProveedorId);";
            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand comando = new SqlCommand(IngresarProducto, conexion))
                {
                    //le pasamos los parametros a la consulta
                    comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Categoria", txtCate.Text);
                    comando.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@Stock", txtStock.Text);
                    comando.Parameters.AddWithValue("@StockMinimo", txtStokM.Text);
                    comando.Parameters.AddWithValue("@ProveedorId", txtProvId.Text);

                    int ejecutar = comando.ExecuteNonQuery();

                    if (ejecutar > 0)
                    {
                        MessageBox.Show("Producto ingresado correctamente", "Ingresar Producto", MessageBoxButtons.OK);
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
                MessageBox.Show("Error, no se ingreso el producto", "Error", MessageBoxButtons.OK);
            }
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }

        //boton de Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            btnBuscar.Enabled = true;
            // Consultar desde Sql 
            string actualizar = @"Update " + objConexion.nombreBD() + ".dbo.Productos" +
                             " SET codigo = @codigo ,Nombre = @Nombre," +
                             "Precio = @precio ,Stock = @Stock ," +
                             "StockMinimo = @StockMinimo ,ProveedorId = @ProveedorId WHERE codigo = @codigo";

            SqlConnection conexion = objConexion.AbrirConexion();
            try
            {
                using (SqlCommand comando = new SqlCommand(actualizar, conexion))
                {
                    comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    comando.Parameters.AddWithValue("@Categoria", txtCate.Text);
                    comando.Parameters.AddWithValue("@Precio", txtPrecio.Text);
                    comando.Parameters.AddWithValue("@Stock", txtStock.Text);
                    comando.Parameters.AddWithValue("@StockMinimo", txtStokM.Text);
                    comando.Parameters.AddWithValue("@ProveedorId", txtProvId.Text);


                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("producto actualizado", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        btnActualizar.Enabled = false;
                    }
                    // Si no se logro actualizar o hubó algún error notificar al usuario
                    else
                    {
                        MessageBox.Show("Error al actualizar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            txtCodigo.Enabled = true;
            btnBuscar.Enabled = true;
            //hacer la consulta de borrar desde la BD
            string eliminar = @"DELETE FROM " + objConexion.nombreBD() + ".dbo.Productos WHERE codigo = @codigo";

            SqlConnection conexion = objConexion.AbrirConexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand(eliminar, conexion))
                {
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);

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
                        //
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
            VerTablaProdu abrirTablaProdu = new VerTablaProdu();
            abrirTablaProdu.Show();
            Hide();
        }

        //Boton para buscar datos 
        private void btnBuscar_Click(object sender, EventArgs e)

        {
            // Verificar si el campo código está vacío
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe de ingresar un código para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Consulta SQL corregida con los nombres correctos
            string buscar = @"SELECT codigo, Nombre, Categoria, Precio, Stock, StockMinimo, ProveedorId 
                              FROM " + objConexion.nombreBD() + ".dbo.Productos"
                             + " WHERE codigo = @codigo";

            SqlConnection conexion = objConexion.AbrirConexion();
            if (conexion == null) return;

            try
            {
                using (SqlCommand comando = new SqlCommand(buscar, conexion))
                {
                    comando.Parameters.AddWithValue("@codigo", txtCodigo.Text);

                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            txtCodigo.Text = leer["codigo"].ToString();
                            txtNombre.Text = leer["Nombre"].ToString();
                            txtCate.Text = leer["Categoria"].ToString();
                            txtPrecio.Text = leer["Precio"].ToString();
                            txtStock.Text = leer["Stock"].ToString();
                            txtStokM.Text = leer["StockMinimo"].ToString();
                            txtProvId.Text = leer["ProveedorId"].ToString();

                            // Solo si encontró, entonces desactiva el campo código y botones
                            txtCodigo.Enabled = false;
                            btnBuscar.Enabled = false;
                            btneliminar.Enabled = true;
                        }
                        // solo sí no se encontró el código o si falló
                        else
                        {
                            MessageBox.Show("No se encontró el producto con ese código", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el código: " + ex.Message);
            }
            //Cerrar la conexión
            finally
            {
                objConexion.CerrarCon(conexion);
            }
        }

    }
}
