using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class JuegoDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader lector;

        static JuegoDao()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "EJERCICIOS_UTN";
            JuegoDao.cadenaConexion = builder.ConnectionString;
            JuegoDao.conexion = new SqlConnection(JuegoDao.cadenaConexion);
        }

        public static bool EliminarJuego(int CODIGO_JUEGO)
        {
            bool rta = true;
            try
            {
                JuegoDao.comando = new SqlCommand();
                JuegoDao.comando.Parameters.AddWithValue("@CODIGO_JUEGO", CODIGO_JUEGO);
                string sql = "DELETE FROM JUEGOS ";
                sql += "WHERE CODIGO_JUEGO = @CODIGO_JUEGO";

                JuegoDao.comando.CommandType = CommandType.Text;
                JuegoDao.comando.CommandText = sql;
                JuegoDao.comando.Connection = JuegoDao.conexion;

                JuegoDao.conexion.Open();

                int filasAfectadas = JuegoDao.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return rta;
        }

        public static bool ModificarJuego(Juego param)
        {
            bool rta = true;
            try
            {
                JuegoDao.comando = new SqlCommand();
                JuegoDao.comando.Parameters.AddWithValue("@CodigoJuego", param.CodigoJuego);
                JuegoDao.comando.Parameters.AddWithValue("@CodigoUsuario", param.CodigoUsuario);
                JuegoDao.comando.Parameters.AddWithValue("@Genero", param.Genero);
                JuegoDao.comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                JuegoDao.comando.Parameters.AddWithValue("@Precio", param.Precio);

                string sql = "UPDATE JUEGOS ";
                sql += "SET CODIGO_USUARIO = @CodigoUsuario, GENERO = @Genero, NOMBRE = @Nombre, PRECIO = @Precio ";
                sql += "WHERE CODIGO_JUEGO = @CodigoJuego";

                JuegoDao.comando.CommandType = CommandType.Text;
                JuegoDao.comando.CommandText = sql;
                JuegoDao.comando.Connection = JuegoDao.conexion;
                JuegoDao.conexion.Open();

                int filasAfectadas = JuegoDao.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return rta;
        }

        public static bool AgregarJuego(Juego param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO JUEGOS (CODIGO_USUARIO, GENERO, NOMBRE, PRECIO) VALUES(";
                sql = sql + param.CodigoUsuario + ",'" + param.Genero + "'," +  "'" + param.Nombre + "'," + param.Precio + ")";

                JuegoDao.comando = new SqlCommand();

                JuegoDao.comando.CommandType = CommandType.Text;
                JuegoDao.comando.CommandText = sql;
                JuegoDao.comando.Connection = JuegoDao.conexion;

                JuegoDao.conexion.Open();

                int filasAfectadas = JuegoDao.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return rta;
        }


        public static 


        public static Juego ObtenerJuego(int ID)
        {
            Juego juego = null;
            try
            {
                JuegoDao.comando = new SqlCommand();
                JuegoDao.comando.Parameters.AddWithValue("@CodigoJuego", ID);
                JuegoDao.comando.CommandType = CommandType.Text;
                JuegoDao.comando.CommandText = "SELECT CODIGO_JUEGO, CODIGO_USUARIO, NOMBRE, PRECIO, GENERO FROM JUEGOS WHERE CODIGO_JUEGO = @CodigoJuego";
                JuegoDao.comando.Connection = JuegoDao.conexion;
                JuegoDao.conexion.Open();
                JuegoDao.lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    juego = new Juego(lector[2].ToString() ?? "", lector.GetInt32(3), lector[4].ToString() ?? "", lector.GetInt32(0));
                }
                JuegoDao.lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return juego;
        }
    }
}
