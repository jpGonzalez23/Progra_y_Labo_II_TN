using Entidades;
namespace Ejer_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°21";

            Fahrenheit f = new Fahrenheit(320);
            Celsius c = new Celsius(34);
            Kelvin k = new Kelvin(55);

            Console.WriteLine(f.GetCantidad());
            Console.WriteLine(c.GetCantidad());
            Console.WriteLine(k.GetCantidad());


        }
    }
}