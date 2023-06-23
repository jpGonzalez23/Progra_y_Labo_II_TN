using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Interfaces;

namespace Entidades.DataBase
{
    public static class DataBaseManager
    {
        private static SqlConnection connection;
        private static string stringConnection;

        static DataBaseManager()
        {
            DataBaseManager.stringConnection = "Server=.;Database=20230622SP;Trusted_Connection=True;";
        }

        public static string GetImagenComida(string tipo)
        {
            try
            {
                using (DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string sentencia = $"SELECT * FROM comidas WHERE tipo_comida = @{tipo}";

                    SqlCommand cmd = new SqlCommand(sentencia, DataBaseManager.connection);
                    cmd.Parameters.AddWithValue("@tipo_comida", tipo);

                    DataBaseManager.connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ComidaInvalidaExeption("Error al conseguir una imagen");
            }
        }

        public static bool GuardarTicket<T>(string nombreEmpleado, T comida) where T : IComestible, new ()
        {
            try
            {
                using (DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string sentencia = "INSERT INTO ticktes (nombre, ticket) VALUES (@nombre, @ticket)";

                    SqlCommand cmd = new SqlCommand(sentencia, DataBaseManager.connection);

                    //cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombre", nombreEmpleado);
                    cmd.Parameters.AddWithValue("@ticket", comida);

                    cmd.ExecuteNonQuery();
                }
            } 
            catch(Exception ex)
            {
                throw new DataBaseManagerException("Error al guardar el ticket", ex);
            }
        }
    }
}
