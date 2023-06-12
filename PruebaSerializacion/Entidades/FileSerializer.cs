using System.Net.Http.Json;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Text.Json;

namespace Entidades
{
    public class FileSerializer
    {
        public static void SerializerToXml<T>(T obj, string filePath)
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(filePath, System.Text.Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(writer, obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al serializar el objeto en XML: {ex.ToString()}");
            }
        }

        public static T DeserializeFromXml<T>(string filePath)
        {
            try
            {
                using (XmlTextReader reader = new XmlTextReader("Datos.xml"))
                {
                    //Creo un objeto que 'sabe' como deserializar de XML
                    //Le tengo que indicar que tipo de objeto se va a deserializar
                    XmlSerializer ser = new XmlSerializer(typeof(T));


                    //Utilizo el método Deserialize, pasándole el 'lector' de XML
                    //Debo 'castear' al tipo de dato específico, ya que 
                    //el método Deserialize retorna un Object
                    return (T)ser.Deserialize(reader);

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al deserializar el objeto desde XML: {ex.ToString()}");
                return default(T);
            }
        }

        public static void SerializeToJson<T>(T obj, string filePath)
        {
            try
            {
                string json = JsonConvert.SerializeObject(obj, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al serializar el objeto en formato JSON: " + ex.Message);
            }
        }

        public static T DeserializeFromJson<T>(string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar el objeto desde JSON: " + ex.Message);
                return default(T);
            }
        }
    }
}