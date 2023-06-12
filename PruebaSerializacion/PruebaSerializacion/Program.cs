using Entidades;
using System.Security.AccessControl;

namespace PruebaSerializacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona objeto = new Persona("Pepe", "lala", 23);

            // Serializar el objeto en XML
            FileSerializer.SerializerToXml<Persona>(objeto, @"C:\Users\juan pablo gonzalez\Documents\Facultad\archivo.xml");

            // Deserializar el objeto desde XML
            Persona objetoDeserializadoXml = FileSerializer.DeserializeFromXml<Persona>(@"C:\Users\juan pablo gonzalez\Documents\Facultad\archivo.xml");

            if (objetoDeserializadoXml != null)
            {
                Console.WriteLine("Nombre (XML): " + objetoDeserializadoXml.Nombre);
                Console.WriteLine("Edad (XML): " + objetoDeserializadoXml.Edad);
            }

            // Serializar el objeto en JSON
            FileSerializer.SerializeToJson<Persona>(objeto, @"C:\Users\juan pablo gonzalez\Documents\Facultad\archivo.json");

            // Deserializar el objeto desde JSON
            Persona objetoDeserializadoJson = FileSerializer.DeserializeFromJson<Persona>(@"C:\Users\juan pablo gonzalez\Documents\Facultad\archivo.json");

            if (objetoDeserializadoJson != null)
            {
                Console.WriteLine("Nombre (JSON): " + objetoDeserializadoJson.Nombre);
                Console.WriteLine("Edad (JSON): " + objetoDeserializadoJson.Edad);
            }

        }
    }
}
