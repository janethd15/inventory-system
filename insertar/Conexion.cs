using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PruebaConexionBD1
{
    internal class Conexion
    {
        //Procedemos a realizar los atributos de conexion 
        public static string servidor = "DESKTOP-OPGRA4G";
        public static string DB = "Intelaf";


        public static string conexion = $"server={servidor};database={DB};Integrated Security=True";

        private static SqlConnection conect = new SqlConnection();

        public static bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        //
        public SqlConnection AbrirConexion()
        {
            SqlConnection nueva = new SqlConnection(conexion);
            try
            {
                nueva.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("error, no se puede conectar", "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return nueva;
        }
        //
        public void CerrarCon(SqlConnection con)
        {
            if (con != null && con.State != ConnectionState.Closed)
            {
                con.Close();
                con.Dispose();
            }
        }
        //permite que sea escalable segun la BD al usar
        public string nombreBD()
        {
            return DB;
        }
    }

}