using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modulos;

namespace Entidades.BaseDeDatos
{
    public class GestorBaseDeDatos : IGuardar<AutoF1>
    {
        private static string stringConnection;

        /// <summary>
        /// Constructor para realizar la coneccion con la base de datos
        /// </summary>
        static GestorBaseDeDatos()
        {
            try
            {
                GestorBaseDeDatos.stringConnection = "Server =.; Database = 20210717-RSP; Trusted_Connection = True;";
            }
            catch (Exception)
            {

                throw new GestorBaseDeDatosException("Error al conectarse a la base de datos\n");
            }
        }

        /// <summary>
        /// Metodo para Guardar los autos
        /// </summary>
        /// <param name="auto"></param>
        /// <exception cref="GestorBaseDeDatosException">Se genera una excepcion si no se pudo guardar</exception>
        public void Guardar(AutoF1 auto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    string sentencia = "INSERT INTO resultados(idposiciones, escuderia, posicion, horaLlegada) VALUES (@idPosicon, @escuderia, @posicion, @horaLlegada) ";
                    SqlCommand command = new SqlCommand(sentencia, connection);
                    command.Parameters.AddWithValue("@idPosicion", auto.UbicacionEnPista);
                    command.Parameters.AddWithValue("@escuderia", auto.Escuderia);
                    command.Parameters.AddWithValue("@posicion", auto.Posicion);
                    command.Parameters.AddWithValue("@horaLlegada", auto.Velocidad);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new GestorBaseDeDatosException("Error al guardar en la base de datos", e);
            }
        }
    }
}
