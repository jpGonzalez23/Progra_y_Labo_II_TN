namespace Ejer_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio N°6";

            int inicio;
            int fin;
            int i;

            Console.Write("Ingrese el año de inicio: ");
            int.TryParse(Console.ReadLine(), out inicio);

            Console.Write("Ingrese el año de fin: ");
            int.TryParse(Console.ReadLine(), out fin);

            for (i = inicio; i < fin; i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}