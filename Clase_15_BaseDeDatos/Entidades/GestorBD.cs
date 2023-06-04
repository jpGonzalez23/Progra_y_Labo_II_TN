using System.Data.SqlClient;

namespace Entidades
{
    public class GestorBD
    {
        static string stringConnection = "Server=.;Database=clase_15;Trusted_Connection=True;";

        public static List<Empleados> GetEmplado()
        {
            List<Empleados> empledo = new List<Empleados>();

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "SELECT * FROM EMPLEADOS";
                SqlCommand cmd = new SqlCommand(sentencia, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                
                //cmd.BeginExecuteNonQuery(); -> Para todas las sentencia  que no sean de lectura

                while (reader.Read())
                {
                    //empledo.Add(new Empleados(reader[0], reader[1], reader[2], reader[3]));
                    empledo.Add(new Empleados(reader.GetInt32(0), 
                                              reader.GetString(1), 
                                              reader.GetString(2), 
                                              reader.GetInt32(3)));
                }

                return empledo;
            }
        }

        public static Empleados GetUnEmplado(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "SELECT * FROM EMPLEADOS WHERE ID = @id";
                
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                
                cmd.Parameters.AddWithValue("id", id);
                
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                //cmd.BeginExecuteNonQuery(); -> Para todas las sentencia  que no sean de lectura

                while (reader.Read())
                {
                    //empledo.Add(new Empleados(reader[0], reader[1], reader[2], reader[3]));
                    return new Empleados(reader.GetInt32(0),  reader.GetString(1), 
                                         reader.GetString(2), reader.GetInt32(3));
                }
                throw new Exception("No existe el compleado");
            }
        }

        public static int InsertEmpleado(Empleados emplado)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_SECTOR) VALUES (@nombre, @apellido, @idSector)";
                
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                
                cmd.Parameters.AddWithValue("nombre", emplado.Nombre);
                cmd.Parameters.AddWithValue("apellido", emplado.Apellido);
                cmd.Parameters.AddWithValue("idSector", emplado.IdSector);
                
                connection.Open();

                return cmd.ExecuteNonQuery();
            }
        }
    }
}