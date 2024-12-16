using System;
using System.Data.SqlClient;

namespace ProyServTuristico_GUI
{
    public class LoginADO
    {
        private SqlConnection connection;

        public LoginADO()
        {
            connection = new SqlConnection(@"Server=localhost;Database=ProyectoTurismo;Trusted_Connection=True;");
        }

        private void AbrirConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        private void CerrarConexion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public bool ValidarUsuario(string usuario, string contraseña, out string estadoUsuario, out string nombreUsuario)
        {
            estadoUsuario = string.Empty;
            nombreUsuario = string.Empty;

            try
            {
                AbrirConexion();

                string query = "SELECT Est_Usu, Login_Usuario FROM Tb_Usuario WHERE Login_Usuario=@Usuario AND Pass_Usu=@Contraseña";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    estadoUsuario = reader["Est_Usu"].ToString();
                    nombreUsuario = reader["Login_Usuario"].ToString();
                    return estadoUsuario.Equals("Activo", StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

    }
}
