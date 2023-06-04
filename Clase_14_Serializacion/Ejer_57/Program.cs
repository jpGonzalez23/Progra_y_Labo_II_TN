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
                Persona persona1 = new Persona("John", "Doe");
                Persona.Guardar(persona1);

                Persona persona2 = Persona.Leer();
                Console.WriteLine(persona2);
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