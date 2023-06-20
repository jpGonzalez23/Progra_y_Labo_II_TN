using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modulos;

namespace Entidades.Archivos
{
    public class GestorDeArchivo : IGuardar<AutoF1>, IGuardar<Carrera>
    {
        private static string ruta;

        /// <summary>
        /// Constructor donde se inicializa la ruta
        /// </summary>
        static GestorDeArchivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\Juan_Pablo_Gonzalez\\";
        }

        /// <summary>
        /// Motodo para guardar en .xml
        /// </summary>
        /// <param name="carrera">Parametro a recibir</param>
        /// <exception cref="GestorDeArchivosException">
        ///     Se genera una excepcion si no se puede guardar en formato .xml
        /// </exception>
        public void Guardar(Carrera carrera)
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Carrera));
                using (TextWriter writer = new StreamWriter("datos_carrera.xml"))
                {
                    xml.Serialize(writer, carrera);
                }
            }
            catch (Exception ex)
            {
                throw new GestorDeArchivosException("Error al guardar la carrera\n", ex);
            }
        }

        /// <summary>
        /// Metodo para guardar en formarto .txt
        /// </summary>
        /// <param name="auto"></param>
        /// <exception cref="GestorDeArchivosException">
        ///     Se genera una excepcion en caso de no poner guardar en formato de .txt
        /// </exception>
        void IGuardar<AutoF1>.Guardar(AutoF1 auto)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(GestorDeArchivo.ruta))
                {
                    writer.WriteLine($"Escuderia: {auto.Escuderia}");
                    writer.WriteLine($"Posicion: {auto.Posicion}");
                    writer.WriteLine($"Velocidad: {auto.Velocidad}");
                    writer.WriteLine($"Ubicacion en la pista: {auto.UbicacionEnPista}");

                }
            }
            catch(Exception ex)
            {
                throw new GestorDeArchivosException("Error al guardar el formato .txt\n", ex);
            }
        }

        /// <summary>
        /// Metodo para Leer el archivo en formato .xml
        /// </summary>
        /// <returns>Retorna el archivo leido</returns>
        /// <exception cref="GestorDeArchivosException">Se genera una excepcion en caso de no poder leer el archivo</exception>
        public Carrera LeerXML()
        {
            try
            {
               Carrera carrera;
                XmlSerializer xml = new XmlSerializer(typeof(Carrera));
                using (TextReader reader = new StreamReader("datos_carrera.xml"))
                {
                    carrera = (Carrera)xml.Deserialize(reader);
                }
                return carrera;
            }
            catch (Exception ex)
            {
                throw new GestorDeArchivosException("Erro al leer el archivo\n", ex);
            }
        }
    }
}
