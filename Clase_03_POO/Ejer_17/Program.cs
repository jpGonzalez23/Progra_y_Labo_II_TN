using Entidades;

namespace Ejer_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°17";

            ConsoleColor colorOriginalDeConsola = Console.ForegroundColor;
            string dibujo; //Variable para dibujar


            Boligrafo boligrafoDarkYellow = new Boligrafo(ConsoleColor.DarkYellow, 20);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();
            boligrafoDarkYellow.Pintura(10, out dibujo);
            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;
            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            boligrafoDarkYellow.Pintura(5, out dibujo);
            Console.ForegroundColor = boligrafoDarkYellow.GetColor();

            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorOriginalDeConsola;

            Console.WriteLine($"El nivel de tinta del boligrafo DarkYellow es {boligrafoDarkYellow.GetTinta()}");
            Console.WriteLine("\n\nIntentamos volver a gastar tinta");
            boligrafoDarkYellow.Pintura(3, out dibujo);
            Console.WriteLine(dibujo);
            Console.ReadKey();
        }
    }
}