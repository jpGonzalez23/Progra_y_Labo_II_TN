using System.Xml.Serialization;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public static void Guardar(Persona p)
        {
            try
            {
                string archivoInvalido = "";
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                FileStream fileStream = new FileStream(archivoInvalido, FileMode.Create);
                serializer.Serialize(fileStream, p);
                fileStream.Close();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error al guardar la persona: " + e.Message);
            }
        }

        public static Persona Leer()
        {
            try
            {
                string archivoInvalido = "";
                XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                FileStream fileStream = new FileStream(archivoInvalido, FileMode.Open);
                Persona persona = (Persona)serializer.Deserialize(fileStream);
                fileStream.Close();
                return persona;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error al leer la persona: " + e.Message);
                return null;
            }
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} Apellido: {this.Apellido}";
        }
    }
}