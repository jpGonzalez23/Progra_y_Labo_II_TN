using Entidades;

namespace Ejer_I02_Parte_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02";

            string directorio = "C:\\Documentos";
            string archivo = "C:\\Escritorio\\HolMundo.txt";

            // Prueba de VerificarSiExisteDirectorio en el Main
            bool directorioExistente = Persistencia.VerificarSiExisteDirectorio(directorio);
            Console.WriteLine($"El directorio existe o fue creado: {directorioExistente}");

            // Prueba de VerificarSiExisteArchivo en el Main
            bool archivoExistente = Persistencia.VerificarSiExisteArchivo(archivo);
            Console.WriteLine($"El archivo existe o fue creado: {archivoExistente}");
        }
    }
}