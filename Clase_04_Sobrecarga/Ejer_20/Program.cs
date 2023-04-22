using Entidades;

namespace Ejer_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°20";

            Euro e = new Euro(300);
            Dolar d = new Dolar(500);
            Peso p = new Peso(10000);

            Console.WriteLine(p.GetCantidad());
            Console.WriteLine(d.GetCantidad());
            Console.WriteLine(e.GetCantidad());
        }
    }
}