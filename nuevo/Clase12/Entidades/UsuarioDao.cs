using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader lector;

        static UsuarioDao()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @".";
            builder.IntegratedSecurity = true;
            //builder.UserID = "usuario";
            //builder.Password = "clave";
            builder.InitialCatalog = "EJERCICIOS_UTN";

            UsuarioDao.cadenaConexion = builder.ConnectionString;
            UsuarioDao.conexion = new SqlConnection(UsuarioDao.cadenaConexion);
        }

        public static bool ProbarConexion()
        {
            bool rta = true;
            try
            {
                UsuarioDao.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (UsuarioDao.conexion.State == ConnectionState.Open)
                {
                    UsuarioDao.conexion.Close();
                }
            }
            return rta;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                UsuarioDao.comando = new SqlCommand();
                UsuarioDao.comando.CommandType = CommandType.Text;
                UsuarioDao.comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";
                UsuarioDao.comando.Connection = UsuarioDao.conexion;
                UsuarioDao.conexion.Open();
                UsuarioDao.lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Usuario usuario = new Usuario(lector[1].ToString(), lector.GetInt32(0));
                    lista.Add(usuario);
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (UsuarioDao.conexion.State == ConnectionState.Open)
                {
                    UsuarioDao.conexion.Close();
                }
            }
            return lista;
        }
    }
}
