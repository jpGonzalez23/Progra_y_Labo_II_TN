using Entidades;

namespace Ejer_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercico N°39";
            SobreSobrescrito obj = new SobreSobrescrito();
            Console.WriteLine("MiPropiedad: " + obj.MiPropiedad);
            Console.WriteLine("MiMetodo: " + obj.MiMetodo());
        }
    }
}