using Entidades;
using System.Runtime.Serialization;

namespace Ejer_57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°57";

            try
            {
                string archivo = "AchivoXML.xml";
                Persona persona = new Persona("Juan Pablo", "gonzalez");
                Persona.Guardar(persona);
                Console.WriteLine((Persona.Leer(archivo)).ToString());
                Console.ReadKey();
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Error de serialización: " + e.Message);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Error al encontrar el archivo: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error inesperado: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}