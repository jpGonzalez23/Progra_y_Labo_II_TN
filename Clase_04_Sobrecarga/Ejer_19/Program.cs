using Entidades;

namespace Ejer_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°19";

            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador(2);

            Console.WriteLine($"Suma de objetos: {s1 + s2}");
            Console.WriteLine($"Suma de long: {s2.Sumar(100, 6000)} Sumador {s2.Cantidad()}");
            Console.WriteLine($"Suma de objetos: {s1 + s2}");
            Console.WriteLine($"Suma de long: {s1.Sumar("Hola", "Mundo")} Sumador {s1.Cantidad()}");

            if (s1 | s2)
            {
                Console.WriteLine("Es True");
            }
            Console.WriteLine($"Suma de objetos: {s1 + s2}");


        }
    }
}