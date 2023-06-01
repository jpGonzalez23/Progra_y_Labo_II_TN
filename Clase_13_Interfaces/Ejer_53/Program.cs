using Entidades.Modules;

namespace Ejer_53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°53";
            int cont = 0;
            ConsoleColor colorOriginal = Console.ForegroundColor;
            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            Cartuchera1 catuchera1 = new Cartuchera1();
            Cartuchera2 cartuchera2 = new Cartuchera2();

            catuchera1.Acciones.Add(miBoligrafo);
            catuchera1.Acciones.Add(miLapiz);

            cartuchera2.BoligrafoList.Add(miBoligrafo);
            cartuchera2.BoligrafoList.Add(miBoligrafo);
            cartuchera2.LapizList.Add(miLapiz);
            cartuchera2.LapizList.Add(miLapiz);

            do
            {
                Console.WriteLine($"Escribiendo: {cont}");
                cont++;
            } while (catuchera1.ProbarElementos());
            cont = 0;
            Console.WriteLine("\n\nCartuchera2 \n");
            do
            {
                Console.WriteLine($"Escribiendo: {cont}");
                cont++;
            } while (cartuchera2.ProbarElementos());



            Console.ReadKey();
        }
    }
    }
}