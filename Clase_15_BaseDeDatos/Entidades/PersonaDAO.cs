using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class PersonaDAO
    {
        static string stringConnection = @"Server=.;Database=Ejer_61;Trusted_Connection=True;";
        public void Guardar(Persona persona)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "INSERT INTO Persona (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                command.ExecuteNonQuery();
            }
        }

        public List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "SELECT * FROM Persona";
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   personas.Add(new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                }
            }
            return personas;
        }

        public Persona LeerPorID(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "SELECT * FROM Persona WHERE ID = @ID";
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new Persona(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
            }
            return null;
        }

        public void Modificar(Persona persona)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido WHERE ID = @ID";
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@Nombre", persona.Nombre);
                command.Parameters.AddWithValue("@Apellido", persona.Apellido);
                command.Parameters.AddWithValue("@ID", persona.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Borrar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "DELETE FROM Persona WHERE ID = @ID";
                connection.Open();
                SqlCommand command = new SqlCommand(sentencia, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
