using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Apellido { get => this.apellido; set => this.apellido = value; }

        public static bool Guardar(Persona p)
        {
            XmlTextWriter xmlTextWriter = null;
            XmlSerializer xmlSerializer = null;

            try
            {
                xmlTextWriter = new XmlTextWriter("ArchivoXml.xml", Encoding.UTF8);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlSerializer = new XmlSerializer(typeof(Persona));
                xmlSerializer.Serialize(xmlTextWriter, p);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xmlTextWriter != null)
                {
                    xmlTextWriter.Close();  
                }
            }
        }

        public static Persona Leer(string archivoXml)
        {
            XmlTextReader xmlTextReader = null;
            XmlSerializer xmlSerializer = null; 

            try
            {
                xmlTextReader = new XmlTextReader(archivoXml);

                xmlSerializer = new XmlSerializer(typeof(Persona));

                return (Persona)xmlSerializer.Deserialize(xmlTextReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
            }
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} Apellido: {this.Apellido}";
        }
    }
}